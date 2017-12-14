using System;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class RedenumireFisierForm : Form
    {
        private Fisier fisier;
        private DataBaseHelper dataBaseHelper = new DataBaseHelper();
        private string numeVechi;

        public RedenumireFisierForm(Fisier _Fisier)
        {
            InitializeComponent();
            this.fisier = _Fisier;
            this.numeVechi = _Fisier.GetNumeFisier().Remove(_Fisier.GetNumeFisier().Length - _Fisier.GetExtensieFisier().Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RedenumireFisierTextBox.Text = numeVechi;
        }

        private void OK(object sender, EventArgs e)
        {
            if (RedenumireFisierTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                RedenumireFisierErrorProvider.SetError(RedenumireFisierTextBox, "Nume Invalid!");
                RedenumireFisierTextBox.Text = "";
            }
            else if (RedenumireFisierTextBox.Text == this.numeVechi)
            {
                RedenumireFisierErrorProvider.SetError(RedenumireFisierTextBox, "Introdu Alt Nume Decat Cel Initial!");
                RedenumireFisierTextBox.Text = "";
            }
            else
            {
                this.fisier.SetNumeFisier(RedenumireFisierTextBox.Text + this.fisier.GetExtensieFisier());
                dataBaseHelper.ActualizareInregistrare(numeVechi, fisier);
                this.Close();
            }
        }

        private void RedenumireFisiereCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
