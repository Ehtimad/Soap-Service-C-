using ConsoleApp1.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            var x = new localhost.RandomNumberGeneratorService();
            try
            {
                var z = x.GetRandomNumbersDate();
                foreach (var item in z)
                {
                    Console.WriteLine("Number is {0} ----- Date is {1}", item.RandomNumber, item.NumberDate);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
