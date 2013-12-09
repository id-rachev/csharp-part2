using System;
using System.Linq;
class AlphabetArray
{
    // Write a program that creates an array containing all letters
    // from the alphabet (A-Z). Read a word from the console and print
    // the index of each of its letters in the array.

    static void Main(string[] args)
    {
        char[] alphabetArr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        Console.Write("Enter one word to check the index of each letter: ");
        string userStrInput = Console.ReadLine();

        string userStrUpper = userStrInput.ToUpper();

        char[] userArray = userStrUpper.ToCharArray();

        for (int indexUserArr = 0; indexUserArr < userArray.Length; indexUserArr++)
        {
            for (int indexAlphabet = 0; indexAlphabet < alphabetArr.Length; indexAlphabet++)
            {
                if (userArray[indexUserArr] == alphabetArr[indexAlphabet])
                {
                    Console.WriteLine(
                        "Letter {0} has index {1} in the array.",
                        userArray[indexUserArr], indexAlphabet);
                }
            }
        }
    }
}
