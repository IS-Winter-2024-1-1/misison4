using Mission4;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome the players
        Console.WriteLine("Welcome to Tic-Tac-Toe!!");
        // Create the game board
        string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        Support.printBoard(gameBoard);
        bool stillPlaying = true;
        //Create a variable to count the number of turns
        int turnCount = 1;

        //Start the game loop
        do
        {
            // If the turn count is odd, it is player X's turn
            if ((turnCount % 2) == 1)
            {
                //Make the first player choose their spot from the board
                Console.Write("Player X: Choose where to place your X (1-9) \n");
                try
                {
                    int turnLocationX = int.Parse(Console.ReadLine());
                    int turnIndexX = turnLocationX - 1;
                    //Check to see if chosen space has already been taken; then update the gameBoard
                    if (gameBoard[turnIndexX] == "X" || gameBoard[turnIndexX] == "O")
                    {
                        Console.WriteLine("\nThis space has already been taken");
                    }
                    else
                    {
                        gameBoard[turnIndexX] = "X";
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine("You need to input the number of the space you want to fill!\n");
                }
            }
            // If the turn count is even, it is player O's turn
            else
            {
                try 
                {
                    //Make the second player choose their spot from the board
                    Console.Write("Player O: Choose where to place your O (1-9) \n");
                    int turnLocationO = int.Parse(Console.ReadLine());
                    int turnIndexO = turnLocationO - 1;
                    //Check to see if chosen space has already been taken; then update the gameBoard
                    if (gameBoard[turnIndexO] == "X" || gameBoard[turnIndexO] == "O")
                    {
                        Console.WriteLine("\nThis space has already been taken");
                    }
                    else
                    {
                        gameBoard[turnIndexO] = "O";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You need to input the number of the space you want to fill!\n");
                }




            }

            
            //Print the current gameBoard and call method to check for win
            Support.printBoard(gameBoard);
            if (Support.results(gameBoard) == "X")
            {
                Console.WriteLine("Player X won!");
                stillPlaying = false;
            }
            else if (Support.results(gameBoard) == "O")
            {
                Console.WriteLine("Player O won!");
                stillPlaying = false;
            }
            else if (Support.results(gameBoard) == "T")
            {
                Console.WriteLine("Player X and Player O Tied!");
                stillPlaying = false;
            }
            
            //Increment the turn count
            turnCount++;

        } while (stillPlaying); 
    }
}