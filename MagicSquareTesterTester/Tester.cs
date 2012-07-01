using System;
using System.Linq;
using System.Diagnostics;
using System.IO;

namespace MagicSquareTesterTester
{
    class Tester
    {
        private string apppath = string.Empty;

        public Tester()
        {
            apppath = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void Test(string exeToTest)
        {
            TesterMagicSquare magic = new TesterMagicSquare();
            // Console.WriteLine(result.ToString());
            // Console.ReadKey();

            int testRresult = 0;
            int otherAppResult = 0;
            


            try
            {
                testRresult = magic.DoMagicTest();
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(apppath + exeToTest)

               {
                    UseShellExecute = false
                };

                p.Start();
                p.WaitForExit();
                otherAppResult = p.ExitCode;


                // IF MagicSquareTester has an exception, we will
                // display error; else we will compare the result and show it
                if (otherAppResult == 2)
                {
                    Console.WriteLine("An error occured in " + exeToTest);
                    
                }               
                else if (testRresult == otherAppResult)
                {
                    Console.WriteLine("ok");
                    //Console.ReadKey();
               }
                else                 
                {
                    Console.WriteLine("not ok:");
                    PrintData();
                    Console.WriteLine("returned:" + ((otherAppResult == 0) ? " yes" : " no"));
                    Console.WriteLine("expected:" + ((testRresult == 0) ? " yes" : " no"));

                }

 
                    

            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occured:");
                Console.WriteLine(ex.Message);
            }



          

        }

        private void PrintData()
        {
           
            try
            {
                Console.WriteLine("");
                
                // Get data into array
                var magicData = File.ReadLines(apppath + "Magic.Dat")
                                .Skip(2)
                                .ToArray();
                foreach (var mg in magicData)
                {
                    Console.WriteLine(mg.ToString());

                }


            }
            catch (Exception ex)
            {

                // Show the error message
                // Console.WriteLine(ex.Message);

            }

        }
    }
}
