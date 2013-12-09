using System;
using System.Linq;

class MaxSumSequence
{
    static void Main()
    {
        //Write a program that finds the sequence of maximal sum in given array.
        //Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
        //Can you do it with only one loop (with single scan through the elements of the array)?


        Console.Write("Enter one integer number (the array length): ");
        int lengthArr = int.Parse(Console.ReadLine());

        int[] userArray = new int[lengthArr];
        int currentSum = new int();
        int maxSum = int.MinValue;
        int lastIndexSum = new int();
        int firstIndexSum = new int();

        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            Console.Write("Enter the array element at index {0}: ", indexArr);
            userArray[indexArr] = int.Parse(Console.ReadLine());

            currentSum += userArray[indexArr];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                lastIndexSum = indexArr;

            }

            if (currentSum < userArray[indexArr])
            {
                currentSum = userArray[indexArr];
                firstIndexSum = indexArr;
            }
        }

        Console.WriteLine("firstIndexSum = {0}, lastIndexSum = {1}, maxSum = {2}", firstIndexSum, lastIndexSum, maxSum);
        Console.Write("The sequence of maximal sum is: ");

        for (int indexSequence = firstIndexSum; indexSequence <= lastIndexSum; indexSequence++)
        {
            Console.Write(userArray[indexSequence] + " ");
        }
        Console.WriteLine();
    }
}