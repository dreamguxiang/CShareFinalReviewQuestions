using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15
{
    //定义一个Dictionary<TKey,TValue>泛型集合
    //Dictionary<TKey,TValue>泛型集合的键为int类型、值为string类型。
    //向集合中添加任意的五个键值对。
    //调用foreach语句对集合的键值对进行遍历，输出集合的键与值。

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "one");
            dic.Add(2, "two");
            dic.Add(3, "three");
            dic.Add(4, "four");
            dic.Add(5, "five");

            foreach (KeyValuePair<int, string> kv in dic)
            {
                Console.WriteLine("Key:{0},Value:{1}", kv.Key, kv.Value);
            }
        }
    }
}
