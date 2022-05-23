using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出1到1000之间所有可以被3整除又可以被7整除的数
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
