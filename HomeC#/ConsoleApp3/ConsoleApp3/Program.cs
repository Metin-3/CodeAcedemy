using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 4568;
            int temp = number;
            int count = 1;
            int sum1 = 0;
            int sum2 = 0;

            while (temp > 0)
            {
                int num = temp % 10;

                if (count % 2 != 0)
                {
                    sum1 = sum1 + num;
                }

                if (count % 2 == 0)
                {
                    sum2 = sum2 + num;
                }

                temp = temp / 10;

                count++;
            }

            Console.WriteLine("sum of odd numbers: "+ sum1);
            Console.WriteLine("sum of even numbers: "+ sum2);
        }
    }
}
