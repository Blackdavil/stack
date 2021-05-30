using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                rr[i] = i;
                Console.WriteLine(rr[i]);
            }
            
        }
    }
}
