using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test12
{
    //定义一个ArrayList非泛型集合
    //定义ArrayList集合，名为arr3
    //调用Add()方法向集合中加入5个元素(可以多于5个)
    //使用Foreach 循环遍历集合输出集合中的所有元素。

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr3 = new ArrayList();
            arr3.Add(1);
            arr3.Add(2);
            arr3.Add(3);
            arr3.Add(4);
            arr3.Add(5);
            foreach (var putout in arr3)
            {
                Console.WriteLine(putout);
            }
        }
    }
}
