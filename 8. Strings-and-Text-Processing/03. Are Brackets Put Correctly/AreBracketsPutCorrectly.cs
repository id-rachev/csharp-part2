using System;
using System.Linq;

    class AreBracketsPutCorrectly
    {
        // Write a program to check if in a given expression
        // the brackets are put correctly.
        // Example of correct expression: ((a+b)/5-d).
        // Example of incorrect expression: )(a+b)).

        static void Main()
        {
            Console.Write("Enter a math expression using brackets: ");
            string expression = Console.ReadLine();

            int openBrackets = 0;
            int closeBrackets = 0;
            bool throwMessage = true;

            for (int index = 0; index < expression.Length; index++)
            {
                if (expression[index] == '(')
                {
                    openBrackets++;
                }
                else if (expression[index] == ')')
                {
                    closeBrackets++;

                    if (closeBrackets > openBrackets)
                    {
                        Console.WriteLine("Incorrect expression format! Open bracket is missing.");
                        throwMessage = false;
                        break;
                    }
                }

                if ((index > 0) && (expression[index - 1] == '(') && (expression[index] == ')'))
                {
                    Console.WriteLine("Incorrect expression format! Argument between brackets is missing.");
                    throwMessage = false;
                    break;
                }
            }

            if ((openBrackets != closeBrackets) && (throwMessage))
            {
                Console.WriteLine("Incorrect expression format! Open or closed bracket is missing.");

            }
            else if (throwMessage)
            {
                Console.WriteLine("You entered a correct expression.");
            }
        }
    }