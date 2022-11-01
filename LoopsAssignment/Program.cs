using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopsAssignment
{
    internal class Program
    {
        static bool gameOver;
        static string player;
        static ConsoleKeyInfo input;
        static int x, y; // position on the X and Y axis
        static int bufferX, bufferY; // starts player away from edges of screen

        static void Main(string[] args)
        {
            gameOver = false;
            player = "#";
            x = 0;
            y = 0;
            bufferX = 10;
            bufferY = 10;

            Console.WriteLine("Press 'W' to move up, 'A' to move left, 'S' to move down, or 'D' to move right. Press 'ESC' to Quit.");

            while (gameOver == false)
            {
                Thread.Sleep(500);
                PlayerUpdate();
                PlayerDraw(player, x, y);
            }
        }
        static void PlayerDraw(string s, int x, int y)
        {
            Console.SetCursorPosition(bufferX + x,bufferY + y);
            Console.Write(s);
        }
        static void PlayerUpdate()
        {
            input = Console.ReadKey();
            switch(input.Key)
            {
                case ConsoleKey.W:
                    y--;
                    Console.Clear();
                    break;
                case ConsoleKey.S:
                    y++;
                    Console.Clear();
                    break;
                case ConsoleKey.D:
                    x++;
                    Console.Clear();
                    break;
                case ConsoleKey.A:
                    x--;
                    Console.Clear();
                    break;
                case ConsoleKey.Escape:
                    gameOver = true;
                    break;
            }
        }
    }
}
