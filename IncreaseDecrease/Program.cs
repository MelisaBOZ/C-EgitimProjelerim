using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseDecrease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Clear();//clears the screen that the  user sees

            //-------------------------------

            int number = 15;
            Console.WriteLine("number is : " + number);
            number++;
            Console.WriteLine("(later)Integer with a value added : "+number);
            number--;
            Console.WriteLine("(later)Integer minus one value : " + number);
            ++number;
            Console.WriteLine("(before)Integer with a value added : " + number);
            --number;
            Console.WriteLine("(before)Integer munis one value : " + number);


            Console.ReadLine();
        }
    }
}
