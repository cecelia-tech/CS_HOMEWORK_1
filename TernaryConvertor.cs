using System;
using System.Text;

namespace CS_HOMEWORK_1
{
    public class TernaryConvertor
    {
        //Method checks for numbers satisfying the task in the range given
        public void CheckForAppropriateInteger(int nuo, int iki)
        {
            for (int i = nuo; i <= iki; i++)
            {
                if (CheckForTwos(CheckForZeroAndNegativesBeforeConverting(i)))
                {
                    Console.WriteLine(i);
                }
            }
        }

        //checks how many number 2 has the string and returns true if it has two 2s
        public bool CheckForTwos(StringBuilder ternaryString)
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

        public StringBuilder CheckForZeroAndNegativesBeforeConverting(int number)
        {
            StringBuilder answer = new StringBuilder();

            if (number > 0)
            {
                return answer = ConvertToTernary(number);
            }
            else if (number == 0)
            {
                return answer.Append('0');
            }
            else
            {
                return answer.Append("Cannot convert negative digit");
            }
        }

        //This method converts given number  to ternary number system and returns
        //it as a string
        public StringBuilder ConvertToTernary(int number)
        {
            StringBuilder ternaryString = new StringBuilder();

            if (number == 0)
            {
                return ternaryString;
            }

            int quotient = number / 3;
            int remainder = number % 3;

            ternaryString = ConvertToTernary(quotient);
            
            ternaryString.Append(remainder);

            return ternaryString;
        }
    }
}
