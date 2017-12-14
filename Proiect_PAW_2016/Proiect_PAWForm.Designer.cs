namespace Proiect_PAW
{
    partial class Proiect_PAWForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MeniulAplicatiei = new System.Windows.Forms.MenuStrip();
            this.directorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citesteDinXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.ListViewDirectoare = new System.Windows.Forms.ListView();
            this.NumeDirector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Locatia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeniuContextualDirectoare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redenumireDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiereDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutareDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRecenzieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewFisiere = new System.Windows.Forms.ListView();
            this.NumeFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dimensiune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeniuContextualFisiere = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redenumireFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiereFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutareFisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cautareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeniulAplicatiei.SuspendLayout();
            this.MeniuContextualDirectoare.SuspendLayout();
            this.MeniuContextualFisiere.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeniulAplicatiei
            // 
            this.MeniulAplicatiei.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directorToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MeniulAplicatiei.Location = new System.Drawing.Point(0, 0);
            this.MeniulAplicatiei.Name = "MeniulAplicatiei";
            this.MeniulAplicatiei.Size = new System.Drawing.Size(1203, 24);
            this.MeniulAplicatiei.TabIndex = 0;
            this.MeniulAplicatiei.Text = "menuStrip1";
            // 
            // directorToolStripMenuItem
            // 
            this.directorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaDirectorToolStripMenuItem});
            this.directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            this.directorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.directorToolStripMenuItem.Text = "Director";
            // 
            // adaugaDirectorToolStripMenuItem
            // 
            this.adaugaDirectorToolStripMenuItem.Name = "adaugaDirectorToolStripMenuItem";
            this.adaugaDirectorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.adaugaDirectorToolStripMenuItem.Text = "Adauga Director";
            this.adaugaDirectorToolStripMenuItem.Click += new System.EventHandler(this.AdaugaDirectorToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInXMLToolStripMenuItem,
            this.citesteDinXMLToolStripMenuItem});
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xmlToolStripMenuItem.Text = "XML";
            // 
            // salveazaInXMLToolStripMenuItem
            // 
            this.salveazaInXMLToolStripMenuItem.Name = "salveazaInXMLToolStripMenuItem";
            this.salveazaInXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salveazaInXMLToolStripMenuItem.Text = "Salveaza In XML";
            this.salveazaInXMLToolStripMenuItem.Click += new System.EventHandler(this.SalveazaInXMLToolStripMenuItem_Click);
            // 
            // citesteDinXMLToolStripMenuItem
            // 
            this.citesteDinXMLToolStripMenuItem.Name = "citesteDinXMLToolStripMenuItem";
            this.citesteDinXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.citesteDinXMLToolStripMenuItem.Text = "Citeste Din XML";
            this.citesteDinXMLToolStripMenuItem.Click += new System.EventHandler(this.CitesteDinXMLToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TreeView
            // 
            this.TreeView.Location = new System.Drawing.Point(13, 27);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(340, 522);
            this.TreeView.TabIndex = 3;
            // 
            // ListViewDirectoare
            // 
            this.ListViewDirectoare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeDirector,
            this.Locatia});
            this.ListViewDirectoare.ContextMenuStrip = this.MeniuContextualDirectoare;
            this.ListViewDirectoare.FullRowSelect = true;
            this.ListViewDirectoare.GridLines = true;
            this.ListViewDirectoare.HideSelection = false;
            this.ListViewDirectoare.Location = new System.Drawing.Point(360, 55);
            this.ListViewDirectoare.MultiSelect = false;
            this.ListViewDirectoare.Name = "ListViewDirectoare";
            this.ListViewDirectoare.Size = new System.Drawing.Size(412, 494);
            this.ListViewDirectoare.TabIndex = 4;
            this.ListViewDirectoare.UseCompatibleStateImageBehavior = false;
            this.ListViewDirectoare.View = System.Windows.Forms.View.Details;
            this.ListViewDirectoare.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // NumeDirector
            // 
            this.NumeDirector.Text = "Nume Director";
            this.NumeDirector.Width = 195;
            // 
            // Locatia
            // 
            this.Locatia.Text = "Locatia";
            this.Locatia.Width = 213;
            // 
            // MeniuContextualDirectoare
            // 
            this.MeniuContextualDirectoare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeDirectorToolStripMenuItem,
            this.redenumireDirectorToolStripMenuItem,
            this.copiereDirectorToolStripMenuItem,
            this.mutareDirectorToolStripMenuItem,
            this.adaugaRecenzieToolStripMenuItem,
            this.cautareToolStripMenuItem});
            this.MeniuContextualDirectoare.Name = "MeniuContextualDirectoare";
            this.MeniuContextualDirectoare.Size = new System.Drawing.Size(184, 158);
            // 
            // stergeDirectorToolStripMenuItem
            // 
            this.stergeDirectorToolStripMenuItem.Name = "stergeDirectorToolStripMenuItem";
            this.stergeDirectorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.stergeDirectorToolStripMenuItem.Text = "Sterge Director";
            this.stergeDirectorToolStripMenuItem.Click += new System.EventHandler(this.StergeDirectorToolStripMenuItem_Click);
            // 
            // redenumireDirectorToolStripMenuItem
            // 
            this.redenumireDirectorToolStripMenuItem.Name = "redenumireDirectorToolStripMenuItem";
            this.redenumireDirectorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.redenumireDirectorToolStripMenuItem.Text = "Redenumire Director";
            this.redenumireDirectorToolStripMenuItem.Click += new System.EventHandler(this.RedenumireDirectorToolStripMenuItem_Click);
            // 
            // copiereDirectorToolStripMenuItem
            // 
            this.copiereDirectorToolStripMenuItem.Name = "copiereDirectorToolStripMenuItem";
            this.copiereDirectorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.copiereDirectorToolStripMenuItem.Text = "Copiere Director";
            this.copiereDirectorToolStripMenuItem.Click += new System.EventHandler(this.CopiereDirectorToolStripMenuItem_Click);
            // 
            // mutareDirectorToolStripMenuItem
            // 
            this.mutareDirectorToolStripMenuItem.Name = "mutareDirectorToolStripMenuItem";
            this.mutareDirectorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mutareDirectorToolStripMenuItem.Text = "Mutare Director";
            this.mutareDirectorToolStripMenuItem.Click += new System.EventHandler(this.MutareDirectorToolStripMenuItem_Click);
            // 
            // adaugaRecenzieToolStripMenuItem
            // 
            this.adaugaRecenzieToolStripMenuItem.Name = "adaugaRecenzieToolStripMenuItem";
            this.adaugaRecenzieToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.adaugaRecenzieToolStripMenuItem.Text = "Adauga Recenzie";
            this.adaugaRecenzieToolStripMenuItem.Click += new System.EventHandler(this.DetaliiToolStripMenuItem_Click);
            // 
            // ListViewFisiere
            // 
            this.ListViewFisiere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeFisier,
            this.Dimensiune});
            this.ListViewFisiere.ContextMenuStrip = this.MeniuContextualFisiere;
            this.ListViewFisiere.FullRowSelect = true;
            this.ListViewFisiere.GridLines = true;
            this.ListViewFisiere.HideSelection = false;
            this.ListViewFisiere.Location = new System.Drawing.Point(779, 55);
            this.ListViewFisiere.MultiSelect = false;
            this.ListViewFisiere.Name = "ListViewFisiere";
            this.ListViewFisiere.Size = new System.Drawing.Size(412, 494);
            this.ListViewFisiere.TabIndex = 6;
            this.ListViewFisiere.UseCompatibleStateImageBehavior = false;
            this.ListViewFisiere.View = System.Windows.Forms.View.Details;
            // 
            // NumeFisier
            // 
            this.NumeFisier.Text = "Nume Fisier";
            this.NumeFisier.Width = 313;
            // 
            // Dimensiune
            // 
            this.Dimensiune.Text = "Dimensiune (KB)";
            this.Dimensiune.Width = 92;
            // 
            // MeniuContextualFisiere
            // 
            this.MeniuContextualFisiere.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeFisierToolStripMenuItem,
            this.redenumireFisierToolStripMenuItem,
            this.copiereFisierToolStripMenuItem,
            this.mutareFisiereToolStripMenuItem});
            this.MeniuContextualFisiere.Name = "MeniuContextual";
            this.MeniuContextualFisiere.Size = new System.Drawing.Size(169, 92);
            // 
            // stergeFisierToolStripMenuItem
            // 
            this.stergeFisierToolStripMenuItem.Name = "stergeFisierToolStripMenuItem";
            this.stergeFisierToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stergeFisierToolStripMenuItem.Text = "Sterge Fisier";
            this.stergeFisierToolStripMenuItem.Click += new System.EventHandler(this.StergeFisierToolStripMenuItem_Click);
            // 
            // redenumireFisierToolStripMenuItem
            // 
            this.redenumireFisierToolStripMenuItem.Name = "redenumireFisierToolStripMenuItem";
            this.redenumireFisierToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.redenumireFisierToolStripMenuItem.Text = "Redenumire Fisier";
            this.redenumireFisierToolStripMenuItem.Click += new System.EventHandler(this.RedenumireFisierToolStripMenuItem_Click);
            // 
            // copiereFisierToolStripMenuItem
            // 
            this.copiereFisierToolStripMenuItem.Name = "copiereFisierToolStripMenuItem";
            this.copiereFisierToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.copiereFisierToolStripMenuItem.Text = "Copiere Fisier";
            this.copiereFisierToolStripMenuItem.Click += new System.EventHandler(this.CopiereFisierToolStripMenuItem_Click);
            // 
            // mutareFisiereToolStripMenuItem
            // 
            this.mutareFisiereToolStripMenuItem.Name = "mutareFisiereToolStripMenuItem";
            this.mutareFisiereToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mutareFisiereToolStripMenuItem.Text = "Mutare Fisier";
            this.mutareFisiereToolStripMenuItem.Click += new System.EventHandler(this.MutareFisiereToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(778, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(412, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Fisiere:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(360, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Directoare:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cautareToolStripMenuItem
            // 
            this.cautareToolStripMenuItem.Name = "cautareToolStripMenuItem";
            this.cautareToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cautareToolStripMenuItem.Text = "Cautare";
            this.cautareToolStripMenuItem.Click += new System.EventHandler(this.CautareToolStripMenuItem_Click);
            // 
            // Proiect_PAWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 561);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ListViewFisiere);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListViewDirectoare);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.MeniulAplicatiei);
            this.MainMenuStrip = this.MeniulAplicatiei;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Proiect_PAWForm";
            this.ShowIcon = false;
            this.Text = "Proiect_PAW";
            this.Load += new System.EventHandler(this.Proiect_PAW_Load);
            this.MeniulAplicatiei.ResumeLayout(false);
            this.MeniulAplicatiei.PerformLayout();
            this.MeniuContextualDirectoare.ResumeLayout(false);
            this.MeniuContextualFisiere.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MeniulAplicatiei;
        private System.Windows.Forms.ToolStripMenuItem directorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaInXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citesteDinXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.ListView ListViewDirectoare;
        private System.Windows.Forms.ColumnHeader NumeDirector;
        private System.Windows.Forms.ColumnHeader Locatia;
        private System.Windows.Forms.ListView ListViewFisiere;
        private System.Windows.Forms.ColumnHeader NumeFisier;
        private System.Windows.Forms.ColumnHeader Dimensiune;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip MeniuContextualFisiere;
        private System.Windows.Forms.ToolStripMenuItem stergeFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redenumireFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiereFisierToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MeniuContextualDirectoare;
        private System.Windows.Forms.ToolStripMenuItem stergeDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redenumireDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiereDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutareDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutareFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRecenzieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareToolStripMenuItem;
    }
}