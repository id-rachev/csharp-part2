using System;
using System.Linq;

class FindSequenceOfSum
{
    // Write a program that finds in given array of integers
    // a sequence of given sum S (if present).

    static void Main()
    {
        int[] userArray = { 4, 3, 1, 4, 2, 5, 8 };
        int sum = 11;
        int counterSum;
        int startIndex = new int();
        int endIndex = new int();

        for (int index = 0; index < userArray.Length; index++)
        {
            counterSum = 0;
            for (int nextIndex = index; nextIndex < userArray.Length; nextIndex++)
            {
                if (counterSum < sum)
                {
                    counterSum = counterSum + userArray[nextIndex];
                }
                else if (counterSum == sum)
                {
                    startIndex = index;
                    endIndex = nextIndex - 1;
                    counterSum = 0;
                }
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i < endIndex)
            {
                Console.Write("{0} + ", userArray[i]);                
            }
            else // i == endIndex
            {
                Console.Write("{0} = ", userArray[i]);                                
            }
        }
        Console.WriteLine("{0}", sum);
    }
}
