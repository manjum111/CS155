/// CS155
/// Final class project
/// Author: Manju Mehta
/// 
/// Assignment: A text based word puzzle game to finish missing letter in a word.
/// 
/// Approach: Goal is to go though all of the cells/loactions available.
/// 
/// Each cell has an event. Based on the players result from this event, the next cell that player enters 
/// will be determined. 
/// Implementation: 
/// 1)  Create several locations (or Cells). Each cell must have 3 objects: 
///     2 Cell objects and 1 event object. The first cell object is the events outcome of completing the event.
///     The second cell is for failing the event. 
/// 2) If a player guesses a correct answer to complete an event, he/she moves to the next cell.
/// 3) If a player guesses an incorect answer to complete an event, he/she is given additional opportunities to guess correct answer.
/// 4) After going through all the locations, puzzle game ends with a message to indicate the outcome.
/// 
/// Limitations: 1) Did not have enough time to catch exceptions
///              2) The program is limited to a ceratin number of cells at this time
///              3) Note that all paths of the puzzle have not been tried.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // starting cell is cell1, this portion sets up the events for each cell
            Cell cell1 = new Cell("Cell1");
            PuzzleEvent cell1Event = new PuzzleEvent();
            cell1.setEvent(cell1Event);

            Cell cell2 = new Cell("cell2");
            PuzzleEvent1 cell2Event = new PuzzleEvent1();
            cell2.setEvent(cell2Event);

            Cell cell3 = new Cell("Cell3");
            PuzzleEvent2 cell3Event = new PuzzleEvent2();
            cell3.setEvent(cell3Event);

            Cell cell4 = new Cell("cell4");
            PuzzleEvent3 cell4Event = new PuzzleEvent3(); // try catch?
            cell4.setEvent(cell4Event);

            Cell cell5 = new Cell("cell5");
           PuzzleEvent4 cell5Event = new PuzzleEvent4(); // boolean?
            cell5.setEvent(cell5Event);

            Cell cell6 = new Cell("cell6");
            PuzzleEvent5 cell6Event = new PuzzleEvent5();
            cell6.setEvent(cell6Event);

            Cell cell7 = new Cell("cell7");
            PuzzleEvent6 cell7Event = new PuzzleEvent6();
            cell7.setEvent(cell7Event);

            Cell cell8 = new Cell("cell6");
            PuzzleEvent7 cell8Event = new PuzzleEvent7();
            cell8.setEvent(cell8Event);
            
            Cell cell9 = new Cell("cell9");
            PuzzleEvent8 cell9Event = new PuzzleEvent8();
            cell9.setEvent(cell9Event);

            Cell cell10 = new Cell("cell10");
            GoodEndEvent cell10Event = new GoodEndEvent();
            cell10Event.setEndEvent(true);
            cell10.setEvent(cell10Event);

            Cell cell11 = new Cell("cell11");
            BadEndEvent cell11Event = new BadEndEvent();
            cell11Event.setEndEvent(true);
            cell11.setEvent(cell11Event);

            // This portion moves each cell based on answer. 
            cell1.setCorrectCell(cell2);
            cell1.setIncorrectCell(cell1);

            cell2.setCorrectCell(cell3);
            cell2.setIncorrectCell(cell2);

            cell3.setCorrectCell(cell4); 
            cell3.setIncorrectCell(cell3);
            
            cell4.setCorrectCell(cell5); 
            cell4.setIncorrectCell(cell4);

            cell5.setCorrectCell(cell6); 
            cell5.setIncorrectCell(cell4);

            cell6.setCorrectCell(cell7); 
            cell6.setIncorrectCell(cell6);

            cell7.setCorrectCell(cell8);
            cell7.setIncorrectCell(cell7);
            
            cell8.setCorrectCell(cell9);
            cell8.setIncorrectCell(cell8);

            cell9.setCorrectCell(cell10);   // If the previous answer is correct, finish with good event
            cell9.setIncorrectCell(cell11); // If the previous answer is incorrect, finish with bad event

            Player player = new Player();
            player.setCell(cell1);

            while (!player.checkEndGame())
            {
                player.tryLocation();

            }

            player.endGame();
            Console.ReadLine();
        }
    }
}
