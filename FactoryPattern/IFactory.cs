using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IFactory
    {
        IVehicle GetVehicle(string Vehicle);
    }
}
