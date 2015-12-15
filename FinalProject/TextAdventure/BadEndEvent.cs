/// Author: Manju Mehta
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure 
{
    class BadEndEvent : Event
    {
        public override void doEndEvent()
        {
            Console.WriteLine("\n\nYou did not complete all of the words correctly. ");
            Console.WriteLine("Sorry, you did not pass the Word Puzzle.");
        }
    }
}
