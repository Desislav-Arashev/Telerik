using System;
using System.Collections.Generic;
using Minesweeper.Models;

namespace Minesweeper
{
    public class Mines
    {
        public static void Main(string[] args)
        {
            const int MaxFieldsWithoutMines = 35;
            int row = 0;
            int col = 0;
            int pointCounter = 0;
            string command = string.Empty;
            char[,] playField = CreateGamingField();
            char[,] mines = PutMines();
            bool isOnMines = false;
            bool isStartGame = true;
            bool isEndGame = false;
            List<Score> bestPlayersScore = new List<Score>(6);

            do
            {
                if (isStartGame)
                {
                    Console.WriteLine("Let's play 'Minesweepers'. Try stepping only on the mine-free fields. " +
                    "Command 'top' shows the highscores, 'restart' starts a new game, 'exit' quits the game!");
                    PrintPlayField(playField);
                    isStartGame = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row < playField.GetLength(0) && col < playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowBestResults(bestPlayersScore);
                        break;
                    case "restart":
                        playField = CreateGamingField();
                        mines = PutMines();
                        PrintPlayField(playField);
                        isOnMines = false;
                        isStartGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                ItsYourTurn(playField, mines, row, col);
                                pointCounter++;
                            }

                            if (MaxFieldsWithoutMines == pointCounter)
                            {
                                isEndGame = true;
                            }
                            else
                            {
                                PrintPlayField(playField);
                            }
                        }
                        else
                        {
                            isOnMines = true;
                        }

                        break;
                    default:
                        Console.WriteLine("{0}Error: Invalid Command{0}", Environment.NewLine);
                        break;
                }

                if (isOnMines)
                {
                    PrintPlayField(mines);
                    Console.Write("{1}You died with score {0} points. Enter your name:  ", pointCounter, Environment.NewLine);
                    string nickname = Console.ReadLine();
                    Score playerScore = new Score(nickname, pointCounter);
                    if (bestPlayersScore.Count < 5)
                    {
                        bestPlayersScore.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < bestPlayersScore.Count; i++)
                        {
                            if (bestPlayersScore[i].Points < playerScore.Points)
                            {
                                bestPlayersScore.Insert(i, playerScore);
                                bestPlayersScore.RemoveAt(bestPlayersScore.Count - 1);
                                break;
                            }
                        }
                    }

                    bestPlayersScore.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    bestPlayersScore.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    playField = CreateGamingField();
                    mines = PutMines();
                    pointCounter = 0;
                    isOnMines = false;
                    isStartGame = true;
                }

                if (isEndGame)
                {
                    Console.WriteLine("{0}Congratuations! You win and you have opened all {1} fields unharmed!!!", Environment.NewLine, MaxFieldsWithoutMines);
                    PrintPlayField(mines);
                    Console.WriteLine("Enter your name: ");
                    string playerName = Console.ReadLine();
                    Score playerScore = new Score(playerName, pointCounter);
                    bestPlayersScore.Add(playerScore);
                    ShowBestResults(bestPlayersScore);
                    playField = CreateGamingField();
                    mines = PutMines();
                    pointCounter = 0;
                    isEndGame = false;
                    isStartGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

        private static void ShowBestResults(List<Score> points)
        {
            Console.WriteLine("{0}Score:", Environment.NewLine);
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} fields opened", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscore{0}", Environment.NewLine);
            }
        }

        private static void ItsYourTurn(char[,] playfield, char[,] bombs, int row, int col)
        {
            char currBombs = Curr(bombs, row, col);
            bombs[row, col] = currBombs;
            playfield[row, col] = currBombs;
        }

        private static void PrintPlayField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGamingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] playField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int turn = mine % cols;
                if (turn == 0 && mine != 0)
                {
                    col--;
                    turn = cols;
                }
                else
                {
                    turn++;
                }

                playField[col, turn - 1] = '*';
            }

            return playField;
        }

        private static void Аccounts(char[,] playField)
        {
            int col = playField.GetLength(0);
            int row = playField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playField[i, j] != '*')
                    {
                        char minesCounter = Curr(playField, i, j);
                        playField[i, j] = minesCounter;
                    }
                }
            }
        }

        private static char Curr(char[,] playfield, int row, int col)
        {
            int count = 0;
            int rows = playfield.GetLength(0);
            int cols = playfield.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playfield[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (playfield[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playfield[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (playfield[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playfield[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playfield[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playfield[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playfield[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
