namespace Proiect_PAW
{
    partial class CautareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautareForm));
            this.CautareTextBox = new System.Windows.Forms.TextBox();
            this.CautareListView = new System.Windows.Forms.ListView();
            this.NumeFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recenzie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vizualizat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CautaContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printeazaRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CautaButton = new System.Windows.Forms.Button();
            this.CautareComboBox = new System.Windows.Forms.ComboBox();
            this.CautaPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.CautaPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.CautareLabelNume = new System.Windows.Forms.Label();
            this.CautareLableVizualizat = new System.Windows.Forms.Label();
            this.CautaContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CautareTextBox
            // 
            this.CautareTextBox.Location = new System.Drawing.Point(56, 11);
            this.CautareTextBox.Name = "CautareTextBox";
            this.CautareTextBox.Size = new System.Drawing.Size(477, 20);
            this.CautareTextBox.TabIndex = 0;
            // 
            // CautareListView
            // 
            this.CautareListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeFisier,
            this.Gen,
            this.Recenzie,
            this.Vizualizat});
            this.CautareListView.ContextMenuStrip = this.CautaContextMenu;
            this.CautareListView.GridLines = true;
            this.CautareListView.Location = new System.Drawing.Point(13, 40);
            this.CautareListView.MultiSelect = false;
            this.CautareListView.Name = "CautareListView";
            this.CautareListView.Size = new System.Drawing.Size(778, 266);
            this.CautareListView.TabIndex = 1;
            this.CautareListView.UseCompatibleStateImageBehavior = false;
            this.CautareListView.View = System.Windows.Forms.View.Details;
            // 
            // NumeFisier
            // 
            this.NumeFisier.Text = "NumeFisier";
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            // 
            // Recenzie
            // 
            this.Recenzie.Text = "Recenzie";
            // 
            // Vizualizat
            // 
            this.Vizualizat.Text = "Vizualizat";
            // 
            // CautaContextMenu
            // 
            this.CautaContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printeazaRaportToolStripMenuItem});
            this.CautaContextMenu.Name = "contextMenuStrip1";
            this.CautaContextMenu.Size = new System.Drawing.Size(161, 26);
            // 
            // printeazaRaportToolStripMenuItem
            // 
            this.printeazaRaportToolStripMenuItem.Name = "printeazaRaportToolStripMenuItem";
            this.printeazaRaportToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.printeazaRaportToolStripMenuItem.Text = "Printeaza Raport";
            this.printeazaRaportToolStripMenuItem.Click += new System.EventHandler(this.PrinteazaRaportToolStripMenuItem_Click);
            // 
            // CautaButton
            // 
            this.CautaButton.Location = new System.Drawing.Point(689, 10);
            this.CautaButton.Name = "CautaButton";
            this.CautaButton.Size = new System.Drawing.Size(102, 23);
            this.CautaButton.TabIndex = 2;
            this.CautaButton.Text = "Cauta";
            this.CautaButton.UseVisualStyleBackColor = true;
            this.CautaButton.Click += new System.EventHandler(this.CautaButton_Click);
            // 
            // CautareComboBox
            // 
            this.CautareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CautareComboBox.FormattingEnabled = true;
            this.CautareComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.CautareComboBox.Location = new System.Drawing.Point(599, 11);
            this.CautareComboBox.Name = "CautareComboBox";
            this.CautareComboBox.Size = new System.Drawing.Size(84, 21);
            this.CautareComboBox.TabIndex = 3;
            // 
            // CautaPrintPreviewDialog
            // 
            this.CautaPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.CautaPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.CautaPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.CautaPrintPreviewDialog.Enabled = true;
            this.CautaPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("CautaPrintPreviewDialog.Icon")));
            this.CautaPrintPreviewDialog.Name = "CautaPrintPreviewDialog";
            this.CautaPrintPreviewDialog.Visible = false;
            // 
            // CautareLabelNume
            // 
            this.CautareLabelNume.AutoSize = true;
            this.CautareLabelNume.Location = new System.Drawing.Point(12, 14);
            this.CautareLabelNume.Name = "CautareLabelNume";
            this.CautareLabelNume.Size = new System.Drawing.Size(38, 13);
            this.CautareLabelNume.TabIndex = 4;
            this.CautareLabelNume.Text = "Nume:";
            // 
            // CautareLableVizualizat
            // 
            this.CautareLableVizualizat.AutoSize = true;
            this.CautareLableVizualizat.Location = new System.Drawing.Point(539, 14);
            this.CautareLableVizualizat.Name = "CautareLableVizualizat";
            this.CautareLableVizualizat.Size = new System.Drawing.Size(54, 13);
            this.CautareLableVizualizat.TabIndex = 5;
            this.CautareLableVizualizat.Text = "Vizualizat:";
            // 
            // CautareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 318);
            this.Controls.Add(this.CautareLableVizualizat);
            this.Controls.Add(this.CautareLabelNume);
            this.Controls.Add(this.CautareComboBox);
            this.Controls.Add(this.CautaButton);
            this.Controls.Add(this.CautareListView);
            this.Controls.Add(this.CautareTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(819, 357);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(819, 357);
            this.Name = "CautareForm";
            this.Text = "CautareForm";
            this.Load += new System.EventHandler(this.CautareForm_Load);
            this.CautaContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CautareTextBox;
        private System.Windows.Forms.ListView CautareListView;
        private System.Windows.Forms.ColumnHeader NumeFisier;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Recenzie;
        private System.Windows.Forms.ColumnHeader Vizualizat;
        private System.Windows.Forms.Button CautaButton;
        private System.Windows.Forms.ComboBox CautareComboBox;
        private System.Windows.Forms.ContextMenuStrip CautaContextMenu;
        private System.Windows.Forms.ToolStripMenuItem printeazaRaportToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog CautaPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument CautaPrintDocument;
        private System.Windows.Forms.Label CautareLabelNume;
        private System.Windows.Forms.Label CautareLableVizualizat;
    }
}