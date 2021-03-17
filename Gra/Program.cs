using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dowolną liczbę: ");
            var Number = GetNumber();

            var Score = new FizzBuzz();
            Console.WriteLine(Score.Play(Number));
        }

        private static int GetNumber()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int Number))
                {
                    Console.WriteLine("Podana liczba jest nieprawidłowa. Spróbuj ponownie: ");
                    continue;
                }
                return Number;
            }
        }
    }
}
