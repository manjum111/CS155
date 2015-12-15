/// Author: Manju Mehta
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Event
    {
        private bool endEvent;

        //Default constructor
        public Event()
        {
            endEvent = false;
        }
        
        //The text for completing the event
        public virtual bool completeEvent()
        {
            Console.WriteLine("\nInput 'yes' to complete, 'no' to skip this event.");
            string input = Console.ReadLine();

            if(input == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void doEndEvent()
        {
            Console.WriteLine("You completed the word puzzle.");
        }

        public virtual bool isEndEvent()
        {
            return endEvent;
        }

        public void setEndEvent(bool value)
        {
            endEvent = value;
        }

        public bool getEndEvent()
        {
            return endEvent;
        }
    }
}
