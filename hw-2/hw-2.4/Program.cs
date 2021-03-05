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
            for(int i = 0;i<row;i++) //从第一列的每一个元素出发向右下对比
            {
                int ro = i; int co = 0;
                for (ro = i,co = 0;ro < row-1 && co < col-1;)
                {
                    if (matrix[ro,co] != matrix[ro + 1,co + 1]) return false;
                    else { ro++; co++; }
                }
            }
            for (int j = 1; j < col; j++) //从第一行的每一个元素出发向右下对比
            {
                int ro = 0; int co = j;
                for (ro = 0, co = j; ro < row - 1 && co < col - 1;)
                {
                    if (matrix[ro,co] != matrix[ro + 1,co + 1]) return false;
                    else { ro++; co++; }
                }
            }
            return true;
        }
    }
}
