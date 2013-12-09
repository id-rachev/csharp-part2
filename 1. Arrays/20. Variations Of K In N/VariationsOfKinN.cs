using System;
using System.Linq;

class VariationsOfKinN
{
    // Write a program that reads two numbers N and K and generates
    // all the variations of K elements from the set [1..N].

    static int biggestNumberN;
    static int numberOfElementsK;
    static int[] variationsArr;

    static void VariationsGenerator(int currentIndex)
    {
        if (currentIndex == numberOfElementsK)
        {
            for (int i = 0; i < numberOfElementsK; i++)
            {
                Console.Write("{0} ", variationsArr[i]);
            }
            Console.WriteLine();
            return;
        }

        for (int counter = 1; counter <= biggestNumberN; counter++)
        {
            variationsArr[currentIndex] = counter;
            VariationsGenerator(currentIndex + 1);
        }
    }

    static void Main()
    {
        Console.Write("Enter the bigest integer in variations set, N = ");
        biggestNumberN = int.Parse(Console.ReadLine());

        Console.Write(
            "Enter the number of elements in variations: K (K <= N), K = ");
        numberOfElementsK = int.Parse(Console.ReadLine());

        variationsArr = new int[numberOfElementsK];

        VariationsGenerator(0);
    }


}

