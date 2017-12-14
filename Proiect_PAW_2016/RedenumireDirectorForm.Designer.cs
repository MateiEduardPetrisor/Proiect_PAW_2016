namespace Proiect_PAW
{
    partial class RedenumireDirectorForm
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
            this.RedenumireDirectorTextBox = new System.Windows.Forms.TextBox();
            this.RedenumireDirectorLabel = new System.Windows.Forms.Label();
            this.RedenumireDirectorOK = new System.Windows.Forms.Button();
            this.RedenumireDirectorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RedenumireDirectorCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedenumireDirectorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RedenumireDirectorTextBox
            // 
            this.RedenumireDirectorTextBox.Location = new System.Drawing.Point(68, 12);
            this.RedenumireDirectorTextBox.Name = "RedenumireDirectorTextBox";
            this.RedenumireDirectorTextBox.Size = new System.Drawing.Size(204, 20);
            this.RedenumireDirectorTextBox.TabIndex = 0;
            // 
            // RedenumireDirectorLabel
            // 
            this.RedenumireDirectorLabel.AutoSize = true;
            this.RedenumireDirectorLabel.Location = new System.Drawing.Point(12, 15);
            this.RedenumireDirectorLabel.Name = "RedenumireDirectorLabel";
            this.RedenumireDirectorLabel.Size = new System.Drawing.Size(38, 13);
            this.RedenumireDirectorLabel.TabIndex = 1;
            this.RedenumireDirectorLabel.Text = "Nume:";
            // 
            // RedenumireDirectorOK
            // 
            this.RedenumireDirectorOK.Location = new System.Drawing.Point(66, 46);
            this.RedenumireDirectorOK.Name = "RedenumireDirectorOK";
            this.RedenumireDirectorOK.Size = new System.Drawing.Size(75, 23);
            this.RedenumireDirectorOK.TabIndex = 2;
            this.RedenumireDirectorOK.Text = "OK";
            this.RedenumireDirectorOK.UseVisualStyleBackColor = true;
            this.RedenumireDirectorOK.Click += new System.EventHandler(this.RedenumireDirectorOK_Click);
            // 
            // RedenumireDirectorErrorProvider
            // 
            this.RedenumireDirectorErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.RedenumireDirectorErrorProvider.ContainerControl = this;
            // 
            // RedenumireDirectorCancel
            // 
            this.RedenumireDirectorCancel.Location = new System.Drawing.Point(147, 46);
            this.RedenumireDirectorCancel.Name = "RedenumireDirectorCancel";
            this.RedenumireDirectorCancel.Size = new System.Drawing.Size(75, 23);
            this.RedenumireDirectorCancel.TabIndex = 3;
            this.RedenumireDirectorCancel.Text = "Cancel";
            this.RedenumireDirectorCancel.UseVisualStyleBackColor = true;
            this.RedenumireDirectorCancel.Click += new System.EventHandler(this.RedenumireDirectorCancel_Click);
            // 
            // RedenumireDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 81);
            this.ControlBox = false;
            this.Controls.Add(this.RedenumireDirectorCancel);
            this.Controls.Add(this.RedenumireDirectorOK);
            this.Controls.Add(this.RedenumireDirectorLabel);
            this.Controls.Add(this.RedenumireDirectorTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 120);
            this.Name = "RedenumireDirectorForm";
            this.Text = "RedenumireDirector";
            this.Load += new System.EventHandler(this.RedenumireDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedenumireDirectorErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RedenumireDirectorTextBox;
        private System.Windows.Forms.Label RedenumireDirectorLabel;
        private System.Windows.Forms.Button RedenumireDirectorOK;
        private System.Windows.Forms.ErrorProvider RedenumireDirectorErrorProvider;
        private System.Windows.Forms.Button RedenumireDirectorCancel;
    }
}