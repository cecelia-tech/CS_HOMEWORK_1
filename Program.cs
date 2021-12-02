using System;
using System.Text;
using CS_HOMEWORK_1;

namespace CS_Homework_1
{
    class Program1
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first integer: ");
            int countFrom = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int countTo = int.Parse(Console.ReadLine());

            TernaryConvertor ternaryConvertor = new TernaryConvertor();

            ternaryConvertor.CheckForAppropriateInteger(countFrom, countTo);

            Console.WriteLine("Test");
            Console.WriteLine(ternaryConvertor.ConvertToTernary(47));



            Console.WriteLine("Enter 9 integer digits: ");
            string numbersArray = Console.ReadLine();

        }
/*
        //This methos converts given number  to ternary number system and returns
        //it as a string

        public static StringBuilder ConvertToTernary (int number)
        {
            StringBuilder ternaryString = new StringBuilder();

            //since ternary base is 3, it is okay to hardcode it

            int dalinys = number / 3;
            int remainder = number % 3;

            //the ternaryString is made by adding each number to the front of
            //the array

            ternaryString.Insert(0, remainder);

            if (dalinys >= 3)
            {
                ternaryString.Insert(0, ConvertToTernary(dalinys));
            }
            else
            {
                //ternary number system first number always is 1

                ternaryString.Insert(0, 1);
            }

            return ternaryString;
        }

        //checks how many number 2 has the string and returns true if it has two 2s

        public static bool CheckForTwos(StringBuilder ternaryString)
        {
            int numberOf2InString = 0;

            for (int i = 0; i < ternaryString.Length; i++)
            {
                if (ternaryString[i] == '2')
                {
                    numberOf2InString++;
                }
            }

            return numberOf2InString == 2;
        }

        //Method checks for numbers satisfying the task in the range given

        public static void CheckForAppropriateInteger(int nuo, int iki)
        {
            for (int i = nuo; i <= iki; i++)
            {
                if (CheckForTwos(ConvertToTernary(i)))
                {
                    NumberPrint(i);
                }
            }
        }

        public static void NumberPrint(int number)
        {
            Console.WriteLine(number);
       */ 
    }
}
