using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
   abstract class Car : ICarFunctions
    {
        string color { get; set; }
        double price { get; set; }
        string Model { get; set; }
        string carType { get; set; }

        //Abstract methods does not have any implmentation and it forces the derived class to override the methods.
        //best tool for abstraction is Interfaces
        public abstract void brakeSystem();

        //Virtual methods can have implementation and does not force the derived class to override the methods.
        public virtual void drivingModes(string mode)
        {
           
        }

  
    }
}
