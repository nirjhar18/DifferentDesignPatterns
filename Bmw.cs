using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    /// <summary>
    /// This is a concrete class that inherits from abstract class and implements different functions. The instance of this class
    /// is created using factory pattern so creation logic is hidden from the client.
    /// </summary>
    class Bmw : Car, OnlyImplementedByBmw, IAdvancedCarFunctions, IEntertainmentSystem,IStrategyCarBack
    {
        public string carType{ get;set;}

        public string color { get; set; }

        public string Model { get; set; }
        public double price { get; set; }
        public Bmw() { }
        public Bmw(string CarColor,string CarModel,double CarPrice, string CarType)
        {
            carType = CarType;
            color = CarColor;
            Model = CarModel;
            price = CarPrice;
        }

        public void autoPilot()
        {
            Console.WriteLine("Auto");
        }

        //It is required to override this function because it is an abstract function in base class
        public override void brakeSystem()
        {
            Console.WriteLine("Brake in less than 0.02ms");
        }

        //Override the virtual function
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

        public void BmwFunction1()
        {
            Console.WriteLine("New Function");
        }

        public void DriveCarBack(bool backCamera)
        {
            if (backCamera == true)
            {
                Console.WriteLine("Use Back camera");
            }
        }
    }
}
