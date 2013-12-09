using System;

class ArrayOf20Integers
{
    static void Main()
    {
        //Write a program that allocates array of 20 integers
        //and initializes each element by its index multiplied by 5.
        //Print the obtained array on the console.


        int[] arrayOf20 = new int[20];

        for (int index = 0; index < arrayOf20.Length; index++)
        {
            arrayOf20[index] = index * 5;
            Console.Write(arrayOf20[index] + " ");
        }
        Console.WriteLine();
    }
}

