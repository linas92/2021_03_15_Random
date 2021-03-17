using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kauliukas();
            Console.WriteLine($"Dice game! If you roll 1, you get another try, if you roll 2 or 4, you lose!\n The only way you win is by rolling 5 or 6.\n Best of luck you you\n + {Dice}");
        }
        public static void Kauliukas()
        {
            var Dice = new Random();
            int DiceRoll = Dice.Next(1, 6);
            if (DiceRoll == 1)
            {
                Dice.Next(1, 6);
                Console.WriteLine("BAM! SHALAKAZAM! YOU GET ANOTHER TRY!");
            }
            if (DiceRoll == 2 && DiceRoll == 3 && DiceRoll == 4)
            {
                Console.WriteLine("Try again!");
            }
            if (DiceRoll == 5 && DiceRoll == 6)
            {
                Console.WriteLine("You won!");
            }
        }
    }
}