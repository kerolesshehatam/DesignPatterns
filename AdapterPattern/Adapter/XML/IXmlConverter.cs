using System.Xml.Linq;

namespace DesignPatternsPOC.Adapter
{
    public interface IXmlConverter
    {
        XDocument GetXML();
    }
}
