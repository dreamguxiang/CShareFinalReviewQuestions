using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9 {
    //设计一个学生类Student和它的一个子类Undergraduate
    //Student类有name(姓名)、和age(年龄)字段，一个包含两个参数的构造方法，用于给name和age字段赋值，一个Show()方法打印Student的字段信息
    //本科生类Undergraduate增加一个Degree(学位) 字段。有一个包含三个参数的构造方法，前两个参数用于给继承的name和age字段赋值，第三个参数用于给Degree字段赋值，一个Show()方法用于打印Undergraduate的字段信息。
    //在Main()方法分别创建Student对象和Undergraduate对象，调用它们的Show()方法。

    class Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}", name, age);
        }
    }
    class Undergraduate : Student
    {
        public string Degree;

        public Undergraduate(string name, int age, string degree) : base(name, age)
        {
            this.Degree = degree;
        }

        public new void Show()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}，学位：{2}", name, age, Degree);
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student("张三", 18);
            s.Show();
            Undergraduate u = new Undergraduate("李四", 19, "本科");
            u.Show();
        }

    }
}
