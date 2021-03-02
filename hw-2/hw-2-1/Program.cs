using System;

namespace hw_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayNum = 20;//定义数组最大数为20
            int[,] num = new int[arrayNum, arrayNum];
            Console.WriteLine("please input some numbers:");
            string str = Console.ReadLine();  //读取用户输入
            num = toIntArray(str,arrayNum);
            decomposePrimeFactors(num, arrayNum);
            for(int i = 0;i< arrayNum;i++)
            {
                if (num[i, 0] == 0) break;
                Console.Write("the prime factors of "+ num[i, 0]+" is :");
                for(int j = 1; j < arrayNum; j++)
                {
                    if (num[i,j] == 0) break;
                    Console.Write(num[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static public int[,] toIntArray(string str, int arrayNum) //将输入的字符串转化为整形数组
        {
            int[,] num = new int[arrayNum, arrayNum];
            string[] sArray = str.Split(new char[2] { ' ', ',' }); //将用户输入的字符串以空格和逗号区分
            for(int i= 0;i< sArray.Length;i++)
            {
                num[i,0] = int.Parse(sArray[i]);
            }
            return num;
        }

        static public bool isPrimeNum(int num)  //判断一个数是否为素数
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for(int i = 2;i<num;i++)
            {
                if (num % i == 0) return false; 
            }
            return true;
        }
        
        static public void decomposePrimeFactors(int[,] num,int arrayNum)
        {
            for(int i = 0;i<arrayNum;i++) //第一层循环一一拆解所有的数
            {
                int primeFactorNum = 0;   //用于计数每个数的素数因子个数
                for (int j = 2;j<num[i,0];j++) //第二层循环找到所有质因子
                {
                    if(num[i, 0]%j == 0) //如果j是该数的因子，判断是否为素数
                    {
                        if (isPrimeNum(j))
                        {
                            primeFactorNum++;
                            num[i, primeFactorNum] = j;
                        }
                    }
                }
            }
        }


    }
}
