using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactoryPattern cf = new CarFactoryPattern();
            Bmw c1 = cf.GetBCarInstance();
            c1.brakeSystem();
            c1.BmwFunction1();

            ICarFunctions cf3 = new Bmw();
            cf3.brakeSystem();

            CarBuilderPattern bp = new CarBuilderPattern();
            Bmw bmwCar = bp.prepareBmwCar(true);

            StrategyPattern sp = new StrategyPattern(new Bmw());
            sp.executeMovecarBack(true);
           

        }
    }
}
