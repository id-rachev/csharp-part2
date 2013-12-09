using System;
using System.Linq;

class SortingAnArray
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order.
        //Write a program to sort an array. Use the "selection sort" algorithm:
        //Find the smallest element, move it at the first position, find
        //the smallest from the rest, move it at the second position, etc.
        
        Console.Write("Enter one integer number (the array length): ");
        int lengthArr = int.Parse(Console.ReadLine());

        int[] userArray = new int[lengthArr];
        int minValue = new int();
        int tempVar = new int();

        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            Console.Write("Enter next array element: ");
            userArray[indexArr] = int.Parse(Console.ReadLine());
        }

        for (int indexPrev = 0; indexPrev < lengthArr - 1; indexPrev++)
        {
            minValue = indexPrev;

            for (int indexNext = indexPrev + 1; indexNext < lengthArr; indexNext++)
            {
                if (userArray[minValue] > userArray[indexNext])
                {
                    minValue = indexNext;
                }
            }

            tempVar = userArray[indexPrev];
            userArray[indexPrev] = userArray[minValue];
            userArray[minValue] = tempVar;            
        }

        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            Console.Write(userArray[indexArr] + " ");
        }
        Console.WriteLine();
    }
}
