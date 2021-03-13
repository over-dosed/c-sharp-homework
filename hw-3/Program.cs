using System;

namespace hw_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, side, side_1, side_2, side_3;

            Console.WriteLine("please input the length:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("please input the width:");
            width = double.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(length, width);
            rec.ShowArea();

            Console.WriteLine("please input the side:");
            side = double.Parse(Console.ReadLine());
            Square squ = new Square(side);
            squ.ShowArea();

            Console.WriteLine("please input the side_1:");
            side_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("please input the side_2:");
            side_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("please input the side_3:");
            side_3 = double.Parse(Console.ReadLine());
            Triangle tri = new Triangle(side_1,side_2,side_3);
            tri.ShowArea();
        }
    }

    abstract class Shape  //形状的基类
    {
        public double area { set; get; }
        //定义面积
        public abstract void CalArea(); //计算（设置）面积的方法，需要重写
    }

    public interface IsLegalShape //实现判断面积是否合法的接口
    {
        bool isLegalShape();
    }

    class Rectangle : Shape, IsLegalShape  //长方形
    {
        public double length { set; get; }
        public double width { set; get; }

        public Rectangle(double l, double w)  //构造函数//
        {
            this.length = l; this.width = w;
        }

        public override void CalArea()
        {
            area = length * width;
        }

        public bool isLegalShape()
        {
            if (length > 0 && width > 0) return true;
            else return false;
        }

        public void ShowArea()
        {
            this.CalArea();
            if (isLegalShape())
            {
                Console.WriteLine("The area is:" + this.area);
            }
            else Console.WriteLine("The shape is illegal");
        }
    }

    class Square : Rectangle  //正方形
    {
        public double side { set; get; }

        public Square(double s):base(s,s)
        {
            this.side = s;
        }

        public override void CalArea()
        {
            area = side * side;
        }

        public new bool isLegalShape()
        {
            if (side > 0) return true;
            else return false;
        }
    }

    class Triangle : Shape, IsLegalShape  //三角形
    {
        public double side_1 { set; get; }
        public double side_2 { set; get; }
        public double side_3 { set; get; }

        public Triangle(double a, double b, double c)
        {
            this.side_1 = a; this.side_2= b;this.side_3 = c;
        }
       
        public override void CalArea()
        {
            double p = (side_1 + side_2 + side_3) / 2;
            area = Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3));
        }

        public bool isLegalShape()
        {
            if (side_1 <= 0 || side_2 <= 0 || side_3 <= 0) { return false; }
            if(side_1 + side_2 <= side_3 || side_2 + side_3 <= side_1 || side_1 + side_3 <= side_2)
            {
                return false;
            }
            return true;
        }

        public void ShowArea()
        {
            this.CalArea();
            if (isLegalShape())
            {
                Console.WriteLine("The area is:" + this.area);
            }
            else Console.WriteLine("The shape is illegal");
        }
    }
}
