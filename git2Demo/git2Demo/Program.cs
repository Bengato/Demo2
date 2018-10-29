using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATE FACTORIAL:\n");
            int num2 = int.Parse(Console.ReadLine());
            int i = 1,factorial=num2;
            int temp = num2;
            while (i <= temp)
            {
                Console.WriteLine();
                factorial *= i;
                Console.WriteLine("{0}\t*\t{1}\t=\t{2}",num2,i,factorial);
                num2 *= i;
                i++;
            }
        }
    }
}
