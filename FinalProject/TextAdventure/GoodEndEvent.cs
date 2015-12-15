/// Author: Manju Mehta
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class GoodEndEvent : Event
    {
        public override void doEndEvent()
        {
            Console.WriteLine("\n\nCongratulations!!! You completed the word puzzle.");
        }
    }
}
