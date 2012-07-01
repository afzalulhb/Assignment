using System;
using System.Linq;
using System.IO;

namespace MagicSquareTester
{
    class MagicSquare
    {
        private int[][] magicData; // Array to hold inputs from file
        private int width; // Number of columns
        private int height; // Number of rows
        private string apppath = string.Empty;

        public MagicSquare()
        {
            apppath = AppDomain.CurrentDomain.BaseDirectory;
        }

        //  Read input file
        //  We should have the input file named "Magic.dat"
        //  in the execution path
        private void ReadFile()
        {
            StreamReader reader = new StreamReader(apppath + "Magic.Dat");

            try
            {
                // Get row (height) and column (width) number
                int.TryParse(reader.ReadLine(), out width);
                int.TryParse(reader.ReadLine(), out height);
                reader.Close();

                // Get data into array
                magicData = File.ReadLines(apppath + "Magic.Dat")
                                .Skip(2)
                                .Select(l => l.Split(' ').Select(n => int.Parse(n)).ToArray())
                                .ToArray();


            }
            catch (Exception ex)
            {
                throw ex; 
                
               // Show the error message
               // Console.WriteLine(ex.Message);

            }
 
        }
     
      
        // Do magic test
        public bool DoMagicTest()
        {
            bool success = false;
            int magicSum = -1;
            int rowSum = 0;
            int colSum = 0;
            bool magic = true;


            try
            {
                ReadFile();

                // if magicData is initialized, we have data to proceed
                if (magicData != null)
                {
 
                    for (int i = 0; i < width; ++i)
                    {
                        rowSum = colSum = 0;
                        for (int j = 0; j < height; ++j)
                        {

                            rowSum += magicData[i][j];
                            colSum += magicData[j][i]; 
                        
                        }
                        if (magicSum == -1) magicSum = rowSum; // Set the value only once

                        // Check sum of colums and rows... also compare with previous sum 
                        magic = magic && (rowSum == colSum) && (rowSum == magicSum);
                    }

                    success = magic; 
                   
                    //TEST AREA
                    //success = true; 
                    //success = false;

                }

            }
            catch (Exception ex)
            {
                throw ex; //Pass the exception
                // Show the error message
                // Console.WriteLine(ex.Message);

            }

            return success;
        }
    }
}
