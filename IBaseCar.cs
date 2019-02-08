using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    /// <summary>
    /// Base Interface which will be implemented by Base class.
    /// </summary>
    interface IBaseCar
    {
        string color { get; set; }
        double price { get; set; }
        string Model { get; set; }
        string carType { get; set; }

       
    }
}
