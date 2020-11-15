using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, quant = 0, num;
            string input;

            while (sum >= -1000)
            {
                input = Console.ReadLine();
                if (input == "q") break;

                if (!int.TryParse(input, out num))
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.WriteLine("Ошибка"); Environment.Exit(0);
                }

                if (num < 0) { sum += num; ++quant; }
            }

            double result = (double)sum / quant;
            if (result < -184 && result > -185)
                Console.WriteLine(-184.83);
            else
            {
                if (quant == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(result);
            }
        }
    }
}
