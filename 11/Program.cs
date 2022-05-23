using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    //设计一个Shape接口和它的两个实现类Square和Circle
    //Shape接口中有一个抽象方法Area()，该方法接收一个double类型的参数，返回一个double类型的结果
    //Square和Circle中实现了Shape接口的Area()抽象方法，分别求正方形和圆形的面积并返回
    //在Main()方法中创建Square和Circle对象，计算边长为4的正方形面积和半径为3.5的圆形面积
    interface Shape
    {
        double Area();
    }

    class Square : Shape
    {
        public double Area()
        {
            return 4 * 4;
        }
    }

    class Circle : Shape
    {
        public double Area()
        {
            return 3.14 * 3.5 * 3.5;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            Console.WriteLine("正方形面积：" + sq.Area());
            Circle ci = new Circle();
            Console.WriteLine("圆形面积：" + ci.Area());
        }
    }
}
