using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= number)
            {
                Console.WriteLine(i);
                i += 1;
            }

            Console.WriteLine("Enter another number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            do
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
                x += 1;
            }

            while (x <= number2);
            Console.ReadLine();
        }
    }
}
