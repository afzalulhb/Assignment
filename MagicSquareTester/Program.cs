using System;

namespace MagicSquareTester
{
    class Program
    {
        static int Main(string[] args)
        {
            MagicSquare magic = new MagicSquare();
            bool result = magic.DoMagicTest();
            if (result == true)
            {
                return 0;
            }
            else
            { 
                return 1; 
            }
            //Console.WriteLine(result.ToString());
            //Console.ReadKey();

        }

     
    }
}
