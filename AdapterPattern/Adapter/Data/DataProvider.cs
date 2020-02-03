using System.Collections.Generic;

namespace DesignPatternsPOC.Adapter
{
    public class DataProvider
    {
        public static List<Manufacturer> GetData()
        {
            return new List<Manufacturer>
        {
            new Manufacturer{City ="Italy",Name="Alfa",Year=2016},
            new Manufacturer{City ="UK",Name="UK Name",Year=2018},
            new Manufacturer{City ="USA",Name="USA Name",Year=2017}
        };
        }
    }
}
