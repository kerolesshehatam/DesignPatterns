using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace BridgePattern.Bridge.Json
{
    public class JsonConverter
    {
        private IEnumerable<Manufacturer> _manufacturers;

        public JsonConverter()
        {
            _manufacturers = DataProvider.GetData();
        }

        public void GetJson()
        {
            
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}
