using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first nember : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second nember :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the sum of the nembers is {a + b}");
            Console.ReadKey();
        }
    }
}
