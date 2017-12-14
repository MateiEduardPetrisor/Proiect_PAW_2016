using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Proiect_PAW
{
    public class Director : ICloneable, IDirector
    {
        private string NumeDirector;
        private string LocatieDirector;
        private List<Fisier> ListaFisiere;

        public string GetNumeDirector()
        {
            return this.NumeDirector;
        }

        public string GetLocatieDirector()
        {
            return this.LocatieDirector;
        }

        public List<Fisier> GetListaFisiere()
        {
            return this.ListaFisiere;
        }

        public void SetNumeDirector(string _NumeDirector)
        {
            this.NumeDirector = _NumeDirector;
        }

        public void SetLocatieDirector(string _LocatieDirector)
        {
            this.LocatieDirector = _LocatieDirector;
        }

        public void SetListaFisiere(List<Fisier> _ListaFisiere)
        {
            this.ListaFisiere = new List<Fisier>();
            for (int IndexFisier = 0; IndexFisier < _ListaFisiere.Count(); IndexFisier++)
            {
                this.ListaFisiere.Add(_ListaFisiere[IndexFisier]);
            }
        }

        public Fisier this[int _Index]
        {
            get
            {
                return this.ListaFisiere[_Index];
            }
            set
            {
                this.ListaFisiere[_Index] = value;
            }
        }

        object ICloneable.Clone()
        {
            Director director = new Director();
            director.SetNumeDirector(this.GetNumeDirector());
            director.SetLocatieDirector(this.GetLocatieDirector());
            director.ListaFisiere = new List<Fisier>();
            for (int IndexFisier = 0; IndexFisier < this.GetListaFisiere().Count(); IndexFisier++)
            {
                director.ListaFisiere[IndexFisier] = this.ListaFisiere[IndexFisier];
            }
            return director;
        }

        public void SalvareXML(XmlTextWriter _XmlTextWriter)
        {
            _XmlTextWriter.WriteStartElement("Director");
            _XmlTextWriter.WriteElementString("Locatie", this.GetLocatieDirector());
            _XmlTextWriter.WriteEndElement();
        }

        public String CitesteXML(XmlTextReader _XmlTextReader)
        {
            string LocatieDirector = null;
            if (_XmlTextReader.NodeType == XmlNodeType.Element && _XmlTextReader.Name == "Locatie")
            {
                LocatieDirector = _XmlTextReader.ReadElementString();
            }
            return LocatieDirector;
        }

        public Director()
        {
            this.NumeDirector = null;
            this.LocatieDirector = null;
            this.ListaFisiere = null;
        }

        public Director(string _NumeDirector, string _LocatieDirector, List<Fisier> _ListaFisiere)
        {
            this.NumeDirector = _NumeDirector;
            this.LocatieDirector = _LocatieDirector;
            this.ListaFisiere = _ListaFisiere;
        }

        public override string ToString()
        {
            string info = this.GetNumeDirector() + " " + this.GetLocatieDirector() + " \n";
            for (int indexFisier = 0; indexFisier < this.ListaFisiere.Count; indexFisier++)
            {
                info = string.Concat(info, this.ListaFisiere[indexFisier].ToString());
            }
            return info;
        }
    }
}