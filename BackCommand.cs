using System.Collections;
using System.Collections.Generic;
using System;

namespace FinalGame
{
    public class BackCommand : Command
    {
        Stack<Room> visitedRooms;

        public BackCommand() : this(new Stack<Room>())
        {
        }
        public BackCommand(Stack<Room> rooms) : base()
        {
            this.name = "back";
            visitedRooms = rooms;
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot go back " + this.secondWord);
                //instructions: let user know if they want to go back they must enter "back"
            }
            else
            {
                player.backtrack();
            }
            return false; 
        }
    }
}
