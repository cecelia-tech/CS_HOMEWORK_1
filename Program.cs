using System;
using System.Text;
using CS_HOMEWORK_1;
using CS_Homework_2;

namespace CS_Homework_1
{
    using CS_HOMEWORK_2;

    class Program1
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter first integer: ");
            //int countFrom = int.Parse(Console.ReadLine());
            //Console.Write("Enter second integer: ");
            //int countTo = int.Parse(Console.ReadLine());

            //TernaryConvertor ternaryConvertor = new TernaryConvertor();

            ////ternaryConvertor.CheckForAppropriateInteger(countFrom, countTo);

            //Console.WriteLine("Test");
            //Console.WriteLine(ternaryConvertor.CheckForZeroBeforeConverting(-11));

            //int n = -8;
            //Nonesence nonesence = new Nonesence();
            //nonesence.Convert(n);

            //Console.WriteLine("Enter 9 integer digits: ");
            //string numbersArray = Console.ReadLine();

            //ISBN isbn = new ISBN();
            //isbn.IsbnNumericCode(numbersArray);

            //Console.WriteLine("Enter at least two integer digits separated by comma: ");
            //string userInputNumbers = Console.ReadLine();

            //SumOfArray sumOfArray = new SumOfArray();
            //Console.WriteLine(userInputNumbers);
            //Console.WriteLine(sumOfArray.PrintSumOfRequiredNumbers(userInputNumbers));
            //sumOfArray.StringToInt(userInputNumbers);

            /////////////////////////////////////////////**************************

            int[] numbersArray = { 1, 2, 3, 4, 5 };

            int[] numbersArray2 = { 11, 22, 33 };

            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(numbersArray);

            Console.WriteLine("ToString method: ");
            Console.WriteLine(diagonalMatrix.ToString());
            Console.WriteLine("----------------");

            DiagonalMatrix diagonalMatrix2 = new DiagonalMatrix(numbersArray2);

            Console.WriteLine("Checking the Add method");
            var addedMatrices = diagonalMatrix2.Add(diagonalMatrix);

            Console.WriteLine(addedMatrices.ToString());
            Console.WriteLine("----------------");

            Console.WriteLine("Equals method: ");
            Console.WriteLine(diagonalMatrix2.Equals(diagonalMatrix));
            Console.WriteLine("----------------");

            Console.WriteLine("Indexer check: ");
            Console.WriteLine(diagonalMatrix2[0, 0]);
            Console.WriteLine(diagonalMatrix2[0, 7]);
            diagonalMatrix2[0, 0] = 44;
            Console.WriteLine(diagonalMatrix2[0, 0]);
            Console.WriteLine("----------------");

            Console.WriteLine(diagonalMatrix.Size);
            Console.WriteLine(diagonalMatrix2.Track());

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
