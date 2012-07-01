
using System;
namespace MagicSquareTesterTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string exeToTest = string.Empty;//args[0];

            if (args.Length > 0)
            {
                exeToTest = args[0];
                Tester tester = new Tester();
                tester.Test(exeToTest);
            }
            else
            {
                Console.WriteLine("Argument missing ");
            }
            //else
            //{
            //    exeToTest = "MagicSquareTester.exe";
            //    Tester tester = new Tester();
            //    tester.Test(exeToTest);
            //}
            
        }
    }
}
