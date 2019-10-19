using System.Collections;
using System.Collections.Generic;
using System;

namespace FinalGame
{
    public class HelpCommand : Command
    {
        CommandWords words;

        public HelpCommand() : this(new CommandWords())
        {
        }

        public HelpCommand(CommandWords commands) : base()
        {
            words = commands;
            this.name = "help";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot help you with " + this.secondWord);
            }
            else
            {
                player.outputMessage("\nYou are lost. You are alone. You wander around the university, \n\nYour avaliable commands are " + words.description());
            }
            return false;
        }
    }
}