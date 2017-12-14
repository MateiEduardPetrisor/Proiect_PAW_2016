using System.Xml;

namespace Proiect_PAW
{
    public interface IDirector
    {
        void SalvareXML(XmlTextWriter _XmlTextWriter);
        string CitesteXML(XmlTextReader _XmlTextReader);
    }
}