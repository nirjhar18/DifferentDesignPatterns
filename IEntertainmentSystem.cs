using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDesignPatterns
{
    interface IEntertainmentSystem
    {
        void play(bool IsAllowed);

        void pause();

        void stop();

            
    }
}
