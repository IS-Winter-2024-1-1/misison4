using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    public static class Support
    {
        public static void printBoard(string[] board)
        {
            // Print out the board.
            Console.WriteLine("\n" + board[0] + " | " + board[1] + " | " + board[2] +
                                "\n——————————\n" +
                                board[3] + " | " + board[4] + " | " + board[5] +
                                "\n——————————\n" +
                                board[6] + " | " + board[7] + " | " + board[8] + "\n"
                                );
        }


        // Accepts an array of strings representing the current state of the board.
        // If it detects a winner, it will return that player's symbol.
        // If there is a tie, it returns "T". Otherwise, returns an empty string.
        public static string results(string[] board)
        {
            // All sets of three positions that make a line.
            int[][] lines = [[0, 1, 2], [3, 4, 5], [6, 7, 8], [0, 3, 6], [1, 4, 7], [2, 5, 8], [0, 4, 8], [2, 4, 6]]; 

            // A loop that iterates through the position combinations
            for (int i = 0; i < lines.Length; i++)
            {
                // Check if the values on the board make a winning line.
                if (board[lines[i][0]] == board[lines[i][1]] && board[lines[i][0]] == board[lines[i][2]])
                {
                    // Return "X" or "O", depending on winner.
                    return board[lines[i][0]];
                }
            }

            // A loop that checks each position for a value that is not an X or O. If it finds one, it will return that the game has not ended.
            for (int i = 0; i < 9; i++)
            {
                if (board[i] != "X" && board[i] != "O")
                {
                    return "";
                }
            }

            // If this point is reached and the method has not returned, that means it is a tie.
            return "T";

        }

    }
}
