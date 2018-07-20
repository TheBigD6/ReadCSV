using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\ReadFileCSV\ReadMe.csv"))
                {
                    string line ="";

                    while ((line = sr.ReadLine()) != null)
	                {
                        Console.WriteLine(line);
	                }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be found: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
