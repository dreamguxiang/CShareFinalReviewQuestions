using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    //设计一个动物类Animal和它的一个子类Dog
    //Animal类有name(名)、和age(年龄)字段，一个包含两个参数的构造方法，用于给name和age字段赋值，一个Show()方法打印Animal的字段信息
    //狗类Dog增加一个breed (品种) 字段。有一个包含三个参数的构方法，前两个参数用于给继承的name和age字段赋值，第三个参数用于给breed字段赋值，一个Show()方法用于打印Dog的字段信息
    //在测试类中创建Dog对象，输出它的字段值
    
    class Animal
    {
        public string name;
        public int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Show()
        {
            Console.WriteLine("名字:{0},年龄:{1}", name, age);
        }
    }
    class Dog : Animal
    {
        public string breed;
        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }
        public new void Show()
        {
            Console.WriteLine("名字:{0},年龄:{1},品种:{2}", name, age, breed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("小白", 2, "泰迪");
            dog.Show();
        }
    }
}
