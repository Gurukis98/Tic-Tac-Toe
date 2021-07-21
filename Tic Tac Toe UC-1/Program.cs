using System;

namespace Tic_Tac_Toe_UC_1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            char[] arr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        }
        public static void UC2()
        {
            int player = int.Parse(Console.ReadLine());
            if (player%2==0)
            {
                Console.WriteLine("Player Chance");
            }
            else
            {
                Console.WriteLine("Computer Chance");
            }
        }
    }
}
