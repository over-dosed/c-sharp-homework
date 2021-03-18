using System;

namespace hw4_2
{
    class Time
    {
        public int hour { set; get; }
        public int min { set; get; }
        public int second { set; get; }

        public Time(int h, int m, int s)
        {
            hour = h; min = m; second = s;
        }
    }

    public delegate 
    class Clock
    {
        public Time clockTime { set; get; }

        public Time alarmTime { set; get; }

        public void setClockTime(int h, int m, int s)
        {
            clockTime.hour = h; clockTime.min = m; clockTime.second = s;
        }

        public void setAlarmTime(int h, int m, int s)
        {
            alarmTime.hour = h; alarmTime.min = m; alarmTime.second = s;
        }
        public void show
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
