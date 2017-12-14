using System;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class AdaugaRatingForm : Form
    {
        private Fisier fisier;
        private DataBaseHelper dataBaseHelper = new DataBaseHelper();
        private string NumeVechiFisier;
        public AdaugaRatingForm(Fisier _Fisier)
        {
            InitializeComponent();
            this.fisier = _Fisier;
            this.NumeVechiFisier = _Fisier.GetNumeFisier();
        }

        private void AdaugaRatingForm_Load(object sender, EventArgs e)
        {
            AdaugaRatingTextBoxGen.Text = fisier.GetGen();
            AdaugaRatingTextBoxRecenzie.Text = fisier.GetRecenzie();
            AdaugaRatingComboBox.Text = fisier.GetVizualizat().ToString();
        }

        private void AdaugaRecenzieButton_click(object sender, EventArgs e)
        {
            if (AdaugaRatingTextBoxGen.Text == "")
            {
                AdaugaRatingErrorProvider.SetError(AdaugaRatingTextBoxGen, "Whitespace Nu Este Permis");
                AdaugaRatingTextBoxGen.Text = "";
                AdaugaRatingTextBoxRecenzie.Text = "";
            }
            else if (AdaugaRatingTextBoxRecenzie.Text == "")
            {
                AdaugaRatingErrorProvider.Clear();
                AdaugaRatingErrorProvider.SetError(AdaugaRatingTextBoxRecenzie, "Whitespace Nu Este Permis");
                AdaugaRatingTextBoxGen.Text = "";
                AdaugaRatingTextBoxRecenzie.Text = "";
            }
            else if (AdaugaRatingTextBoxRecenzie.Text.Length > 25)
            {
                AdaugaRatingErrorProvider.Clear();
                AdaugaRatingErrorProvider.SetError(AdaugaRatingTextBoxRecenzie, "Recenzia Max 25 Caractere");
                AdaugaRatingTextBoxRecenzie.Text = "";
                AdaugaRatingTextBoxGen.Text = "";
            }
            else
            {
                fisier.SetGen(AdaugaRatingTextBoxGen.Text);
                fisier.SetRecenzie(AdaugaRatingTextBoxRecenzie.Text);
                if (AdaugaRatingComboBox.Text == "true")
                {
                    fisier.SetVizualizat(true);
                }
                else
                {
                    fisier.SetVizualizat(false);
                }
                dataBaseHelper.ActualizareInregistrare(NumeVechiFisier,fisier);
                this.Close();
            }
        }
    }
}
