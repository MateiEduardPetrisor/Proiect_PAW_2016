using System;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class RedenumireDirectorForm : Form
    {
        private Director director;
        private string numeVechi;

        public RedenumireDirectorForm(Director _Director)
        {
            InitializeComponent();
            this.director = _Director;
            this.numeVechi = _Director.GetNumeDirector();
        }

        private void RedenumireDirector_Load(object sender, EventArgs e)
        {
            this.RedenumireDirectorTextBox.Text = director.GetNumeDirector();
        }

        private void RedenumireDirectorOK_Click(object sender, EventArgs e)
        {
            if (RedenumireDirectorTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                RedenumireDirectorErrorProvider.SetError(RedenumireDirectorTextBox, "Nume Invalid!");
                RedenumireDirectorTextBox.Text = "";
            }
            else if (RedenumireDirectorTextBox.Text == this.numeVechi)
            {
                RedenumireDirectorErrorProvider.SetError(RedenumireDirectorTextBox, "Introdu Alt Nume Decat Cel Initial!");
                RedenumireDirectorTextBox.Text = "";
            }
            else
            {
                this.director.SetNumeDirector(RedenumireDirectorTextBox.Text);
                this.Close();
            }
        }

        private void RedenumireDirectorCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
