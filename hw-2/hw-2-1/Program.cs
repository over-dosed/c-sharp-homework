using System;

namespace hw_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayNum = 500;            //定义因子数组最大值
            int[] factorNum = new int[arrayNum];
            Console.WriteLine("please input number:");
            string str = Console.ReadLine();  //读取用户输入
            int num = int.Parse(str);
            decomposePrimeFactors(num, factorNum, arrayNum);
            Console.Write("the prime factors of " + num + " is :");
            for (int i = 0;i< arrayNum;i++)
            {
                if (factorNum[i] == 0) break;
                Console.Write(factorNum[i] + "  ");
            }
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
        
        static public void decomposePrimeFactors(int num,int[] factorNum,int arrayNum)
        {
            int countNum = 0;   //用于计数每个数的素数因子个数
            int oriNumber = num;
            for (int j = 2;j<oriNumber;) //第二层循环找到所有质因子
            {
                if (num % j == 0) //如果j是该数的因子
                {
                    num = num / j;
                    factorNum[countNum] = j;
                    countNum++;
                }
                else j++;
            }
        }


    }
}
