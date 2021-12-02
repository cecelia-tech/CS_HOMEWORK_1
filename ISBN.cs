using System;
namespace CS_Homework_2
{
    public class ISBN
    {
        public ISBN()
        {
        }

        public int[] ArrayOfIntegers(string numbersInString)
        {
            int[] arrayOfNum = new int[9];

            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                arrayOfNum[i] = numbersInString[i];
            }
            return arrayOfNum;
        }

        public int MultiplicationOfNumbers(int[] arrayOfNumbers)
        {
            int sumOfMultipliedNumbers = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int count = 10;
                sumOfMultipliedNumbers += arrayOfNumbers[i] * count;
            }

            return sumOfMultipliedNumbers;

        }

        public string CheckDigit(int sumOfMultipliedNumbers)
        {
            int remainder = sumOfMultipliedNumbers % 11;

            if (remainder == 10)
            {
                return "X";
            }
            else
            {
                return (11 - remainder).ToString();
            }
        }

        public string isbnString(string clientInput)
        {
            string finalIsbnString = "ISBN ";

            for (int i = 0; i < clientInput.Length; i++)
            {
                if (i == 0 || i == 6 || i == 8)
                {
                    finalIsbnString += i + "-";
                }
                else
                {
                    finalIsbnString += i;
                }
            }

            return finalIsbnString;
        }

        public void Print(string array)
        {

        }
    }
}

