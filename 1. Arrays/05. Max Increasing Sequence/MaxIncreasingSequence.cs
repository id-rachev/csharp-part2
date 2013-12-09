using System;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main()
    {
        // Write a program that finds the maximal
        //increasing sequence in an array. 

        Console.Write("Enter length of the array (int): ");
        int lengthArr = int.Parse(Console.ReadLine());

        int[] userArray = new int[lengthArr];
        int sequenceLength = 1;
        int sequenceMaxLength = new int();
        int sequenceEndIndex = new int();

        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            Console.Write("Enter next array element: ");
            userArray[indexArr] = int.Parse(Console.ReadLine());

            if ((indexArr != 0) && (userArray[indexArr] > userArray[indexArr - 1]))
            {
                sequenceLength++;
            }
            else if ((indexArr != 0) && (userArray[indexArr] <= userArray[indexArr - 1]))
            {
                sequenceLength = 1;
            } 
            if (sequenceLength > sequenceMaxLength)
            {
                sequenceMaxLength = sequenceLength;
                sequenceEndIndex = indexArr + 1;
            }
        }

        Console.Write("The maximal increasing sequence is: ");
        for (int indexArr = sequenceEndIndex - sequenceMaxLength; indexArr < sequenceEndIndex; indexArr++)
        {
            Console.Write(userArray[indexArr] + " ");
        }
        Console.WriteLine("with {0} elements in length!", sequenceMaxLength);
    }
}