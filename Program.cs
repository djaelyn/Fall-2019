﻿using System;

namespace FinalGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game game = new Game();
            game.start();
            game.play();
            game.end();
        }
    }
}
