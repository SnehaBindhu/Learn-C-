using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Math_op
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            Console.WriteLine((5+6*63)/3.4);
            Console.WriteLine("");

            //Simple variable increment
            int num = 6;
            num ++;
            Console.WriteLine(num);
            Console.WriteLine("");

            //Input number from the user and display it 
            Console.WriteLine("Enter a number:");

            int usernum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is "+ usernum); 
            Console.WriteLine();

            //Comparison Operators
            int a = 3;
            Console.WriteLine(a<usernum);
            Console.WriteLine(a==usernum);


            // Logical opeartors
            int b = 6;
            Console.WriteLine(a<usernum && a<b);
            Console.ReadLine();
        }
    }
}
