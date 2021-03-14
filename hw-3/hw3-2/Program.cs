using System;

namespace hw3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double areaCount = 0;
            while(i<10)
            {
                Shape shape = shapeFactory.RandomGetShape();
                shape.CalArea();
                Console.WriteLine("the " + i + "st shape's area is: " + shape.area);
                i++;
                areaCount += shape.area;
            }
            Console.WriteLine("\nthe 10 shapes' total area is : " + areaCount);
        }
    }

    class shapeFactory  //形状工厂类
    {
        static public Shape RandomGetShape()  // 随机生成形状
        {
            Random ran = new Random();
            int shapeType = ran.Next(0, 3);
            Shape shape;
            int shapeNumber_1 = ran.Next(0, 100);
            int shapeNumber_2 = ran.Next(0, 100);
            int shapeNumber_3 = ran.Next(0, 100); //此处是三个随机生成的参数，用于构造函数赋值
            switch (shapeType)
            {
                case 0:
                    {
                        shape =  new Rectangle(shapeNumber_1,shapeNumber_2);
                        shape.CalArea();
                        if ( double.IsNaN(shape.area) || shape.area == 0)
                        {
                            shape = shapeFactory.RandomGetShape();
                        }
                        return shape;
                    }
                case 1:
                    {
                        shape = new Square(shapeNumber_1);
                        shape.CalArea();
                        if (double.IsNaN(shape.area) || shape.area == 0)
                        {
                            shape = shapeFactory.RandomGetShape();
                        }
                        return shape;
                    }
                case 2:
                    {
                        shape = new Triangle(shapeNumber_1,shapeNumber_2,shapeNumber_3);
                        shape.CalArea();
                        if (double.IsNaN(shape.area) || shape.area == 0)
                        {
                            shape = shapeFactory.RandomGetShape();
                        }
                        return shape;
                    }
                default:return null;
            }
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

        public Square(double s) : base(s, s)
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
            this.side_1 = a; this.side_2 = b; this.side_3 = c;
        }

        public override void CalArea()
        {
            double p = (side_1 + side_2 + side_3) / 2;
            area = Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3));
        }

        public bool isLegalShape()
        {
            if (side_1 <= 0 || side_2 <= 0 || side_3 <= 0) { return false; }
            if (side_1 + side_2 <= side_3 || side_2 + side_3 <= side_1 || side_1 + side_3 <= side_2)
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


