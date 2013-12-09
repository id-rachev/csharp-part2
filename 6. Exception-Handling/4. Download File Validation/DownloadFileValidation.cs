using System;
using System.Linq;
using System.Net;

class DownloadFileValidation
{
    // Write a program that downloads a file from Internet 
    // (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores
    // it the current directory. Find in Google how to download
    // files in C#. Be sure to catch all exceptions and to free
    // any used resources in the finally block.

    static void Main(string[] args)
    {
        string urlAddress = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileToDownload = "Logo-BASD.jpg";

        using (WebClient netClient = new WebClient())
        {
            try
            {
                netClient.DownloadFile(urlAddress, fileToDownload);
                Console.WriteLine("The file was downloaded in the Debug folder of the project!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No-value provided for the web-address (or null value). Please specify a valid address.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The web-address name is empty. Please specify a valid address.");
            }
            catch (WebException)
            {
                Console.WriteLine("The URL was not found! Please make sure the address is correct.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This operation is already performed by another method.");
            }

        }

    }
}
