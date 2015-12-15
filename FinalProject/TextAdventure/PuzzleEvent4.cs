﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class PuzzleEvent4 : Event
    {
        public override bool completeEvent()
        {
            Console.WriteLine("Please fill in the missing letter in the following word:\n");
            Console.WriteLine("     Bo_lean");
            Console.WriteLine("\nYour answer is as follows:");
            string input = Console.ReadLine();

            if (input.Equals("o"))
            {
                Console.WriteLine("\nVery good, you passed the test.");
                return true;
            }
            else
            {
                Console.WriteLine("\nSorry, you failed this test, try again!");
                return false;
            }
        }
    }
}
