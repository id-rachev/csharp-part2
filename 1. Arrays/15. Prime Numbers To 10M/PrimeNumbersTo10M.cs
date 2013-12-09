using System;
using System.Linq;

class PrimeNumbersTo10M
{
    static void Main()
    {
        //Write a program that finds all prime numbers
        //in the range [1...10 000 000]. Use the sieve of
        //Eratosthenes algorithm (find it in Wikipedia).

        bool[] notPrime = new bool[10000001];
        int counter = new int();

        for (int indexBasic = 2; indexBasic < notPrime.Length; indexBasic++)
        {
            if (notPrime[indexBasic] == false)
            {
                for (int indexMulty = indexBasic + indexBasic; indexMulty < notPrime.Length; indexMulty += indexBasic)
                {
                    if ((notPrime[indexMulty] == false) && (indexMulty % indexBasic == 0))
                    {
                        notPrime[indexMulty] = true;
                    }
                }
            }
        }

        for (int numIndex = 2; numIndex < notPrime.Length; numIndex++)
        {
            if (notPrime[numIndex] == false)
            {
                Console.Write(numIndex + " ");
                counter++;
            }
        }
        Console.WriteLine("\nThere are {0:### ###} prime numbers in the range [1...10 000 000].",
            counter);
    }
}
