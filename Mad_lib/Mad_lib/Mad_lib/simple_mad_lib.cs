using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_lib
{
    class simple_mad_lib
    {
        static void Main(string[] args)
        {
            string color, pluralnoun, person;

            Console.Write("Enter a color:");
            color = Console.ReadLine();

            Console.Write("Enter a pluralnoun:");
            pluralnoun = Console.ReadLine();

            Console.Write("Enter a person name:");
            person = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Sunflowers are "+ color);
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I love " +person);

            Console.ReadLine();
        }
    }
}
