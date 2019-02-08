using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    class Mercedes : Car, IAdvancedCarFunctions, IEntertainmentSystem
    {
 
        public string carType { get; set; }

        public string color { get; set; }

        public string Model { get; set; }
        public double price { get; set; }

        public void autoPilot()
        {
            Console.WriteLine("Auto");
        }

        public override void brakeSystem()
        {
            Console.WriteLine("Brake in less than 0.02ms");
        }

        public override void drivingModes(string mode)
        {
            switch (mode)

            {
                case "mountain":
                    {
                        Console.WriteLine("Switching to 4x4 mode");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Normal Mode");
                        break;
                    }

            }

        }

        public void pause()
        {
            Console.WriteLine("Pause");
        }

        public void play(bool IsAllowed)
        {
            if (IsAllowed)
            {
                Console.WriteLine("Start Music");
            }
            else
            {
                Console.WriteLine("Not Available");
            }

        }

        public void stop()
        {
            Console.WriteLine("Stop Music");
        }
    }
}
