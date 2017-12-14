namespace Proiect_PAW
{
    partial class AdaugaRatingForm
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
            this.AdaugaRatingTextBoxGen = new System.Windows.Forms.TextBox();
            this.AdaugaRatingTextBoxRecenzie = new System.Windows.Forms.TextBox();
            this.AdaugaRatingLabelGen = new System.Windows.Forms.Label();
            this.AdaugaRatingLabelRecenzie = new System.Windows.Forms.Label();
            this.AdaugaRatingLabelVizualizat = new System.Windows.Forms.Label();
            this.AdaugaRatingButton = new System.Windows.Forms.Button();
            this.AdaugaRatingComboBox = new System.Windows.Forms.ComboBox();
            this.AdaugaRatingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AdaugaRatingErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugaRatingTextBoxGen
            // 
            this.AdaugaRatingTextBoxGen.Location = new System.Drawing.Point(70, 6);
            this.AdaugaRatingTextBoxGen.Name = "AdaugaRatingTextBoxGen";
            this.AdaugaRatingTextBoxGen.Size = new System.Drawing.Size(202, 20);
            this.AdaugaRatingTextBoxGen.TabIndex = 0;
            // 
            // AdaugaRatingTextBoxRecenzie
            // 
            this.AdaugaRatingTextBoxRecenzie.Location = new System.Drawing.Point(70, 36);
            this.AdaugaRatingTextBoxRecenzie.Name = "AdaugaRatingTextBoxRecenzie";
            this.AdaugaRatingTextBoxRecenzie.Size = new System.Drawing.Size(202, 20);
            this.AdaugaRatingTextBoxRecenzie.TabIndex = 1;
            // 
            // AdaugaRatingLabelGen
            // 
            this.AdaugaRatingLabelGen.AutoSize = true;
            this.AdaugaRatingLabelGen.Location = new System.Drawing.Point(12, 9);
            this.AdaugaRatingLabelGen.Name = "AdaugaRatingLabelGen";
            this.AdaugaRatingLabelGen.Size = new System.Drawing.Size(27, 13);
            this.AdaugaRatingLabelGen.TabIndex = 3;
            this.AdaugaRatingLabelGen.Text = "Gen";
            // 
            // AdaugaRatingLabelRecenzie
            // 
            this.AdaugaRatingLabelRecenzie.AutoSize = true;
            this.AdaugaRatingLabelRecenzie.Location = new System.Drawing.Point(12, 39);
            this.AdaugaRatingLabelRecenzie.Name = "AdaugaRatingLabelRecenzie";
            this.AdaugaRatingLabelRecenzie.Size = new System.Drawing.Size(52, 13);
            this.AdaugaRatingLabelRecenzie.TabIndex = 4;
            this.AdaugaRatingLabelRecenzie.Text = "Recenzie";
            // 
            // AdaugaRatingLabelVizualizat
            // 
            this.AdaugaRatingLabelVizualizat.AutoSize = true;
            this.AdaugaRatingLabelVizualizat.Location = new System.Drawing.Point(12, 67);
            this.AdaugaRatingLabelVizualizat.Name = "AdaugaRatingLabelVizualizat";
            this.AdaugaRatingLabelVizualizat.Size = new System.Drawing.Size(51, 13);
            this.AdaugaRatingLabelVizualizat.TabIndex = 5;
            this.AdaugaRatingLabelVizualizat.Text = "Vizualizat";
            // 
            // AdaugaRatingButton
            // 
            this.AdaugaRatingButton.Location = new System.Drawing.Point(99, 111);
            this.AdaugaRatingButton.Name = "AdaugaRatingButton";
            this.AdaugaRatingButton.Size = new System.Drawing.Size(75, 23);
            this.AdaugaRatingButton.TabIndex = 6;
            this.AdaugaRatingButton.Text = "Adauga";
            this.AdaugaRatingButton.UseVisualStyleBackColor = true;
            this.AdaugaRatingButton.Click += new System.EventHandler(this.AdaugaRecenzieButton_click);
            // 
            // AdaugaRatingComboBox
            // 
            this.AdaugaRatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdaugaRatingComboBox.FormattingEnabled = true;
            this.AdaugaRatingComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.AdaugaRatingComboBox.Location = new System.Drawing.Point(70, 67);
            this.AdaugaRatingComboBox.Name = "AdaugaRatingComboBox";
            this.AdaugaRatingComboBox.Size = new System.Drawing.Size(202, 21);
            this.AdaugaRatingComboBox.TabIndex = 7;
            // 
            // AdaugaRatingErrorProvider
            // 
            this.AdaugaRatingErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AdaugaRatingErrorProvider.ContainerControl = this;
            // 
            // AdaugaRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 144);
            this.ControlBox = false;
            this.Controls.Add(this.AdaugaRatingComboBox);
            this.Controls.Add(this.AdaugaRatingButton);
            this.Controls.Add(this.AdaugaRatingLabelVizualizat);
            this.Controls.Add(this.AdaugaRatingLabelRecenzie);
            this.Controls.Add(this.AdaugaRatingLabelGen);
            this.Controls.Add(this.AdaugaRatingTextBoxRecenzie);
            this.Controls.Add(this.AdaugaRatingTextBoxGen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 183);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 183);
            this.Name = "AdaugaRatingForm";
            this.Text = "AdaugaRatingForm";
            this.Load += new System.EventHandler(this.AdaugaRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdaugaRatingErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdaugaRatingTextBoxGen;
        private System.Windows.Forms.TextBox AdaugaRatingTextBoxRecenzie;
        private System.Windows.Forms.Label AdaugaRatingLabelGen;
        private System.Windows.Forms.Label AdaugaRatingLabelRecenzie;
        private System.Windows.Forms.Label AdaugaRatingLabelVizualizat;
        private System.Windows.Forms.Button AdaugaRatingButton;
        private System.Windows.Forms.ComboBox AdaugaRatingComboBox;
        private System.Windows.Forms.ErrorProvider AdaugaRatingErrorProvider;
    }
}