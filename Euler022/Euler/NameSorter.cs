using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    internal class NameSorter
    {
        private static void Main()
        {
            // read the file
            string names = File.ReadAllText(@"C:\Users\Sadie\Dropbox\Programming\Euler\Euler022\Euler\names.txt");

            // remove quotes
            names = names.Replace(@"""", "");

            // put them in an array of strings
            string[] namesArray = names.Split(',');

            // sort it
            Array.Sort(namesArray);

            // Calculate Name Score
            int lineNumber = 0;
            int letterScore;
            int totalNameScore = 0;

            foreach (string s in namesArray)
            {
                int nameScore = 0;
                foreach (var c in s)
                {
                    letterScore = Convert.ToInt32(c) - 64;
                    nameScore = nameScore + letterScore;
                }

                lineNumber++;
                nameScore = nameScore*lineNumber;
                totalNameScore = totalNameScore + nameScore;

                Console.WriteLine(lineNumber + ": " + s + " " + nameScore);
            }
            Console.WriteLine(totalNameScore);
            Console.ReadLine();
        }
    }
}