using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8
{
    //设计一个类Person
    //Person类中包含姓名、年龄两个字段
    //分别给这两个字段定义自己的属性
    //Person类中定义两个构造方法，其中一个是无参的构造方法，另一个是接收两个参数的构造方法，分别用于为姓名和年龄属性赋值
    //在类中定义一个方法disp()显示姓名、年龄两个字段的值
    //在Main()方法中分别调用不同的构造方法创建两个Person对象，并为属性和性别赋值并调用disp()方法

    class Person
    {
        public string name;
        public int age;


        public Person()
        {
            name = "";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void disp()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}", name, age);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.age = 18;
            p1.name = "张一";
            p1.disp();
            Person p2 = new Person("张三", 20);
            p2.disp();
        }
    }
}
