using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullname = { "Achraf", "Jebali" };
            int myArrayLength = myFullname.Length;
            for (int i = 0; i<myArrayLength;i++)
            {
                Console.Write($"{myFullname[i]}"+" ");
            }
            Console.WriteLine($"\nthe length of my array is {myArrayLength}");
            Console.ReadKey();
        }
    }
}
