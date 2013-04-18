//-----------------------------------------------------------------------
// <copyright file="GameMines.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------

namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Console game Minesweeper
    /// </summary>
    internal class GameMines
    {
        /// <summary>
        /// Contains Playing Rows Length
        /// </summary>
        internal const int FieldRows = 5;

        /// <summary>
        /// Contains Playing Cols Length
        /// </summary>
        internal const int FieldCols = 10;

        /// <summary>
        /// Contains number of mines
        /// </summary>
        internal const int Mines = 15;

        /// <summary>
        /// Contains the maxScore
        /// </summary>
        internal const int MaxScore = 35;

        /// <summary>
        /// Contains the length of the Top Results Kept
        /// </summary>
        internal const int TopResultsToKeep = 6;

        /// <summary>
        /// Create an instance of a randomGenerator,
        /// used for inserting mines on random positions.
        /// Just Code says I need my variable's name to start with small letter,
        /// StyleCop says it needs to start with big letter. As all constants are starting with big letter so is the current.
        /// </summary>
        private static readonly Random RandomNumberGenerator = new Random();

        /// <summary>
        /// Printing the high scores.
        /// </summary>
        /// <param name="scores">uses the high scores list</param>
        internal static void PrintTopScores(List<Score> scores)
        {
            Console.WriteLine();
            Console.WriteLine("High Scores:");

            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, scores[i].PlayerName, scores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Result List!");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints additional information about the game, on the game start
        /// </summary>
        internal static void PrintStartText()
        {
            Console.WriteLine("Let's play \"Minesweeper\".");
            Console.WriteLine("Try your luck finding the fields without mine set on it.");
            Console.WriteLine("The Command \"top\" will show you the Best Scores,");
            Console.WriteLine("\"restart\" will start a new game,");
            Console.WriteLine("and \"exit\" will quit the current game!");
            Console.WriteLine();
        }

        /// <summary>
        /// Prints goodbye message
        /// </summary>
        internal static void PrintInfoText()
        {
            Console.WriteLine("Thank you for playing Minesweeper");
        }

        /// <summary>
        /// Outputs the field to the console
        /// </summary>
        /// <param name="playField">inputs the created playField</param>
        internal static void PrintGameInterface(char[,] playField)
        {
            int rowsCount = playField.GetLength(0);
            int colsCount = playField.GetLength(1);

            StringBuilder colNumbersBuilder = new StringBuilder();
            StringBuilder dashedLineBuilder = new StringBuilder();

            for (int col = 0; col < colsCount; col++)
            {
                colNumbersBuilder.AppendFormat(" {0}", col);

                if (col < 10)
                {
                    dashedLineBuilder.AppendFormat("--");
                }
                else
                {
                    dashedLineBuilder.AppendFormat("---");
                }
            }

            dashedLineBuilder.Append("-");

            Console.WriteLine("\t\t\t{0}", colNumbersBuilder);
            Console.WriteLine("\t\t\t{0}", dashedLineBuilder);

            for (int row = 0; row < rowsCount; row++)
            {
                Console.Write("\t\t     {0} | ", row);

                for (int col = 0; col < colsCount; col++)
                {
                    Console.Write(string.Format("{0} ", playField[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("\t\t\t{0}", dashedLineBuilder);
            Console.WriteLine();
        }

        /// <summary>
        /// Initialize the playing field.
        /// It is two dimensional char array that is being returned.
        /// </summary>
        /// <param name="rows">rows of the created playField</param>
        /// <param name="cols">cols of the created playField</param>
        /// <returns>2D char array - the field is being initialized</returns>
        internal static char[,] CreatePlayField(int rows, int cols)
        {
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        /// <summary>
        /// Initialized the mine field.
        /// It keeps the mines coordinates.
        /// </summary>
        /// <param name="rows">rows of the created mineField</param>
        /// <param name="cols">cols of the created mineField</param>
        /// <param name="mines">mines of the created mineField</param>
        /// <returns>2D char array - the mine field is being initialized</returns>
        internal static char[,] CreateMineField(
        int rows, int cols, int mines)
        {
            char[,] mineField = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    mineField[row, col] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();

            while (randomNumbers.Count < mines)
            {
                int randomNumber = RandomNumberGenerator.Next(rows * cols);

                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int row = number / cols;
                int col = number % cols;
                mineField[row, col] = '*';
            }

            return mineField;
        }

        /// <summary>
        /// Counts the adjacent mines and updates the open cell in mineField and playField
        /// </summary>
        /// <param name="playField">inputs created playField</param>
        /// <param name="mineField">inputs created mineField</param>
        /// <param name="row">current row</param>
        /// <param name="col">current col</param>
        internal static void UpdateFields(char[,] playField, char[,] mineField, int row, int col)
        {
            char adjacentMinesCount = CountAdjacentMines(mineField, row, col);
            mineField[row, col] = adjacentMinesCount;
            playField[row, col] = adjacentMinesCount;
        }

        /// <summary>
        /// Counts adjacent mines
        /// </summary>
        /// <param name="mineField">inputs created mineField</param>
        /// <param name="row">current row</param>
        /// <param name="col">current col</param>
        /// <returns>Adjacent mines</returns>
        internal static char CountAdjacentMines(char[,] mineField, int row, int col)
        {
            int adjacentMines = 0;
            int rows = mineField.GetLength(0);
            int cols = mineField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mineField[row - 1, col] == '*')
                { 
                    adjacentMines++; 
                }
            }

            if (row + 1 < rows)
            {
                if (mineField[row + 1, col] == '*')
                { 
                    adjacentMines++; 
                }
            }

            if (col - 1 >= 0)
            {
                if (mineField[row, col - 1] == '*')
                { 
                    adjacentMines++;
                }
            }

            if (col + 1 < cols)
            {
                if (mineField[row, col + 1] == '*')
                { 
                    adjacentMines++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mineField[row - 1, col - 1] == '*')
                { 
                    adjacentMines++; 
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mineField[row - 1, col + 1] == '*')
                { 
                    adjacentMines++; 
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mineField[row + 1, col - 1] == '*')
                { 
                    adjacentMines++; 
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mineField[row + 1, col + 1] == '*')
                { 
                    adjacentMines++; 
                }
            }

            return char.Parse(adjacentMines.ToString());
        }

        /// <summary>
        /// Standard program entry
        /// </summary>
        internal static void Main()
        {
            char[,] playField = CreatePlayField(FieldRows, FieldCols);
            char[,] mineField = CreateMineField(FieldRows, FieldCols, Mines);

            int row = 0;
            int col = 0;
            int playerScore = 0;
            bool isStarting = true;
            bool isHitMine = false;

            bool isWon = false;
            string command = string.Empty;
            List<Score> bestScores = new List<Score>(TopResultsToKeep);

            do
            {
                if (isStarting)
                {
                    PrintStartText();
                    PrintGameInterface(playField);
                    isStarting = false;
                }

                Console.Write("Please input row and col : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                    row <= playField.GetLength(0) && col <= playField.GetLength(1))
                    {
                        command = "checkField";
                    }
                }

                switch (command)
                {
                    case "top":
                        {
                            PrintTopScores(bestScores);
                            break;
                        }

                    case "restart":
                        {
                            playField = CreatePlayField(FieldRows, FieldCols);
                            mineField = CreateMineField(FieldRows, FieldCols, Mines);
                            PrintGameInterface(playField);
                            isHitMine = false;
                            break;
                        }

                    case "exit":
                        {
                            Console.WriteLine("The end. Bye Bye!");
                            break;
                        }

                    case "checkField":
                        {
                            if (mineField[row, col] != '*')
                            {
                                if (mineField[row, col] == '-')
                                {
                                    UpdateFields(playField, mineField, row, col);
                                    playerScore++;
                                }

                                if (MaxScore == playerScore)
                                {
                                    isWon = true;
                                }
                                else
                                {
                                    PrintGameInterface(playField);
                                }
                            }
                            else
                            {
                                isHitMine = true;
                            }

                            break;
                        }

                    default:
                        {
                            Console.WriteLine(Environment.NewLine +
                            "Error! Invalid Command!" + Environment.NewLine);
                            break;
                        }
                }

                if (isHitMine)
                {
                    PrintGameInterface(mineField);

                    Console.Write(Environment.NewLine + "You just hit mine. Game over! Your Score: {0}", playerScore);
                    Console.WriteLine("Please input your Name: ");

                    string playerName = Console.ReadLine();
                    Score score = new Score(playerName, playerScore);

                    if (bestScores.Count < TopResultsToKeep - 1)
                    {
                        bestScores.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < bestScores.Count; i++)
                        {
                            if (bestScores[i].Points < score.Points)
                            {
                                bestScores.Insert(i, score);
                                bestScores.RemoveAt(bestScores.Count - 1);
                                break;
                            }
                        }
                    }

                    bestScores.Sort((Score r1, Score r2) => r2.PlayerName.CompareTo(r1.PlayerName));
                    bestScores.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    PrintTopScores(bestScores);

                    playField = CreatePlayField(FieldRows, FieldCols);
                    mineField = CreateMineField(FieldRows, FieldCols, Mines);
                    playerScore = 0;
                    isHitMine = false;
                    isStarting = true;
                }

                if (isWon)
                {
                    Console.WriteLine(Environment.NewLine + "Congratulation!You Won!");
                    PrintGameInterface(mineField);

                    Console.WriteLine("Please input your name: ");
                    string playerName = Console.ReadLine();

                    Score currentScore = new Score(playerName, playerScore);
                    bestScores.Add(currentScore);
                    PrintTopScores(bestScores);

                    playField = CreatePlayField(FieldRows, FieldCols);
                    mineField = CreateMineField(FieldRows, FieldCols, Mines);
                    playerScore = 0;
                    isWon = false;
                    isStarting = true;
                }
            }
            while (command != "exit");
            PrintInfoText();
            Console.Read();
        }
    }
}
