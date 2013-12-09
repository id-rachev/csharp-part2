using System;
using System.Linq;
using System.IO;
using System.Security;

class ReadFileAndPrintValid
{
    // Write a program that enters file name along with its full file path
    // (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    // Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch
    // all possible exceptions and print user-friendly error messages.

    static void PrintFilesContent(string filePath)
    {
        Console.WriteLine(filePath);
    }

    static void Main()
    {
        try
        {
            string filePath = File.ReadAllText(@"C:\WINDOWS\win.ini");
            PrintFilesContent(filePath);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File not found.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid. ");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only. \n -or- This operation is not supported on the current platform.\n -or- path specified a directory.\n -or- The caller does not have the required permission. ");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Security issue. The caller does not have the required permission. ");
        }
    }
}
