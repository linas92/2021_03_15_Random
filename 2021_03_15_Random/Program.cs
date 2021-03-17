using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021_03_15_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rng = new Random();

            int aRandomNumber = Rng.Next();
            int aRandomNumber1 = Rng.Next(4);
            int aRandomNumber2 = Rng.Next(1,4);

            var bRandomSkaicius = Rng.NextDouble();

            Metodas(Rng);

            Console.WriteLine("END OF THE LINE BUDDY");
            Console.ReadKey();
        }
        public static int Metodas(Random rnd)
        {
            return rnd.Next(1,10);
        }
    }
}