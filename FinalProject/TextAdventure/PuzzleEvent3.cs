using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class PuzzleEvent3 : Event
    {
        public override bool completeEvent()
        {
            Console.WriteLine("Please fill in the missing letter in the following word:\n");
            Console.WriteLine("     TryCa_ch");
            Console.WriteLine("\nYour answer is as follows:");
            string input = Console.ReadLine();

            if (input.Equals("t"))
            {
                Console.WriteLine("\nVery good, you passed this test, try again!");
                return true;
            }
            else
            {
                Console.WriteLine("\nSorry, you failed this test. Try again!");
                return false;
            }
        }



    }
}
