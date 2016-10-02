using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pra_tic_tak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] grid = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool gameOver = false;
            bool playing = false;
            Console.WriteLine("Lets Play Tic Tac Toe!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Player 1 is X");
            Console.WriteLine("Player 2 is O");

            while (!gameOver)
            {
                Board(grid);
                while (!playing)
                {
                   playing = Player1(grid);
                    Tie(grid);
                    if (gameOver = Winner(grid) || Tie(grid))
                    {
                        break;
                    }
                    Board(grid);
                   playing = Player2(grid);
                    Tie(grid);
                    if (gameOver = Winner(grid) || Tie(grid))
                    {
                        break;
                    }
                    Board(grid);
                }
            }
            Console.ReadLine();
        }

        static void Board(string[] table)
        {
            Console.WriteLine(string.Format("{0} | {1} | {2}", table[0], table[1], table[2]));
            Console.WriteLine("_________");
            Console.WriteLine(string.Format("{0} | {1} | {2}", table[3], table[4], table[5]));
            Console.WriteLine("_________");
            Console.WriteLine(string.Format("{0} | {1} | {2}", table[6], table[7], table[8]));
        }

        static bool Player1(string[] p1)
        {
            Console.WriteLine("Player 1 pick spot");
            int intAnswer;
            string answer = Console.ReadLine();
            intAnswer = Convert.ToInt32(answer);
            while (p1[intAnswer] == "X" || p1[intAnswer] == "O")
            {
                Console.WriteLine("Spot Taken");
                answer = Console.ReadLine();
                intAnswer = Convert.ToInt32(answer);
            }

            p1[intAnswer] = "X";
            Console.Clear();
            return false;
        }

        static bool Player2(string[] p2)
        {
            Console.WriteLine("Player 2 Pick Spot");
            int intAnswer;
            string answer = Console.ReadLine();
            intAnswer = Convert.ToInt32(answer);
            while (p2[intAnswer] == "X" || p2[intAnswer] == "O")
            {
                Console.WriteLine("Spot Taken");
                answer = Console.ReadLine();
                intAnswer = Convert.ToInt32(answer);
            }
            p2[intAnswer] = "0";
            Console.Clear();
            return false;
        }

        static bool Winner(string[] check)
        {
            if (check[0] == check[1] && check[1] == check[2])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[3] == check[4] && check[4] == check[5])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[6] == check[7] && check[7] == check[8])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[0] == check[3] && check[3] == check[6])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[1] == check[4] && check[4] == check[7])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[2] == check[5] && check[5] == check[8])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[0] == check[4] && check[4] == check[8])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            else if (check[2] == check[4] && check[4] == check[6])
            {
                Console.WriteLine("WINNER");
                return true;
            }
            return false;
        }

        static bool Tie(string[] nw)
        {
            for (int i = 0; i < nw.Length; i++)
            {
                if (nw[i] != "X" && nw[i] != "O")
                {
                    return false;
                }
            }
            Console.WriteLine("Tie Game");
            return true;

        }
    }

}
