using System.Xml.Linq;

namespace BridgePattern.Bridge.XML
{
    public interface IXmlConverter
    {
        XDocument GetXML();
    }
}
