using System;
using System.Linq;

class SearchToKinArrayOfN
{
    // Write a program, that reads from the console an array of N
    // integers and an integer K, sorts the array and using the method
    // Array.BinSearch() finds the largest number in the array which is ≤ K. 

    static void Main()
    {
        Console.Write("Enter length of the array, N = ");
        int arrayLengthN = int.Parse(Console.ReadLine());

        int[] userArray = new int[arrayLengthN];

        for (int index = 0; index < arrayLengthN; index++)
        {
            Console.Write("Enter next array element (int): ");
            userArray[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter an integer K: ");
        int compareK = int.Parse(Console.ReadLine());

        Array.Sort(userArray);

        int searchNum = Array.BinarySearch(userArray, compareK);
        
        if (searchNum < -1)
        {
            Console.WriteLine("The wanted number <= K is: {0}.", userArray[~searchNum - 1]);
        }
        else if (~searchNum == 0)
        {
            Console.WriteLine("There is no such a number <= K (K = {0})", compareK);
        }
        else
        {
            Console.WriteLine("The wanted number <= K is: {1}.", userArray[searchNum]);
        }

    }
}
