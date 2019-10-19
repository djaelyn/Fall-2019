using System.Collections;
using System.Collections.Generic;
using System;

namespace FinalGame
{
    public class GoCommand : Command
    {
        public GoCommand() : base()
        {
            this.name = "go";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.walkTo(this.secondWord);             
            }
            else
            {
                player.outputMessage("\nGo where?");
            }
            return false;
        }
    }
}
