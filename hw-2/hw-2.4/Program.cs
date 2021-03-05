using System;

namespace hw_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int row;
            int col;
            
            Console.WriteLine("please input the row :");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the colomn :");
            col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row,col];
            for (int i = 0;i< row;i++)  //每次读取一行数据,将matrix数组赋值
            {
                Console.WriteLine("please input the " + (i + 1) + "st row:");
                string str = Console.ReadLine();
                string[] sArray = str.Split(new char[3] { ' ', ',','，' }); //将用户输入的字符串以空格和逗号区分
                for (int j = 0; j < sArray.Length; j++)
                {
                    matrix[i,j] = int.Parse(sArray[j]);
                }
            }

            Console.WriteLine("IsToeplitzMatrix ?   :"+IsToeplitzMatrix(row,col,matrix));
        }

        static bool IsToeplitzMatrix(int row,int col,int[,] matrix)
        {
            for(int i = 0;i<row - 1;i++) //从第一列的每一个元素出发向右下对比
            {
                for (int j = 0; j < col - 1; j++) //从第一行的每一个元素出发向右下对比
                {
                    if (matrix[i,j] != matrix[i+1, j + 1]) return false;
                }
            }
            return true;
        }
    }
}
