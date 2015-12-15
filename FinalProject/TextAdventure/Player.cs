/// Author - Manju Mehta
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Player
    {
        private Cell location;

        public Player()
        {
            location = null;
        }

        public Cell getCell()
        {
            return location;
        }

        public void setCell(Cell location)
        {
            this.location = location;
        }

        public void tryLocation()
        {
            this.location = location.getNextLocation();
           // Console.WriteLine("\nThe current location is: {0}", this.location);
        }

        public bool checkEndGame()
        {
            return this.location.isEndLocation();  // should it be null, creates issue in case of wrong answer
        }

        public void endGame()
        {
            this.location.endGame();
        }
    }
}
