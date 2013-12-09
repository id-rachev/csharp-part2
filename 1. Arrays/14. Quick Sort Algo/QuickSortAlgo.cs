using System;
using System.Linq;

class QuickSortAlgo
{
    // Write a program that sorts an array of strings using
    // the quick sort algorithm (find it in Wikipedia).
    
    static void Main(string[] args)
    {
        Console.Write("Enter length of the string array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        string[] userArray = new string[arrayLength];

        for (int index = 0; index < arrayLength; index++)
        {
            Console.Write("Enter next string array element: ");
            userArray[index] = Console.ReadLine();
        }
        Console.WriteLine();

        QuickSort(userArray, 0, userArray.Length - 1);

        Console.WriteLine("The sorted array is:");
        for (int i = 0; i < userArray.Length; i++)
        {
            Console.Write(userArray[i] + " ");
        }
        Console.WriteLine();
    }

    public static void QuickSort(string[] element, int leftElmnts, int rightElmnts)
    {
        int left = leftElmnts, right = rightElmnts;
        string middle = element[(leftElmnts + rightElmnts) / 2];

        while (left <= right)
        {
            while (element[left].CompareTo(middle) < 0)
            {
                left++;
            }

            while (element[right].CompareTo(middle) > 0)
            {
                right--;
            }

            if (left <= right)
            {
                string tmp = element[left];
                element[left] = element[right];
                element[right] = tmp;

                left++;
                right--;
            }
        }

        if (leftElmnts < right)
        {
            QuickSort(element, leftElmnts, right);
        }

        if (left < rightElmnts)
        {
            QuickSort(element, left, rightElmnts);
        }
    }
}