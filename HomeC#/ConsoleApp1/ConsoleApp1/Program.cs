using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 53478;
            int max = 0;
            while (number > 0)
            {
                if ((number % 10) > max)
                {
                    max = number % 10;
                }
                 number = number / 10;
            }

            Console.WriteLine("Max: "+ max);
        }
    }
}
