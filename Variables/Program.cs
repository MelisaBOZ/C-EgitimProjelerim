using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static int number=3;
        static void Main(string[] args)
        {
            Console.WriteLine("Integer value : " +number);
            number = 5;
            Console.WriteLine("The value of the integer has changed. It's value : " + number+"\n");

            //----------------------------------

            // Case sensitive
            int sensitiveNumber = 5;
            int SensitiveNumber = 10;

            Console.WriteLine("Different variables with the same name:\nsensitiveNumber is :" + sensitiveNumber+"\nSensitiveNumber is : " + SensitiveNumber+"\n");

            string text = "Game developer Education";
            Console.WriteLine("My text variable is :"+text);

            bool isThatTrue = true;
            Console.WriteLine("My bool variable is "+isThatTrue);
            Console.ReadKey();

        }
    }
}
