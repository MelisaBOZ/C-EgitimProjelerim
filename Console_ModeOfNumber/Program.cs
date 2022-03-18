using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ModeOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program= new Program();
            Console.WriteLine(program.IsOdd());
            Console.WriteLine(program.IsEven());
            Console.WriteLine(program.Mod2());
            Console.ReadLine();
        }
        bool IsOdd()
        {
            Console.WriteLine("Please enter a number ");
            float number = Convert.ToSingle(Console.ReadLine());
            int roundUp = Convert.ToInt32(number);
            return roundUp % 2 == 1;
        }
        bool IsEven()
        {
            Console.WriteLine("Please enter a number ");
            float number = Convert.ToSingle(Console.ReadLine());
            int roundUp = Convert.ToInt32(number);
            return roundUp % 2 == 0;
        }

        float Mod2()
        {
            Console.WriteLine("Please enter a number ");
            float number = Convert.ToSingle(Console.ReadLine());
            return number % 2;
            

        }
    }
}
