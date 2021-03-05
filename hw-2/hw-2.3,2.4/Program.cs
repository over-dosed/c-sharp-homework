using System;

namespace hw_2._3_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minNumber = 2;
            const int maxNumber = 100;
            int notPrime = int.MaxValue; //用于标识数组中该数是否为素数
            int[] number = new int[maxNumber - minNumber + 1];
            EgyptianSieve(minNumber, maxNumber, number);
            Console.WriteLine("the primes out of EgyptianSieve are:");
            foreach(int i in number)
            {
                if (i != notPrime) Console.Write(i + "  ");
            }
        }

        static void EgyptianSieve(int minNumber ,int maxNumber, int[] number)
        {
            for (int i = minNumber; i <= maxNumber; i++)
            {
                number[i - minNumber] = i; //将number数组赋从2到100的初值
            }
            for(int i = minNumber;i<= System.Math.Sqrt(maxNumber);i++)
            {
                for (int j = 2; i * j <= maxNumber; j++) number[i * j - minNumber] = int.MaxValue;
            }
        }
    }
}
