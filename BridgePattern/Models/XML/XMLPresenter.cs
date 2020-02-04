using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Bridge.XML
{
    public class XMLPresenter : IPresenter
    {
        private IXmlConverter _xmlConverter;
        public XMLPresenter(IXmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }
        public void OperationImplementation()
        {
            _xmlConverter.GetXML();
        }
    }
}
