using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    /// <summary>
    /// Adapter pattern works as a bridge between two incompatible interfaces.This pattern involves a single class
    /// which is responsible to join functionalities of independent or incompatible interfaces. In this example, it is being used
    /// to add advance features to some higher models of basic cars.
    /// </summary>
    class AdapterPatternForAdvanceFeatures : IAdvancedCarFunctions
    {
        public void autoPilot()
        {
            Console.WriteLine("Auto Pilot");
        }
    }
}
