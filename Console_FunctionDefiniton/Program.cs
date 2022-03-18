using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_FunctionDefiniton
{
    class Program
    {
        double firstnumber;
        double lastnumber;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.UserDataEntry();
            program.add();
            Console.WriteLine("conclusion is : "+program.add());
            Console.ReadLine();
        }

        public double add()
        {
            double conclusion = firstnumber + lastnumber;
            return conclusion;
        }
        void UserDataEntry()
        {
            try
            {
                Console.WriteLine("Please enter a number ");
                firstnumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the second number ");
                lastnumber = Convert.ToDouble(Console.ReadLine());
                


            }
            catch 
            {
                Console.WriteLine("Please enter an number value");
                Console.ReadLine();
            }
        }
    }
}
