using System;

namespace hw4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { set; get; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()  //构造函数
        {
            tail = head = null;
        }

        public Node<T> Head   // GenericList链表的属性Head，权限只读，类型为Node<T>的泛型
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }


        public void ForEach(Action<T> action)
        {
            Node<T> p = head;
            while (p != null)
            {
                action(p.Data);
                p = p.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(111);
            intList.Add(222); 
            intList.Add(333);
            intList.Add(444);
            intList.Add(555);

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            int addNumber = 0;

            intList.ForEach((number) => { Console.WriteLine(number); });
            intList.ForEach((number) => { if (number > maxNumber) { maxNumber = number; } });
            intList.ForEach((number) => { if (number < minNumber) { minNumber = number; } });
            intList.ForEach((number) => { addNumber += number; });

            Console.WriteLine("The max number is : "+ maxNumber.ToString());
            Console.WriteLine("The min number is : " + minNumber.ToString());
            Console.WriteLine("The added number is : " + addNumber.ToString());
        }
    }
}
