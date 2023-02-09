using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ints[2] = 11;

            String[] weekDays;
            weekDays = new string[4] { "Sun", "Mon", "Tue", "Wed" };
            //weekDays[4] = "Thurs";

            Console.WriteLine(ints[7]);
            Console.WriteLine(weekDays[2]);
            Console.ReadLine();
        }
    }
}
