using System;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class VizualizareRatingForm : Form
    {
        private Director director;

        public VizualizareRatingForm(Director _Director)
        {
            InitializeComponent();
            this.director = _Director;
        }

        private void RatingForm_Load(object sender, EventArgs e)
        {
            PopuleazaListView();
        }

        private void RatingButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        void PopuleazaListView()
        {
            for (int IndexFisier = 0; IndexFisier < director.GetListaFisiere().Count; IndexFisier++)
            {
                ListViewItem listViewItem = new ListViewItem(director[IndexFisier].GetNumeFisier(), 0);
                listViewItem.SubItems.Add(director[IndexFisier].GetGen());
                listViewItem.SubItems.Add(director[IndexFisier].GetRecenzie());
                listViewItem.SubItems.Add(director[IndexFisier].GetVizualizat().ToString());
                ListViewRating.Items.Add(listViewItem);
            }
        }

        private void ListViewRating_DoubleClick(object sender, EventArgs e)
        {
            if(ListViewRating.SelectedIndices.Count > 0)
            {
                int IndexFisier = ListViewRating.SelectedIndices[0];
                Form adaugaRating = new AdaugaRatingForm(director[IndexFisier]);
                this.Hide();
                adaugaRating.ShowDialog();
                ListViewRating.Items[IndexFisier].SubItems[1].Text = director[IndexFisier].GetGen();
                ListViewRating.Items[IndexFisier].SubItems[2].Text = director[IndexFisier].GetRecenzie();
                ListViewRating.Items[IndexFisier].SubItems[3].Text = director[IndexFisier].GetVizualizat().ToString();
                this.Show();
            }
        }
    }
}
