using System;

namespace HW_Tic_Tac_Toe
{

    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.StartNewGame();

            Console.ReadLine();
        }
    }
}
