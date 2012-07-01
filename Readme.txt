My project is about creating an application to check magic square and creating another application to test this application.

Magic.dat is a file with data to test. First line is the number of columns, second line is the number of rows. Rest are data to test. Sample file has numbers for magic square:
3
3
1 2 3
2 3 1
3 1 2

MagicSquareTester.exe checks the data in Magic.dat and returns 0 if magic square, returns 1 if not a magic square and returns 2 if it encounters any error.

MagicSquareTesterTester.exe also checks data in Magic.dat, then runs MagicSquareTester.exe and compares result with it's own result and displays result. MagicSquareTesterTester.exe takes one parameter, name of the exe to execute. 

We need the Magic.dat, MagicSquareTester.exe and MagicSquareTesterTester.exe to be in the same folder. From command prompt we can go to the path and run the MagicSquareTesterTester.exe like:

MagicSquareTesterTester.exe MagicSquareTester.exe

In source, we have both projects in one solution, Assignment.sln, so that we can test and debug both projects easily.

A compact version is also available for download, assignment.zip.

If you have any question or suggestion, please email me at afzalulhb@gmail.com.

Thank you!

Afzalul Bhuiyan