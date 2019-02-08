using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    /// <summary>
    /// Factory pattern is used to create instances of different car Types. 
    /// Factory pattern will help hide the creation logic from client
    /// </summary>
    class CarFactoryPattern
    {
        private string CarColor;
        private string CarModel;
        private string CarType;
        private double CarPrice;
        public Bmw GetBCarInstance()
        {           
         return new Bmw( CarColor,  CarModel,  CarPrice,  CarType);

        }

        public Mercedes GetMCarInstance()
        {
            return new Mercedes();
        }

        
    }
}
