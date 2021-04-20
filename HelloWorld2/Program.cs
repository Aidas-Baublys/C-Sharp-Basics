using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 player tic tac toe game, no AI.

            int move;
            int turn = 0;
            bool player1Move = true;
            bool gameIsOn = true;
            // Galima naudoti char array, mažiau atminties reikia.
            string[] ticTacToeGrid = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            DrawGrid(ticTacToeGrid);

            while (gameIsOn)
            {
                Console.WriteLine("To make a move type an empty square number from 1 to 9.");

                string whoseTurn = player1Move ? "Player 1 turn: " : "Player 2 turn: ";

                Console.Write(whoseTurn);

                move = CheckMove(ticTacToeGrid);

                MakeMove(ticTacToeGrid, move, ref turn, ref player1Move);

                turn++;

                DrawGrid(ticTacToeGrid);
                CheckWinner(ref ticTacToeGrid, ref player1Move, ref gameIsOn, ref turn);
                CheckDraw(ref ticTacToeGrid, ref player1Move, ref gameIsOn, ref turn);
            }

            Console.Read();
        }

        static void DrawGrid(string[] grid)
        {
            Console.Clear();
            Console.WriteLine("-------------");

            for (int i = 0; i < grid.Length; i++)
            {
                Console.Write($"| {grid[i]} ");

                if ((i + 1) % 3 == 0)
                {
                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                }
            }
        }

        static int CheckMove(string[] grid)
        {
            string playerMove = Console.ReadLine();
            bool validMove = int.TryParse(playerMove, out int move) && grid.Contains(playerMove);

            while (!validMove)
            {
                Console.WriteLine("Invalid move, try again.");
                playerMove = Console.ReadLine();
                validMove = int.TryParse(playerMove, out move) && grid.Contains(playerMove);
            }

            return move;
        }

        static void MakeMove(string[] grid, int move, ref int turn, ref bool player1Move)
        {
            if (player1Move)
            {
                grid[move - 1] = "X";
                player1Move = false;
            }
            else
            {
                grid[move - 1] = "O";
                player1Move = true;
            }

            //turn++;
        }

        static void CheckWinner(ref string[] grid, ref bool player1Move, ref bool gameIsOn, ref int turn)
        {
            // Galima padaryti su foreach atskiriems char arba string.
            bool row1 = grid[0] == "X" && grid[1] == "X" && grid[2] == "X" || grid[0] == "O" && grid[1] == "O" && grid[2] == "O";
            bool row2 = grid[3] == "X" && grid[4] == "X" && grid[5] == "X" || grid[3] == "O" && grid[4] == "O" && grid[5] == "O";
            bool row3 = grid[6] == "X" && grid[7] == "X" && grid[8] == "X" || grid[6] == "O" && grid[7] == "O" && grid[8] == "O";

            bool col1 = grid[0] == "X" && grid[3] == "X" && grid[6] == "X" || grid[0] == "O" && grid[3] == "O" && grid[6] == "O";
            bool col2 = grid[1] == "X" && grid[4] == "X" && grid[7] == "X" || grid[1] == "O" && grid[4] == "O" && grid[7] == "O";
            bool col3 = grid[2] == "X" && grid[5] == "X" && grid[8] == "X" || grid[2] == "O" && grid[5] == "O" && grid[8] == "O";

            bool diagonal1 = grid[0] == "X" && grid[4] == "X" && grid[8] == "X" || grid[0] == "O" && grid[4] == "O" && grid[8] == "O";
            bool diagonal2 = grid[6] == "X" && grid[4] == "X" && grid[2] == "X" || grid[6] == "O" && grid[4] == "O" && grid[2] == "O";

            if (row1 || row2 || row3 || col1 || col2 || col3 || diagonal1 || diagonal2)
            {
                string winner = !player1Move ? "Player 1 WINS!!!" : "Player 2 WINS!!!";
                Console.WriteLine(winner);
                Replay(ref grid, ref player1Move, ref gameIsOn, ref turn);
            }
        }

        static void CheckDraw(ref string[] grid, ref bool player1Move, ref bool gameIsOn, ref int turn)
        {
            if (turn == 9 && gameIsOn)
            {
                Console.WriteLine("It's a draw.");
                Replay(ref grid, ref player1Move, ref gameIsOn, ref turn);
            }
        }

        static void Replay(ref string[] grid, ref bool player1Move, ref bool gameIsOn, ref int turn)
        {
            Console.WriteLine("For rematch enter 1, to exit press ENTER two times.");
            gameIsOn = Console.ReadLine() == "1";

            if (gameIsOn)
            {
                // Galima sukurti atskira initialGrid array ir resetint su juo.
                for (int i = 0; i < grid.Length; i++)
                {
                    grid[i] = (i + 1).ToString();
                }

                turn = 0;
                player1Move = true;
                DrawGrid(grid);
            }
        }
    }
}
