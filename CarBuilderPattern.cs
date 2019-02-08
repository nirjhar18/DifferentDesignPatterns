using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    /// <summary>
    /// Builder pattern builds a complex object using simple objects and using a step by step approach.
    /// It is also a creational pattern like factory which is used to create objects.
    /// </summary>
    class CarBuilderPattern
    {
        public Bmw prepareBmwCar(bool entertainmentSystem)
        {
            Bmw newCar = new Bmw();
            if (entertainmentSystem == true)
            {
                newCar.play(entertainmentSystem);
                return newCar; 
            }
            else
            {
                newCar.stop();
                return newCar;
            }          
           
        }

        public Mercedes prepareMercedesCar(bool entertainmentSystem)
        {
            Mercedes newMCar = new Mercedes();

            return newMCar;
        }
    }
}
