using System;

namespace hw_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class shape  //形状的基类
    {
        double area{ set; get; } //定义面积
        public abstract double CalArea(); //计算（设置）面积的方法，需要重写
    }

    public interface IsLegalShape //实现判断面积是否合法的接口
    {
        bool isLegalShape();
    }

    class Rectangle : shape, IsLegalShape
    {
        private double length;
        private double width;
        Rectangle(double l,double w)
        {
            this.length = l;this.width = w; 
        }
        Rectangle() : this(0, 0) { }
        Rectangle(int l,int w) : this((double)l, (double)w) { }
        public double CalArea()
        {
            this.area
        }

}
