using DesignPatternsPOC.Adapter;
using System;

namespace DesignPatternsPOC
{
    class Program
    {
        static void Main(string[] args)
        {

            var xmlConverter = new XmlConverter();

            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
            Console.ReadLine();

        }
    }
}
