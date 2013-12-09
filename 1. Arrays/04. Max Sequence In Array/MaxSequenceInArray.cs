using System;

class MaxSequenceInArray
{
    static void Main()
    {
        //Write a program that finds the maximal sequence
        //of equal elements in an array.

        Console.Write("Enter length of the array (int): ");
        int lengthArr = int.Parse(Console.ReadLine());

        //With string array it works for all var types, not just integers:
        string[] userArray = new string[lengthArr];
        string[] recordArray = new string[lengthArr];
        int sequenceMaxLength = new int();

        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            Console.Write("Enter next array element: ");
            userArray[indexArr] = Console.ReadLine();

            if ((indexArr != 0) && (userArray[indexArr] == userArray[indexArr - 1]))
            {
                recordArray[indexArr - 1] = userArray[indexArr - 1];
                recordArray[indexArr] = userArray[indexArr];
            }
        }

        //Sorting the record array by maximal sequences:
        Array.Sort(recordArray, (x, y) => (x == y).CompareTo(x != y));

        Console.WriteLine("The all sequences of equal elements are:");
        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            if ((indexArr != 0) && (recordArray[indexArr] != recordArray[indexArr - 1]))
            {
                Console.WriteLine();
            }
            Console.Write(recordArray[indexArr] + " ");

            if ((recordArray[0] == recordArray[indexArr]) && (recordArray[0] != null))
            {
                sequenceMaxLength++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sequence is {0} elements long!", sequenceMaxLength);
    }
}
