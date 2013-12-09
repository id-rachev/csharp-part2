using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter length of the array (int): ");
        int lengthArr = int.Parse(Console.ReadLine());
        int[] userArray = new int[lengthArr];

        int findedNumber = new int();
        int equalsCounter = new int();
        int equalNumbers = 1;

        for (int i = 0; i < lengthArr; i++)
        {
            Console.Write("Enter next array element: ");
            userArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(userArray);

        for (int index = 0; index < lengthArr - 1; index++)
        {
            if (userArray[index] == userArray[index + 1])
            {
                equalNumbers++;
                if (equalNumbers > equalsCounter)
                {
                    equalsCounter = equalNumbers;
                    findedNumber = index;
                }
            }
            else
            {
                equalNumbers = 1;
            }
        }

        Console.WriteLine(
            "The most frequent number is {0},\nWith {1} positions in the array",
            userArray[findedNumber], equalsCounter);
    }
}
