using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Laser
{
    static void Main()
    {
        string line1 = Console.ReadLine();
        char[] separator = new char[] { ' ' };
        string[] cuboDims = line1.Split(separator);
        
        int cuboWith = int.Parse(cuboDims[0]);
        int cuboHeight = int.Parse(cuboDims[1]);
        int cuboDepth = int.Parse(cuboDims[2]);

        bool[, ,] isCubeHit = new bool[cuboWith, cuboHeight, cuboDepth];

        string line2 = Console.ReadLine();
        string[] shotDims = line2.Split(separator);

        int shotWith = int.Parse(shotDims[0]) - 1;
        int shotHeight = int.Parse(shotDims[1]) - 1;
        int shotDepth = int.Parse(shotDims[2]) - 1;

        string line3 = Console.ReadLine();
        string[] vectorDims = line3.Split(separator);

        int directWith = int.Parse(vectorDims[0]);
        int directHeight = int.Parse(vectorDims[1]);
        int directDepth = int.Parse(vectorDims[2]);

        while (true)
        {
            isCubeHit[shotWith, shotHeight, shotDepth] = true;
            shotWith += directWith;
            shotHeight += directHeight;
            shotDepth += directDepth;

            if (isCubeHit[shotWith, shotHeight, shotDepth])
            {
                PrintResult(shotWith, shotHeight, shotDepth, directWith, directHeight, directDepth);
                break;
            }

            if ((shotWith == cuboWith - 1) || (shotWith == 0))
            {
                if ((shotHeight == cuboHeight - 1) || (shotHeight == 0))
                {
                    PrintResult(shotWith, shotHeight, shotDepth, directWith, directHeight, directDepth);
                    break;
                }
                directWith *= -1;
            }

            if ((shotHeight == cuboHeight - 1) || (shotHeight == 0))
            {
                if ((shotDepth == cuboDepth - 1) || (shotDepth == 0))
                {
                    PrintResult(shotWith, shotHeight, shotDepth, directWith, directHeight, directDepth);
                    break;
                }
                directHeight *= -1;
            }

            if ((shotDepth == cuboDepth - 1) || (shotDepth == 0))
            {
                if ((shotWith == cuboWith - 1) || (shotWith == 0))
                {
                    PrintResult(shotWith, shotHeight, shotDepth, directWith, directHeight, directDepth);
                    break;
                }
                directDepth *= -1;
            }
        }


    }

    private static void PrintResult(int shotWith, int shotHeight, int shotDepth, int directWith, int directHeight, int directDepth)
    {
        Console.WriteLine("{0} {1} {2}", shotWith + 1 - directWith, shotHeight + 1 - directHeight, shotDepth + 1 - directDepth);
    }
}
