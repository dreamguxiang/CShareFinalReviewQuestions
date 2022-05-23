using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    //要求设计一个学生类Student
    //Student类中包含姓名、成绩两个字段
    //分别给这两个字段定义自己的属性
    //Student类中定义两个构造方法，其中一个是无参的构造方法，另一个是接收两个参数的构造方法，分别用于为姓名和成绩属性赋值。
    //在类中定义一个方法show()显示姓名、成绩两个字段的值
    //在Main()方法中分别调用不同的构造方法创建两个Student对象，并为属性和性别赋值并调用show方法。
    class Student
    {
        public string name;
        public int grades;

        public Student()
        {

        }

        public Student(string name, int grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public void Show()
        {
            Console.WriteLine("姓名：{0}，成绩：{1}", name, grades);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.grades = 100;
            s1.name = "张一";
            s1.Show();
            Student s2 = new Student("张三", 90);
            s2.Show();
        }
    }
}
