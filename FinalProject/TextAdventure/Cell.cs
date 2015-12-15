/// Author: Manju Mehta
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Cell
    {
        private string cellname;

        private Cell correct;
        private Cell incorrect;
        private Event actionEvent;
        private string tempcell;

        public Cell(string tempcell)
        {
            this.correct = null;
            this.incorrect = null;
            this.actionEvent = null;
            this.cellname = tempcell; // added to print cell ID
        }

        public Cell getNextLocation()
        {
            if(actionEvent.completeEvent())
            {
                return correct;
            }
            else
            {
                return incorrect;
            }
        }

        public bool isEndLocation()
        {
            return actionEvent.isEndEvent();
        }

        public void setCorrectCell(Cell cell)
        {
            this.correct = cell;
        }

        public void setIncorrectCell(Cell cell)
        {
            this.incorrect = cell;
        }

        public void setEvent(Event action)
        {
            this.actionEvent = action;
        }

        public Cell getCorrectCell()
        {
            return this.correct;
        }

        public Cell getIncorrectCell()
        {
            return this.incorrect;
        }

        public Event getEvent()
        {
            return this.actionEvent;
        }

        public void endGame()
        {
            this.actionEvent.doEndEvent();
        }

        //Added to print cell ID for debugging
        public override string ToString()
        {
            return this.tempcell;
        }

    }
}
