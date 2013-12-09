using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncryptionOfString
{
    static void Main()
    {
        // Write a program that encodes and decodes a string using given encryption key (cipher).
        // The key consists of a sequence of characters. The encoding/decoding is done by
        // performing XOR (exclusive or) operation over the first letter of the string with
        // the first of the key, the second – with the second, etc. When the last key character
        // is reached, the next is the first.

        string textToEncode = "Top Secret";

        Console.Write("Enter the encryption key (cipher): ");
        string cipher = Console.ReadLine();

        string encodedText = EncryptDecrypt(textToEncode, cipher);
        Console.WriteLine("Encrypted text: {0}", encodedText);

        string decodedText = EncryptDecrypt(encodedText, cipher);
        Console.WriteLine("Decrypted text: {0}", decodedText);
    }
  
    private static string EncryptDecrypt(string textToShift, string cipher)
    {
        StringBuilder codedText = new StringBuilder(textToShift.Length);

        for (int index = 0, ciphCount = 0; index < textToShift.Length; index++, ciphCount++)
        {
            if (ciphCount == cipher.Length)
            {
                ciphCount = 0;
            }

            codedText.Append((char)(textToShift[index] ^ cipher[ciphCount]));
        }

        return codedText.ToString();
    }
}
