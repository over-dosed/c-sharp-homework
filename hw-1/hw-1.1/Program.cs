using System;

namespace csharp_hw_1._1
{
    class Program
    {
        const int max = 20;
        static void Main(string[] args) //main函数
        {
            int a, b, c, d = 0;
            Console.WriteLine("please input the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the sign:");
            c = Console.Read();
            Console.ReadLine();
            switch (c)  //用switch分辨
            {
                case 42: d = a * b; break;
                case 43: d = a + b; break;
                case 45: d = a - b; break;
                case 47: d = a / b; break;
                default: break;
            }
            Console.WriteLine("the answer is : {0}", d);
            calcu();
        }

        static void calcu()
        {
            int[] number = new int[20];
            Console.WriteLine("please input the equation(eg: 238 * 65):");
            string str = Console.ReadLine(); //str表示读入的全部算式
            string str_1 = "", str_2 = "";  //str_1表示第一个运算数
            char[] str_ch = new char[max];
            char c = '0';
            str_ch = str.ToCharArray();
            for (int i = 0; i < max; i++)
            {
                if (str_ch[i] == '+' || str_ch[i] == '-' || str_ch[i] == '*' || str_ch[i] == '/')
                {
                    c = str_ch[i];
                    str_1 = str.Substring(0, i); str_1.Trim();
                    str_2 = str.Substring(i + 1, str.Length - i - 1); str_2.Trim();
                    break;
                }
            }
            int a = int.Parse(str_1);
            int b = int.Parse(str_2);
            int d = 0;
            switch (c)  //用switch分辨
            {
                case '*': d = a * b; break;
                case '+': d = a + b; break;
                case '-': d = a - b; break;
                case '/': d = a / b; break;
                default: break;
            }
            Console.WriteLine("the answer is : {0}", d);
        }
    }
}
