using System;

class BinarySearch
{
    static void Main()
    {
        //Write a program that finds the index of given element
        //in a sorted array of integers by using the binary search
        //algorithm (find it in Wikipedia).

        Console.Write("Enter one integer number (the array length): ");
        int lengthArr = int.Parse(Console.ReadLine());

        int[] userArray = new int[lengthArr];

        for (int indexArr = 0; indexArr < lengthArr; indexArr++)
        {
            Console.Write("Enter next array element: ");
            userArray[indexArr] = int.Parse(Console.ReadLine());
        }

        int searchIndex = lengthArr / 2;
        bool isFoundIndex = false;

        Array.Sort(userArray);

        Console.Write("Enter an integer to check its position in the sorted array: ");
        int numToSearch = int.Parse(Console.ReadLine());

        if ((numToSearch >= userArray[0]) && (numToSearch <= userArray[lengthArr - 1]))
        {
            while (isFoundIndex == false)
            {
                if (numToSearch > userArray[searchIndex])
                {
                    searchIndex += searchIndex / 2;
                    if (searchIndex >= lengthArr)
                    {
                        searchIndex = lengthArr - 1;
                    }
                }
                else if (numToSearch < userArray[searchIndex])
                {
                    searchIndex -= searchIndex / 2;
                }
                if ((searchIndex == 1) || (numToSearch == userArray[searchIndex - 1]))
                {
                    searchIndex = searchIndex - 1;
                }
                if (numToSearch == userArray[searchIndex])
                {
                    isFoundIndex = true;
                }
            }

            Console.WriteLine("Number {0} is at index {1} in the sorted array:",
                numToSearch, searchIndex);

            for (int indexSorted = 0; indexSorted < lengthArr; indexSorted++)
            {
                Console.Write(userArray[indexSorted] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Number {0} is not an element of the given array.", numToSearch);
        }
    }
}
