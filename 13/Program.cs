using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Test13
{
    //请按照要求定义一个Hashtable非泛型集合
    //定义Hashtable集合，名为myht
    //调用Add()方法向集合中加入5个元素（可以多于5个）。
    //使用Foreach 循环遍历集合输出集合中的所有键值对。

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myht = new Hashtable();
            myht.Add("1", "a");
            myht.Add("2", "b");
            myht.Add("3", "c");
            myht.Add("4", "d");
            myht.Add("5", "e");
            foreach (DictionaryEntry de in myht)
            {
                Console.WriteLine(de.Key + ":" + de.Value);
            }
        }
    }
}
