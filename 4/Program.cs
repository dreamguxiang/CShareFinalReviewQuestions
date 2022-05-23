using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            //对“1+3+5+7+…+99”的求和
            int sum = 0;
            for (int i = 1; i <= 99; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
