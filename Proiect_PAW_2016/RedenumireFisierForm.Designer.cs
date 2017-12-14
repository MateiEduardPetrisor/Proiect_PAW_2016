namespace Proiect_PAW
{
    partial class RedenumireFisierForm
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
            this.RedenumireFisiserOK = new System.Windows.Forms.Button();
            this.RedenumireFisierTextBox = new System.Windows.Forms.TextBox();
            this.RedenumireFisierLabel = new System.Windows.Forms.Label();
            this.RedenumireFisierErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RedenumireFisiereCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedenumireFisierErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RedenumireFisiserOK
            // 
            this.RedenumireFisiserOK.Location = new System.Drawing.Point(77, 41);
            this.RedenumireFisiserOK.Name = "RedenumireFisiserOK";
            this.RedenumireFisiserOK.Size = new System.Drawing.Size(75, 23);
            this.RedenumireFisiserOK.TabIndex = 0;
            this.RedenumireFisiserOK.Tag = "OK";
            this.RedenumireFisiserOK.Text = "OK";
            this.RedenumireFisiserOK.UseVisualStyleBackColor = true;
            this.RedenumireFisiserOK.Click += new System.EventHandler(this.OK);
            // 
            // RedenumireFisierTextBox
            // 
            this.RedenumireFisierTextBox.Location = new System.Drawing.Point(53, 15);
            this.RedenumireFisierTextBox.Name = "RedenumireFisierTextBox";
            this.RedenumireFisierTextBox.Size = new System.Drawing.Size(219, 20);
            this.RedenumireFisierTextBox.TabIndex = 2;
            // 
            // RedenumireFisierLabel
            // 
            this.RedenumireFisierLabel.AutoSize = true;
            this.RedenumireFisierLabel.Location = new System.Drawing.Point(9, 18);
            this.RedenumireFisierLabel.Name = "RedenumireFisierLabel";
            this.RedenumireFisierLabel.Size = new System.Drawing.Size(38, 13);
            this.RedenumireFisierLabel.TabIndex = 3;
            this.RedenumireFisierLabel.Text = "Nume:";
            this.RedenumireFisierLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RedenumireFisierErrorProvider
            // 
            this.RedenumireFisierErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.RedenumireFisierErrorProvider.ContainerControl = this;
            // 
            // RedenumireFisiereCancel
            // 
            this.RedenumireFisiereCancel.Location = new System.Drawing.Point(158, 41);
            this.RedenumireFisiereCancel.Name = "RedenumireFisiereCancel";
            this.RedenumireFisiereCancel.Size = new System.Drawing.Size(75, 23);
            this.RedenumireFisiereCancel.TabIndex = 4;
            this.RedenumireFisiereCancel.Text = "Cancel";
            this.RedenumireFisiereCancel.UseVisualStyleBackColor = true;
            this.RedenumireFisiereCancel.Click += new System.EventHandler(this.RedenumireFisiereCancel_Click);
            // 
            // RedenumireFisierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 73);
            this.ControlBox = false;
            this.Controls.Add(this.RedenumireFisiereCancel);
            this.Controls.Add(this.RedenumireFisierLabel);
            this.Controls.Add(this.RedenumireFisierTextBox);
            this.Controls.Add(this.RedenumireFisiserOK);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 112);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 112);
            this.Name = "RedenumireFisierForm";
            this.Text = "Redenumire Fisier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedenumireFisierErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedenumireFisiserOK;
        private System.Windows.Forms.TextBox RedenumireFisierTextBox;
        private System.Windows.Forms.Label RedenumireFisierLabel;
        private System.Windows.Forms.ErrorProvider RedenumireFisierErrorProvider;
        private System.Windows.Forms.Button RedenumireFisiereCancel;
    }
}