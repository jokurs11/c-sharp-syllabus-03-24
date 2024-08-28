using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            var haveWinner = false;
            var player = 'x';
            while (!haveWinner)
            {
                Console.WriteLine($"player {player} move.");
                Console.WriteLine("Input where you want to place x in \"X X\" format");
                var userInput = Console.ReadLine();
                var coordinates = userInput.Split(" ");

                if (!int.TryParse(coordinates[0], out var x) || !int.TryParse(coordinates[1], out var y) ||
                    x < 0 || x > 2 || y < 0 || y > 2 || _board[x, y] != ' ')
                {
                    Console.WriteLine("Invalid input. Please enter valid coordinates.");
                    continue;
                }
                _board[x, y] = player;
                DisplayBoard();
                haveWinner = CheckWinner();

                if (haveWinner)
                {
                    Console.WriteLine($"Player {player} wins!");
                    break;
                }
                player = player == 'x' ? 'o' : 'x';
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static bool CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_board[i, 0] == _board[i, 1] && _board[i, 1] == _board[i, 2] && _board[i, 0] != ' ')
                {
                    return true;
                }
                if (_board[0, i] == _board[1, i] && _board[1, i] == _board[2, i] && _board[0, i] != ' ')
                {
                    return true;
                }
                if (_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2] && _board[0, 0] != ' ')
                {
                    return true;
                }
                if (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0] && _board[0, 2] != ' ')
                {
                    return true;
                }
            }
            return false;
        }
    }
}