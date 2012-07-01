using System;

namespace MagicSquareTester
{
    class Program
    {
        static int Main(string[] args)
        {
            MagicSquare magic = new MagicSquare();
            try
            {
                bool result = magic.DoMagicTest();
                if (result == true)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch(Exception)
            {
                return 2; //Error
            }
            //Console.WriteLine(result.ToString());
            //Console.ReadKey();

        }

     
    }
}
