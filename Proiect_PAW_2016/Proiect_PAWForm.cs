using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace Proiect_PAW
{
    public partial class Proiect_PAWForm : Form
    {
        private List<Director> ListaDirectoare;
        private DataBaseHelper DatabaseHelper = new DataBaseHelper();
        private delegate string[] DelegateExtrageFisiere(string _Director, string _ExtensiiFisiere, SearchOption _OptiuneCautare);

        public Proiect_PAWForm()
        {
            InitializeComponent();
        }

        private void Proiect_PAW_Load(object sender, EventArgs e)
        {
            this.ListaDirectoare = new List<Director>();
            DatabaseHelper.CreareTabel();
        }

        private void AdaugaDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selectati Un Director";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                    File.SetAttributes(directoryInfo.FullName, FileAttributes.Normal);
                    Director director = new Director();
                    director.SetNumeDirector(directoryInfo.Name);
                    director.SetLocatieDirector(directoryInfo.FullName);
                    List<Fisier> listaFisiere = CreareListaFisiere(director);
                    director.SetListaFisiere(listaFisiere);
                    this.ListaDirectoare.Add(director);
                    PopuleazaListViewDirectoare(director);
                    PopuleazaTreeView(director);
                }
                catch (UnauthorizedAccessException _ExceptionUnauthorizedAcces)
                {
                    Program.SalvareFisierLoguri(_ExceptionUnauthorizedAcces);
                }
            }
        }

        private void SalveazaInXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvareDirectoareXML();
            MessageBox.Show("Directoarele Au Fost Salvate In Fisier XML.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CitesteDinXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitireDirectoareXML();
            MessageBox.Show("Directoarele Au Fost Citite Din XML.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrinteazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printeaza");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvareDirectoareXML();
            Application.Exit();
        }

        private List<Fisier> CreareListaFisiere(Director _Director)
        {
            List<Fisier> listaFisiere = new List<Fisier>();
            DelegateExtrageFisiere delegateExtrageFisiere = new DelegateExtrageFisiere(ExtrageNumeFisiere);
            string[] fisiere = delegateExtrageFisiere(_Director.GetLocatieDirector(), "*.mp3|*.avi|*.flv|*.mp4|*.xvid|*.divx", SearchOption.AllDirectories);
            for (int Index = 0; Index < fisiere.Length; Index++)
            {
                FileInfo fileInfo = new FileInfo(fisiere[Index]);
                SchimbaAtributeleFisierelor(fileInfo.FullName);
                Fisier fisier = new Fisier();
                fisier.SetNumeFisier(fileInfo.Name);
                fisier.SetNumeComplet(fileInfo.FullName);
                fisier.SetExtensieFisier(fileInfo.Extension);
                fisier.SetDimensiuneFisier((fileInfo.Length) / 1024);
                List<string> rating = DatabaseHelper.SelectareInregistrare(fisier);
                if (rating.Count > 0)
                {
                    fisier.SetGen(rating[0]);
                    fisier.SetRecenzie(rating[1]);
                    if ((rating[2].ToLower()) == "true")
                    {
                        fisier.SetVizualizat(true);
                    }
                    else
                    {
                        fisier.SetVizualizat(false);
                    }
                }
                else
                {
                    fisier.SetGen("");
                    fisier.SetRecenzie("");
                    fisier.SetVizualizat(false);
                    DatabaseHelper.InserareInregistrare(fisier);
                }
                listaFisiere.Add(fisier);
            }
            return listaFisiere;
        }

        private string[] ExtrageNumeFisiere(string _Director, string _ExtensiiFisiere, SearchOption _OptiuneCautare)
        {
            string[] parti = _ExtensiiFisiere.Split('|');
            List<string> fisiere = new List<string>();
            for (int Index = 0; Index < parti.Length; Index++)
            {
                fisiere.AddRange(Directory.GetFiles(_Director, parti[Index], _OptiuneCautare));
            }
            return fisiere.ToArray();
        }

        private void PopuleazaListViewDirectoare(Director _Director)
        {
            ListViewItem listViewItem = new ListViewItem(_Director.GetNumeDirector(), 0);
            listViewItem.SubItems.Add(_Director.GetLocatieDirector());
            ListViewDirectoare.Items.Add(listViewItem);
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewDirectoare.SelectedIndices.Count > 0)
            {
                int IndexDirectorSelectat = ListViewDirectoare.SelectedIndices[0];
                PopuleazaListViewFisiere(IndexDirectorSelectat);
            }
            else
            {
                ListViewFisiere.Items.Clear();
            }
        }

        private void PopuleazaListViewFisiere(int _IndexDirectorSelectat)
        {
            if (ListViewFisiere.Items.Count > 0)
            {
                ListViewFisiere.Items.Clear();
            }
            else
            {
                for (int Index = 0; Index < this[_IndexDirectorSelectat].GetListaFisiere().Count; Index++)
                {
                    ListViewItem listViewItem = new ListViewItem(this[_IndexDirectorSelectat][Index].GetNumeFisier(), 0);
                    listViewItem.SubItems.Add(this[_IndexDirectorSelectat][Index].GetDimensiuneFisier().ToString());
                    ListViewFisiere.Items.Add(listViewItem);
                }
            }
        }

        private void PopuleazaTreeView(Director _Director)
        {
            TreeNode parinte = new TreeNode(_Director.GetNumeDirector());
            if (_Director.GetListaFisiere() != null)
            {
                for (int Index = 0; Index < _Director.GetListaFisiere().Count; Index++)
                {
                    TreeNode copil = new TreeNode(_Director.GetListaFisiere()[Index].GetNumeFisier());
                    parinte.Nodes.Add(copil);
                }
            }
            TreeView.Nodes.Add(parinte);
        }

        private void StergeFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ListViewDirectoare.SelectedIndices.Count > 0) && (ListViewFisiere.SelectedIndices.Count > 0))
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                int IndexFisier = ListViewFisiere.SelectedIndices[0];
                Fisier fisier = this[IndexDirector][IndexFisier];
                FileInfo fileInfo = new FileInfo(fisier.GetNumeComplet());
                if (fileInfo.Exists == true)
                {
                    if ((MessageBox.Show("Stergeti Fisierul Definitiv?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                    {
                        try
                        {
                            string sursa = fisier.GetNumeComplet();
                            File.Delete(sursa);
                            ListViewFisiere.Items[IndexFisier].Remove();
                            TreeView.Nodes[IndexDirector].Nodes[IndexFisier].Remove();
                            DatabaseHelper.StergeInregistrare(fisier);
                            this[IndexDirector].GetListaFisiere().Remove(fisier);
                        }
                        catch (UnauthorizedAccessException _ExceptionUnauthorizedAcces)
                        {
                            Program.SalvareFisierLoguri(_ExceptionUnauthorizedAcces);
                        }
                    }
                    else
                    {
                        ListViewFisiere.Items[IndexFisier].Remove();
                        TreeView.Nodes[IndexDirector].Nodes[IndexFisier].Remove();
                        DatabaseHelper.StergeInregistrare(fisier);
                        this[IndexDirector].GetListaFisiere().Remove(fisier);
                    }
                }
                else
                {
                    ListViewFisiere.Items[IndexFisier].Remove();
                    TreeView.Nodes[IndexDirector].Nodes[IndexFisier].Remove();
                    DatabaseHelper.StergeInregistrare(fisier);
                    this[IndexDirector].GetListaFisiere().Remove(fisier);
                }
            }
            else
            {
                MessageBox.Show("Nu Ai Selectat Niciun Fisier", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RedenumireFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ListViewDirectoare.SelectedIndices.Count > 0) && (ListViewFisiere.SelectedIndices.Count > 0))
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                int IndexFisier = ListViewFisiere.SelectedIndices[0];
                Fisier fisier = this[IndexDirector][IndexFisier];
                FileInfo fileInfo = new FileInfo(fisier.GetNumeComplet());
                if (fileInfo.Exists == true)
                {
                    if ((MessageBox.Show("Redenumiti Fisierul?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                    {
                        string NumeCompletVechi = fisier.GetNumeComplet();
                        string NumeVechi = fisier.GetNumeFisier();
                        try
                        {
                            this.Hide();
                            Form RedenumireForm = new RedenumireFisierForm(fisier);
                            RedenumireForm.ShowDialog();
                            string numeNou = fileInfo.DirectoryName + "\\" + fisier.GetNumeFisier();
                            fisier.SetNumeFisier(fisier.GetNumeFisier());
                            fisier.SetNumeComplet(numeNou);
                            File.Move(NumeCompletVechi, fisier.GetNumeComplet());
                            ListViewFisiere.Items[IndexFisier].Text = fisier.GetNumeFisier();
                            TreeView.Nodes[IndexDirector].Nodes[IndexFisier].Text = fisier.GetNumeFisier();
                            DatabaseHelper.ActualizareInregistrare(NumeVechi, fisier);
                        }
                        catch (ArgumentException _ExceptionArgumentException)
                        {

                            Program.SalvareFisierLoguri(_ExceptionArgumentException);
                        }
                        catch (UnauthorizedAccessException _ExceptionUnauthorizedAcces)
                        {
                            Program.SalvareFisierLoguri(_ExceptionUnauthorizedAcces);
                        }
                        finally
                        {
                            fisier.SetNumeComplet(NumeCompletVechi);
                            fisier.SetNumeFisier(NumeVechi);
                        }
                    }
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu Ai Selectat Niciun Fisier", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopiereFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ListViewDirectoare.SelectedIndices.Count > 0) && (ListViewFisiere.SelectedIndices.Count > 0))
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                int IndexFisier = ListViewFisiere.SelectedIndices[0];
                Fisier fisier = this[IndexDirector][IndexFisier];
                FileInfo fileInfo = new FileInfo(fisier.GetNumeComplet());
                if (fileInfo.Exists == true)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "Selectati Directorul Destinatie!";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string sursaFisier = fisier.GetNumeComplet();
                            string destiantieFisier = folderBrowserDialog.SelectedPath + "\\" + fisier.GetNumeFisier();
                            File.Copy(fisier.GetNumeComplet(), destiantieFisier);
                        }
                        catch (UnauthorizedAccessException _ExceptionUnauthorized)
                        {
                            Program.SalvareFisierLoguri(_ExceptionUnauthorized);
                        }
                        catch (IOException _Exception)
                        {
                            Program.SalvareFisierLoguri(_Exception);
                        }
                    }
                }
            }
        }

        private void MutareFisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ListViewDirectoare.SelectedIndices.Count > 0) && (ListViewFisiere.SelectedIndices.Count > 0))
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                int IndexFisier = ListViewFisiere.SelectedIndices[0];
                Fisier fisier = this[IndexDirector][IndexFisier];
                FileInfo fileInfo = new FileInfo(fisier.GetNumeComplet());
                if (fileInfo.Exists == true)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "Selectati Directorul Destinatie!";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string sursaFisier = fisier.GetNumeComplet();
                            string destiantieFisier = folderBrowserDialog.SelectedPath + "\\" + fisier.GetNumeFisier();
                            File.Copy(fisier.GetNumeComplet(), destiantieFisier);
                            File.Delete(sursaFisier);
                            ListViewFisiere.Items[IndexFisier].Remove();
                            TreeView.Nodes[IndexDirector].Nodes[IndexFisier].Remove();
                            this[IndexDirector].GetListaFisiere().Remove(fisier);
                            DatabaseHelper.StergeInregistrare(fisier);
                        }
                        catch (IOException _ExceptionIO)
                        {
                            Program.SalvareFisierLoguri(_ExceptionIO);
                        }
                        catch (UnauthorizedAccessException _ExceptionUnauthorizedAcces)
                        {
                            Program.SalvareFisierLoguri(_ExceptionUnauthorizedAcces);
                        }
                        finally
                        {
                            ListViewFisiere.Items[IndexFisier].Remove();
                            TreeView.Nodes[IndexDirector].Nodes[IndexFisier].Remove();
                            this[IndexDirector].GetListaFisiere().Remove(fisier);
                            DatabaseHelper.StergeInregistrare(fisier);
                        }
                    }
                }
            }
        }

        private void StergeDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewDirectoare.SelectedIndices.Count > 0)
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                Director director = this[IndexDirector];
                DirectoryInfo directoryInfo = new DirectoryInfo(this[IndexDirector].GetLocatieDirector());
                if (directoryInfo.Exists == true)
                {
                    if ((MessageBox.Show("Stergeti Directorul Definitiv?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                    {
                        try
                        {
                            Directory.Delete(director.GetLocatieDirector(), true);
                        }
                        catch (DirectoryNotFoundException _ExceptionDirNotFound)
                        {
                            Program.SalvareFisierLoguri(_ExceptionDirNotFound);
                        }
                        catch (System.UnauthorizedAccessException _ExceptionUnauthorizedAccess)
                        {
                            Program.SalvareFisierLoguri(_ExceptionUnauthorizedAccess);
                        }
                        finally
                        {
                            ListViewDirectoare.Items[IndexDirector].Remove();
                            TreeView.Nodes[IndexDirector].Remove();
                            for (int IndexFisier = 0; IndexFisier < this[IndexDirector].GetListaFisiere().Count; IndexFisier++)
                            {
                                DatabaseHelper.StergeInregistrare(this[IndexDirector][IndexFisier]);
                                this.ListaDirectoare[IndexDirector].GetListaFisiere().Remove(this[IndexDirector][IndexFisier]);
                            }
                            ListaDirectoare.Remove(director);
                            SalvareDirectoareXML();
                        }
                    }
                    else
                    {
                        ListViewDirectoare.Items[IndexDirector].Remove();
                        TreeView.Nodes[IndexDirector].Remove();
                        for (int IndexFisier = 0; IndexFisier < this[IndexDirector].GetListaFisiere().Count; IndexFisier++)
                        {
                            DatabaseHelper.StergeInregistrare(this[IndexDirector][IndexFisier]);
                            this.ListaDirectoare[IndexDirector].GetListaFisiere().Remove(this[IndexDirector][IndexFisier]);
                        }
                        ListaDirectoare.Remove(director);
                        SalvareDirectoareXML();
                    }
                }
                else
                {
                    ListViewDirectoare.Items[IndexDirector].Remove();
                    TreeView.Nodes[IndexDirector].Remove();
                    for (int IndexFisier = 0; IndexFisier < this[IndexDirector].GetListaFisiere().Count; IndexFisier++)
                    {
                        DatabaseHelper.StergeInregistrare(this[IndexDirector][IndexFisier]);
                        this.ListaDirectoare[IndexDirector].GetListaFisiere().Remove(this[IndexDirector][IndexFisier]);
                    }
                    ListaDirectoare.Remove(director);
                }
            }
        }

        private void RedenumireDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewDirectoare.SelectedIndices.Count > 0)
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                Director director = this[IndexDirector];
                DirectoryInfo directoryInfo = new DirectoryInfo(director.GetLocatieDirector());
                if (directoryInfo.Exists == true)
                {
                    string NumeVechiDirector = director.GetNumeDirector();
                    string NumeCompletVechiDirector = director.GetLocatieDirector();
                    if ((MessageBox.Show("Redenumiti Directorul?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                    {
                        try
                        {
                            this.Hide();
                            string directorSursa = directoryInfo.FullName;
                            string directorParinte = director.GetLocatieDirector().Remove((director.GetLocatieDirector().Length) - (director.GetNumeDirector().Length));
                            RedenumireDirectorForm redenumireDirector = new RedenumireDirectorForm(director);
                            redenumireDirector.ShowDialog();
                            string numeDirector = director.GetNumeDirector();
                            director.SetNumeDirector(numeDirector);
                            director.SetLocatieDirector(directorParinte + numeDirector);
                            string directorDestinatie = director.GetLocatieDirector();
                            Directory.Move(directorSursa, directorDestinatie);
                            for (int IndexFisier = 0; IndexFisier < director.GetListaFisiere().Count; IndexFisier++)
                            {
                                string NumeNouFisier = director.GetLocatieDirector() + "\\" + director[IndexFisier].GetNumeFisier();
                                director[IndexFisier].SetNumeComplet(NumeNouFisier);
                            }
                            ListViewDirectoare.Items[IndexDirector].Text = director.GetNumeDirector();
                            TreeView.Nodes[IndexDirector].Text = director.GetNumeDirector();
                        }
                        catch (ArgumentException _ExceptionArgument)
                        {
                            Program.SalvareFisierLoguri(_ExceptionArgument);
                        }
                        catch (IOException _ExceptionIO)
                        {

                            Program.SalvareFisierLoguri(_ExceptionIO);
                        }
                    }
                }
                this.Show();
            }
        }

        private void CopiereDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewDirectoare.SelectedIndices.Count > 0)
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                Director director = this[IndexDirector];
                DirectoryInfo directoryInfo = new DirectoryInfo(director.GetLocatieDirector());
                if (directoryInfo.Exists == true)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "Selectati Directorul Destinatie!";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        CopiereDirector(director.GetLocatieDirector(), folderBrowserDialog.SelectedPath, true);
                    }
                }
            }
        }

        private void MutareDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewDirectoare.SelectedIndices.Count > 0)
            {
                int IndexDirector = ListViewDirectoare.SelectedIndices[0];
                Director director = this[IndexDirector];
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selectati Directorul Destinatie";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    MutareDirector(director.GetLocatieDirector(), folderBrowserDialog.SelectedPath, true);
                    ListViewDirectoare.Items[IndexDirector].Remove();
                    TreeView.Nodes[IndexDirector].Remove();
                    for (int IndexFisier = 0; IndexFisier < this[IndexDirector].GetListaFisiere().Count; IndexFisier++)
                    {
                        DatabaseHelper.StergeInregistrare(this[IndexDirector][IndexFisier]);
                        this[IndexDirector].GetListaFisiere().Remove(this[IndexDirector][IndexFisier]);
                    }
                    ListaDirectoare.Remove(director);
                }
            }
        }

        private void CopiereDirector(string _DirectorSursa, string _DirectorDestinatie, bool _CopiazaSubdirectoare)
        {
            DirectoryInfo sursa = new DirectoryInfo(_DirectorSursa);
            if (sursa.Exists == true)
            {
                try
                {
                    DirectoryInfo[] dirs = sursa.GetDirectories();
                    if (!Directory.Exists(_DirectorDestinatie))
                    {
                        Directory.CreateDirectory(_DirectorDestinatie);
                    }
                    FileInfo[] files = sursa.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        string temppath = Path.Combine(_DirectorDestinatie, file.Name);
                        file.CopyTo(temppath, false);
                    }
                    if (_CopiazaSubdirectoare)
                    {
                        foreach (DirectoryInfo subdir in dirs)
                        {
                            string temppath = Path.Combine(_DirectorDestinatie, subdir.Name);
                            CopiereDirector(subdir.FullName, temppath, _CopiazaSubdirectoare);
                        }
                    }
                }
                catch (IOException _ExceptionIO)
                {
                    Program.SalvareFisierLoguri(_ExceptionIO);
                }
                catch (UnauthorizedAccessException _ExceptionUnauthrorizedAcces)
                {
                    Program.SalvareFisierLoguri(_ExceptionUnauthrorizedAcces);
                }
            }
        }

        private void MutareDirector(string _DirectorSursa, string _DirectorDestinatie, bool _CopiazaSubdirectoare)
        {
            DirectoryInfo sursa = new DirectoryInfo(_DirectorSursa);
            if (sursa.Exists == true)
            {
                try
                {
                    DirectoryInfo[] dirs = sursa.GetDirectories();
                    if (!Directory.Exists(_DirectorDestinatie))
                    {
                        Directory.CreateDirectory(_DirectorDestinatie);
                    }
                    FileInfo[] files = sursa.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        string temppath = Path.Combine(_DirectorDestinatie, file.Name);
                        file.MoveTo(temppath);
                    }
                    if (_CopiazaSubdirectoare)
                    {
                        foreach (DirectoryInfo subdir in dirs)
                        {
                            string temppath = Path.Combine(_DirectorDestinatie, subdir.Name);
                            MutareDirector(subdir.FullName, temppath, _CopiazaSubdirectoare);
                        }
                    }
                    if (!(sursa.FullName == _DirectorDestinatie))
                    {
                        sursa.Delete(true);
                    }
                }
                catch (IOException _ExceptionIO)
                {
                    Program.SalvareFisierLoguri(_ExceptionIO);
                }
                catch (UnauthorizedAccessException _ExceptionUnauthorizedAcces)
                {
                    Program.SalvareFisierLoguri(_ExceptionUnauthorizedAcces);
                }
            }
        }

        private void SalvareDirectoareXML()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter("Directoare.XML", System.Text.Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteComment("Lista Directoare:");
            xmlTextWriter.WriteStartElement("Directoare");
            for (int IndexDirector = 0; IndexDirector < ListaDirectoare.Count; IndexDirector++)
            {
                ListaDirectoare[IndexDirector].SalvareXML(xmlTextWriter);
            }
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
        }

        private void CitireDirectoareXML()
        {
            try
            {
                StergeControale();
                this.ListaDirectoare.Clear();
                XmlTextReader xmlTextReader = new XmlTextReader("Directoare.XML");
                while (xmlTextReader.Read())
                {
                    try
                    {
                        Director director = new Director();
                        string locatieDirector = director.CitesteXML(xmlTextReader);
                        if (locatieDirector != null)
                        {
                            director.SetLocatieDirector(locatieDirector);
                            DirectoryInfo directoryInfo = new DirectoryInfo(locatieDirector);
                            director.SetNumeDirector(directoryInfo.Name);
                            List<Fisier> listaFisiere = CreareListaFisiere(director);
                            director.SetListaFisiere(listaFisiere);
                            this.ListaDirectoare.Add(director);
                            PopuleazaListViewDirectoare(director);
                            PopuleazaTreeView(director);
                        }
                    }
                    catch (DirectoryNotFoundException _ExceptionDirectoryNotFound)
                    {
                        Program.SalvareFisierLoguri(_ExceptionDirectoryNotFound);
                    }
                }
                xmlTextReader.Close();
            }
            catch (FileNotFoundException _ExceptionFileNotFound)
            {
                Program.SalvareFisierLoguri(_ExceptionFileNotFound);
            }
        }

        private Director this[int _Index]
        {
            get
            {
                return this.ListaDirectoare[_Index];
            }
            set
            {
                this.ListaDirectoare[_Index] = value;
            }
        }

        private void StergeControale()
        {
            ListViewDirectoare.Items.Clear();
            ListViewFisiere.Items.Clear();
            TreeView.Nodes.Clear();
        }

        private void DetaliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewDirectoare.SelectedIndices.Count > 0)
            {
                int IndexDirectorSelectat = ListViewDirectoare.SelectedIndices[0];
                Form DetaliiFisier = new VizualizareRatingForm(this[IndexDirectorSelectat]);
                this.Hide();
                DetaliiFisier.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu Ati Selectat Un Director", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cauta = new CautareForm(this.ListaDirectoare);
            this.Hide();
            Cauta.ShowDialog();
            this.Show();
        }

        private void SchimbaAtributeleFisierelor(string path)
        {
            try
            {
                FileAttributes fileAttributes = File.GetAttributes(path);
                File.SetAttributes(path, FileAttributes.Normal);
            }
            catch (Exception _Exception)
            {
                Program.SalvareFisierLoguri(_Exception);
            }
        }
    }
}