using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class CautareForm : Form
    {
        private List<Director> ListaDirectorare;
        public CautareForm(List<Director> _ListaDirectoare)
        {
            InitializeComponent();
            this.ListaDirectorare = _ListaDirectoare;
        }

        private void CautareForm_Load(object sender, EventArgs e)
        {
            this.CautareComboBox.SelectedIndex = 1;
        }

        private void CautaButton_Click(object sender, EventArgs e)
        {
            string NumeFisier = CautareTextBox.Text.ToLower();
            bool Vizualizat;
            string aux = CautareComboBox.Text;
            if (aux.ToLower() == "true")
            {
                Vizualizat = true;
            }
            else
            {
                Vizualizat = false;
            }
            CautareListView.Items.Clear();
            for (int IndexDirector = 0; IndexDirector < ListaDirectorare.Count; IndexDirector++)
            {
                for (int IndexFisier = 0; IndexFisier < ListaDirectorare[IndexDirector].GetListaFisiere().Count; IndexFisier++)
                {
                    if (ListaDirectorare[IndexDirector][IndexFisier].GetNumeFisier().ToLower().Contains(NumeFisier) & ListaDirectorare[IndexDirector][IndexFisier].GetVizualizat() == Vizualizat)
                    {
                        ListViewItem listViewItem = new ListViewItem(ListaDirectorare[IndexDirector][IndexFisier].GetNumeFisier());
                        listViewItem.SubItems.Add(ListaDirectorare[IndexDirector][IndexFisier].GetGen());
                        listViewItem.SubItems.Add(ListaDirectorare[IndexDirector][IndexFisier].GetRecenzie());
                        listViewItem.SubItems.Add(ListaDirectorare[IndexDirector][IndexFisier].GetVizualizat().ToString());
                        CautareListView.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void PrinteazaPagina(Object sender, PrintPageEventArgs e)
        {
            string a = CautareListView.Items[0].Text + "\n";
            for (int Index = 1; Index < CautareListView.Items.Count; Index++)
            {
                a = string.Concat(a, CautareListView.Items[Index].SubItems[0].Text + "\n");
                Font font = new Font("Verdana", 10, FontStyle.Regular);
                PointF pointF = new PointF(10, 10);
                e.Graphics.DrawString(a, font, Brushes.Black, pointF);
            }
        }

        private void PrinteazaRaportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CautaPrintPreviewDialog.Document = CautaPrintDocument;
            CautaPrintDocument.PrintPage += new PrintPageEventHandler(PrinteazaPagina);
            this.Hide();
            CautaPrintPreviewDialog.ShowDialog();
            this.Show();
        }
    }
}
