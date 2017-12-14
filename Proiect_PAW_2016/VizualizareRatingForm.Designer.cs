namespace Proiect_PAW
{
    partial class VizualizareRatingForm
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
            this.ListViewRating = new System.Windows.Forms.ListView();
            this.NumeFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recenzie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vizualizat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewRating
            // 
            this.ListViewRating.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeFisier,
            this.Gen,
            this.Recenzie,
            this.Vizualizat});
            this.ListViewRating.FullRowSelect = true;
            this.ListViewRating.GridLines = true;
            this.ListViewRating.Location = new System.Drawing.Point(12, 31);
            this.ListViewRating.MultiSelect = false;
            this.ListViewRating.Name = "ListViewRating";
            this.ListViewRating.Size = new System.Drawing.Size(829, 218);
            this.ListViewRating.TabIndex = 0;
            this.ListViewRating.UseCompatibleStateImageBehavior = false;
            this.ListViewRating.View = System.Windows.Forms.View.Details;
            this.ListViewRating.DoubleClick += new System.EventHandler(this.ListViewRating_DoubleClick);
            // 
            // NumeFisier
            // 
            this.NumeFisier.Text = "Nume Fisier";
            this.NumeFisier.Width = 75;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            this.Gen.Width = 73;
            // 
            // Recenzie
            // 
            this.Recenzie.Text = "Recenzie";
            this.Recenzie.Width = 613;
            // 
            // Vizualizat
            // 
            this.Vizualizat.Text = "Vizualizat";
            this.Vizualizat.Width = 57;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Enabled = false;
            this.RatingTextBox.Location = new System.Drawing.Point(13, 5);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(828, 20);
            this.RatingTextBox.TabIndex = 1;
            this.RatingTextBox.Text = "Detalii Fisier";
            this.RatingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RatingButton
            // 
            this.RatingButton.Location = new System.Drawing.Point(13, 255);
            this.RatingButton.Name = "RatingButton";
            this.RatingButton.Size = new System.Drawing.Size(74, 23);
            this.RatingButton.TabIndex = 2;
            this.RatingButton.Text = "OK";
            this.RatingButton.UseVisualStyleBackColor = true;
            this.RatingButton.Click += new System.EventHandler(this.RatingButton_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 282);
            this.ControlBox = false;
            this.Controls.Add(this.RatingButton);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.ListViewRating);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(869, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(869, 321);
            this.Name = "RatingForm";
            this.Text = "RatingForm";
            this.Load += new System.EventHandler(this.RatingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewRating;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.ColumnHeader NumeFisier;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Recenzie;
        private System.Windows.Forms.ColumnHeader Vizualizat;
        private System.Windows.Forms.Button RatingButton;
    }
}