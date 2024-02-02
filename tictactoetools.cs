using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class tictactoetools
    {
        // Receive the Game Board Array
        public bool checkWin(string[] arr)
        {
            string[] checkWin = (string[])arr;

            if ((checkWin[0] == checkWin[1] && checkWin[1] == checkWin[2]) ||
                (checkWin[3] == checkWin[4] && checkWin[4] == checkWin[5]) ||
                (checkWin[6] == checkWin[7] && checkWin[7] == checkWin[8]) ||
                (checkWin[0] == checkWin[3] && checkWin[3] == checkWin[6]) ||
                (checkWin[1] == checkWin[4] && checkWin[4] == checkWin[7]) ||
                (checkWin[2] == checkWin[5] && checkWin[5] == checkWin[8]) ||
                (checkWin[0] == checkWin[4] && checkWin[4] == checkWin[8]) ||
                (checkWin[2] == checkWin[4] && checkWin[4] == checkWin[8]))
            {
                return true;
            }
            return false;

        }

        static void printBoard(string[] board)
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        // Method 1: Print the board based on the info passed to it

        // Method 2: a method that receives the game board array as input and returns if there is a
        // winner and who it was




    }
}
