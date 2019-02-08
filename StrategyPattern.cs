using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    /// <summary>
    /// A class behavior or its algorithm can be changed at run time. This type of design pattern comes under behavior pattern.
    /// </summary>
    class StrategyPattern
    {
        private IStrategyCarBack strategy;

        public StrategyPattern(IStrategyCarBack strategy)
        {
            this.strategy = strategy;
        }
         public void executeMovecarBack(bool carBack)
        {
             strategy.DriveCarBack(carBack);
        }
    }
}
