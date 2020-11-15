using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetNumber();
            int m = GetNumber();

            int result = Pow2(n) + Pow2(m);
            Console.WriteLine(result);
        }

        static int GetNumber()
        {
            int number;
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number < 0)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Ошибка"); Environment.Exit(0);
            }

            return number;
        }

        static int Pow2(int num)
        {
            return (int)Math.Pow(2, num);
        }
    }
}
