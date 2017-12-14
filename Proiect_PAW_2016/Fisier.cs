using System;
namespace Proiect_PAW
{
    public class Fisier : Rating, ICloneable
    {
        private string NumeFisier;
        private string NumeComplet;
        private string ExtensieFisier;
        private double DimensiuneFisier;

        public string GetNumeFisier()
        {
            return this.NumeFisier;
        }

        public double GetDimensiuneFisier()
        {
            return this.DimensiuneFisier;
        }

        public string GetNumeComplet()
        {
            return this.NumeComplet;
        }

        public string GetExtensieFisier()
        {
            return this.ExtensieFisier;
        }

        public void SetExtensieFisier(string _ExtensieFisier)
        {
            this.ExtensieFisier = _ExtensieFisier;
        }

        public void SetNumeFisier(string _NumeFisier)
        {
            this.NumeFisier = _NumeFisier;
        }

        public void SetNumeComplet(string _NumeComplet)
        {
            this.NumeComplet = _NumeComplet;
        }

        public void SetDimensiuneFisier(double _DimensiuneFisier)
        {
            this.DimensiuneFisier = _DimensiuneFisier;
        }

        object ICloneable.Clone()
        {
            Fisier fisier = new Fisier();
            fisier.SetNumeFisier(this.GetNumeFisier());
            fisier.SetNumeComplet(this.GetNumeComplet());
            fisier.SetExtensieFisier(this.GetExtensieFisier());
            fisier.SetDimensiuneFisier(this.GetDimensiuneFisier());
            return fisier;
        }

        public Fisier() : base()
        {
            this.NumeFisier = null;
            this.NumeComplet = null;
            this.ExtensieFisier = null;
            this.DimensiuneFisier = 0;
        }

        public Fisier(string _NumeFisier, string _NumeComplet, string _ExtensieFisier,
            double _DimensiuneFisier, string _Gen, string _Recenzie, bool _Vizualizat)
            : base(_Gen, _Recenzie, _Vizualizat)
        {
            this.NumeFisier = _NumeFisier;
            this.NumeComplet = _NumeComplet;
            this.ExtensieFisier = _ExtensieFisier;
            this.DimensiuneFisier = _DimensiuneFisier;
        }

        override public string ToString()
        {

            return this.GetNumeFisier() + " " + this.GetNumeComplet() + " "
                + this.GetExtensieFisier() + " " + this.GetDimensiuneFisier()
                + " " + base.ToString() + "\n";
        }
    }
}
