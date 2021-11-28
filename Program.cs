using System;

namespace CS_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Enter second integer: ");
            string secondNumber = Console.ReadLine();
            //Console.WriteLine($"{firstNumber}, {secondNumber}");
            //Console.WriteLine(firstNumber, secondNumber);

            int nuo = int.Parse(firstNumber);
            int iki = int.Parse(secondNumber);
            //string atsakymas = ConvertToTernary(nuo);
            //Console.WriteLine(ConvertToTernary(nuo));
            //Console.WriteLine(CheckForTwo(atsakymas));
            Console.WriteLine("Prasideda rasymas");
            RangeGiven(nuo, iki);

        }

        public static string ConvertToTernary (int nuo)
        {
            string atsakymas = string.Empty;

            int dalinys = nuo / 3;
            //Console.WriteLine(dalinys);
            int liekana = nuo % 3;
            atsakymas = liekana + atsakymas;

            if (dalinys >= 3)
            {
                atsakymas = ConvertToTernary(dalinys) + atsakymas;
            }
            else
            {
                atsakymas = 1 + atsakymas;
            }

            return atsakymas;
        }
        
        public static bool CheckForTwo(string atsakymas)
        {
            int count = 0;
            for (int i = 0; i < atsakymas.Length; i++)
            {
                if (atsakymas[i] == '2')
                {
                    count++;
                }
            }

            return count == 2;
        }

        public static void RangeGiven(int nuo, int iki)
        {
            for (int i = nuo; i <= iki; i++)
            {
                if (CheckForTwo(ConvertToTernary(i)))
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
