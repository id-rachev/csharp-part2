using System;

class CompareTwoArrays
{
    static void Main()
    {
        //Write a program that reads two arrays from the
        //console and compares them element by element.

        Console.Write("Enter the length of the first array: ");
        int lengthArray1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second array: ");
        int lengthArray2 = int.Parse(Console.ReadLine());

        if (lengthArray1 == lengthArray2)
        {
            string[] arrayFirst = new string[lengthArray1];
            string[] arraySecond = new string[lengthArray2];

            for (int index1 = 0; index1 < lengthArray1; index1++)
            {
                Console.Write("Enter next element of the first array: ");
                arrayFirst[index1] = Console.ReadLine();
            }

            for (int index2 = 0; index2 < lengthArray2; index2++)
            {
                Console.Write("Enter next element of the second array: ");
                arraySecond[index2] = Console.ReadLine();

                if (arrayFirst[index2] != arraySecond[index2])
                {
                    Console.WriteLine("These two arrays are not equal!");
                    break;
                }
                else if (index2 == (lengthArray2 - 1))
                {
                    Console.WriteLine("These two arrays are equal!");
                }
            }
        }
        else
        {
            Console.WriteLine("These two arrays will not be equal!");
        }
    }
}
