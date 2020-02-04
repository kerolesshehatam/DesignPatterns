using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsPOC.Adapter
{
    public class XmlToJsonAdapter : IXmlToJsonAdapter
    {
        private readonly IXmlConverter _xmlConverterAdaptee;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverterAdaptee = xmlConverter;

        }
        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverterAdaptee.GetXML()
                                .Element("Manufacturers")
                                .Elements("Manufacturer")
                                .Select(m => new Manufacturer
                                {
                                    City = m.Attribute("City").Value,
                                    Name = m.Attribute("Name").Value,
                                    Year = Convert.ToInt32(m.Attribute("Year").Value)
                                });

            new JsonConverter(manufacturers)
                .ConvertToJson();
        }
    }
}
