using System;

namespace Tic_Tac_Toe
{
   public class Program
    {
       public static void Main(string[] args)
        {
            char[] arr = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        }
        public static void Player()
        {
            int player = int.Parse(Console.ReadLine());
            if (player%2==0)
            {
                Console.WriteLine("Player Chance");
            }
            else
            {
                Console.WriteLine("Computer Chance.");
            }
            static void Board()
            {
                Console.WriteLine("  |  |  ");
                Console.WriteLine(" {0} | {1} | {2}");
                Console.WriteLine("__|__|__");
                Console.WriteLine(" {0} | {1} | {2}");
                Console.WriteLine("__|__|__");
                Console.WriteLine(" {0} | {1} | {2}");
                Console.WriteLine("  |  |  ");
            }
        }
    }
}
