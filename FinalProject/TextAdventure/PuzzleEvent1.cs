using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextAdventure
{
    class PuzzleEvent1 : Event
    {
        //The text for completing the event
        public override bool completeEvent()
        {
            Console.WriteLine("Please fill in the missing letter in the following word:\n");
            Console.WriteLine("     Bea_ty");
            Console.WriteLine("\nYour answer is as follows:");
            string input = Console.ReadLine();

            if(input.Equals("u"))
            {
                Console.WriteLine("\nVery good, you passed this test.\n");
                return true;
            }
            else
            {
                Console.WriteLine("\nSorry, you failed this test, try again!");
                // Thread.Sleep(2000);
               return false;
            }
        }
    }
}
