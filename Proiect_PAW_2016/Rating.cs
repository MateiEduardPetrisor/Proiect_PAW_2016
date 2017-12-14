using System;

namespace Proiect_PAW
{
    public abstract class Rating
    {
        private string Gen;
        private string Recenzie;
        private bool Vizualizat;

        public string GetGen()
        {
            return this.Gen;
        }

        public string GetRecenzie()
        {
            return this.Recenzie;
        }

        public bool GetVizualizat()
        {
            return this.Vizualizat;
        }

        public void SetGen(string _Gen)
        {
            this.Gen = _Gen;
        }

        public void SetRecenzie(string _Recenzie)
        {
            this.Recenzie = _Recenzie;
        }

        public void SetVizualizat(bool _Vizualizat)
        {
            this.Vizualizat = _Vizualizat;
        }

        public Rating()
        {
            this.Gen = null;
            this.Recenzie = null;
            this.Vizualizat = false;
        }

        public Rating(string _Gen, string _Recenzie, bool _Vizualizat)
        {
            this.Gen = _Gen;
            this.Recenzie = _Recenzie;
            this.Vizualizat = _Vizualizat;
        }

        public override string ToString()
        {
            return this.GetGen() + " " + this.GetRecenzie() + " " + this.GetVizualizat();
        }
    }
}