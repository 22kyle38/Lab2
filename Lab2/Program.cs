using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int 5; // declare first number to *
            int 2; // declare second number to *
            int 10; // declare sum of 5 and 2

            Console.Write("5:"); // prompt user
                                 // read first number from user
            5 = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("2:"); // prompt user
                                 // read first number from user
            2 = Convert.ToInt32(Console.ReadLine());

            sum = 5 * 2; // * numbers

            Console.WriteLine("10", sum); // display sum

            //The programs excution will start once you test your code by clicking the "start" button at the top.
            //The difference between an integer type variable and a double / floating-point variable is an integer (int) is not decimal while the floating point is.
            //An example from the video in chapter for is  "static void Main(string[] args)". This is a block that contains statements.
            //To read the value of an instance variable, we create method called a int accessor.  To assign a value ton instance variable, we use a method called a floati types double accessor.
            //A class is just a templet for objects. The class just describes the contents within the class.

            Console.WriteLine("{0}\n{1}", "Hello wrold", "From Kyle Weinschreider!");
            Console.ReadLine();




        }
    }
}
