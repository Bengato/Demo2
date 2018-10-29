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
            int i = 2,factorial=1;
            int temp = num2;
            while (i <= num2)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("\n{0} 's Factorial is:\t{1}.\n",num2,factorial);
        }
    }
}
