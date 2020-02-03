using BridgePattern.Bridge;
using BridgePattern.Bridge.Json;
using BridgePattern.Bridge.XML;

namespace BridgePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataPresenter dataPresenter = new DataPresenter();
            dataPresenter.Presenter = new JSONPresenter(new JsonConverter());
            dataPresenter.Operation();


            dataPresenter.Presenter = new XMLPresenter(new XmlConverter());
            dataPresenter.Operation();


        }
    }
}
