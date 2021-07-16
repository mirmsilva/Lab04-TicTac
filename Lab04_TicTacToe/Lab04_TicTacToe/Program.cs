using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players
            // and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is
            // output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.

            //Player One
            Player playerOne = new Player();
            playerOne.Name = "P1";
            playerOne.Marker = "X";
            playerOne.IsTurn = true;

            //Player Two
            Player playerTwo = new Player();
            playerTwo.Name = "P2";
            playerTwo.Marker = "O";
            playerTwo.IsTurn = false;


        }


    }
}
