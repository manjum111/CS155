using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class PuzzleEvent : Event
    {
        public override bool completeEvent()
        {
            Console.WriteLine("Starting the TextAdnenture Game...\n");
            Console.WriteLine("Please fill in the missing letter in the following word:\n");
            Console.WriteLine("     E_ceptions");
            Console.WriteLine("\nYour answer is as follows:");
            string input = Console.ReadLine();

            if (input.Equals("x"))
            {
                Console.WriteLine("Very good, you passed this test.\n");
                return true;
            }
            else
            {
                Console.WriteLine("\nSorry, you failed this test, try again.");
                return false;
            }
        }

    }
}
