using System;
namespace CS_HOMEWORK_1
{
    public class SumOfArray
    {
        //public SumOfArray()
        //{
        //}

        public int[] StringToInt(string userInpput)
        {
            int[] userInputNumbers = new int[userInpput.Length];
            //userInputNumbers = int.Parse(userInpput);
            for (int i = 0; i < userInputNumbers.Length; i++)
            {
                if (userInpput[i] == '-')
                {
                    userInputNumbers[i] = (int)Char.GetNumericValue(userInpput[i]);
                }
                userInputNumbers[i] = (int)Char.GetNumericValue(userInpput[i]);
                //userInputNumbers[i] = int.Parse(userInpput[i]);
            }

            return userInputNumbers;
        }

        public int MaxValueIndex(int[] userInputNumbers)
        {

            int maxValueIndex = 0;

            for (int i = 1; i < userInputNumbers.Length; i++)
            {
                if (userInputNumbers[maxValueIndex] > userInputNumbers[i])
                {
                    maxValueIndex = i;
                }
            }
            return maxValueIndex;
        }

        public int MinValueIndex(int[] userInputNumbers)
        {
            int minValueIndex = 0;

            for (int i = 1; i < userInputNumbers.Length; i++)
            {
                if (userInputNumbers[minValueIndex] < userInputNumbers[i])
                {
                    minValueIndex = i;
                }
            }
            return minValueIndex;
        }

        public int SumOfRequaredNumbers(string userInputNumbers)
        {
            int[] convertedNumbers = StringToInt(userInputNumbers);
            int minIndex = MinValueIndex(convertedNumbers);
            int maxIndex = MaxValueIndex(convertedNumbers);
            int sumOfRequaredNumbers = 0;

            if (minIndex < maxIndex)
            {
                for (int i = minIndex; i <= maxIndex; i++)
                {
                    sumOfRequaredNumbers += convertedNumbers[i];
                }
            }
            else
            {
                for (int i = maxIndex; i <= minIndex; i++)
                {
                    sumOfRequaredNumbers += convertedNumbers[i];
                }
            }

            return sumOfRequaredNumbers;
        }

        //public void Print(int[] userInputNumbers, int sumOfRequaredNumbers)
        //{
        //    Console.WriteLine(userInputNumbers);
        //    Console.WriteLine(sumOfRequaredNumbers);
        //}
    }
}
