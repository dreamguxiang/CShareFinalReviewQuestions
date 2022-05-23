using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test14
{
    //定义一个List<T>泛型集合
    //List<T>泛型集合中的元素为int类型,值依次为1、3、5、2、4、6。
    //调用Sort()方法来对集合进行排序并在控制台输出。
    //使用RemoveAt()方法删除集合中的元素3，并输出删除后的结果。

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 3, 5, 2, 4, 6 };
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
            list.RemoveAt(2);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
