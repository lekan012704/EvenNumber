using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("This is an Even Number");
            }
            else
            {
                Console.WriteLine("This is an Odd Number");
            }
            Console.ReadLine();
        }
    }
}
