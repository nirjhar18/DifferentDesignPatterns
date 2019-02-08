using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    class Sentra : Car, IStrategyCarBack
    {
        public Sentra() { }

       
        public override void brakeSystem()
        {
            Console.WriteLine("Brake in less than 0.05ms");
        }

        public void DriveCarBack(bool backCamera)
        {
            Console.WriteLine("Does not have a camera");
        }

        public override void drivingModes(string mode)
        {
            switch (mode)

            {
                case "mountain":
                    {
                        Console.WriteLine("Not Available");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Normal Mode");
                        break;
                    }
            }

        }

    
        public void drivingModes(string Mode, bool advance)
        {
            if (advance == true)
            {
                //Using adapater pattern to call an interface method of autopilot
                AdapterPatternForAdvanceFeatures apSentra = new AdapterPatternForAdvanceFeatures();
                apSentra.autoPilot(); 
            }
        }

        public  void entertainmentSystem()
        {
            Console.WriteLine("Music");
        }

      
    }
}
