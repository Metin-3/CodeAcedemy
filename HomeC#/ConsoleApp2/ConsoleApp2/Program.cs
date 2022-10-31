using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int lastNum = 20;

            for (int i = lastNum; i >= firstNum; i -= 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
