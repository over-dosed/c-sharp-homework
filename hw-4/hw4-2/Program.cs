using System;

namespace hw4_2
{
    class Time
    {
        public int hour { set; get; }
        public int min { set; get; }
        public int second { set; get; }

        public Time()
        {
            hour = min = second = 0;
        }

        public Time(int h, int m, int s)
        {
            hour = h; min = m; second = s;
        }

        public void change()
        {
            second++;
            if(second == 60)
            {
                second -= 60; min++;
            }
            if (min == 60)
            {
                min -= 60; hour++;
            }
            if (hour == 24)
            {
                hour -= 24;
            }
        }

        public bool equal(Time t)
        {
            if (t.hour == hour && t.min == min && t.second == second) return true;
            return false;
        }
    }

    class Clock
    {
        public Time clockTime { set; get; } = new Time();  //属性，时钟时间

        public Time alarmTime { set; get; } = new Time();  //属性，闹铃时间

        public delegate void tickHandler(object sender);   //tick事件，alarm事件
        public delegate void alarmHandler(object sender);

        public Clock()
        {
            clockTime.hour = System.DateTime.Now.Hour;
            clockTime.min = System.DateTime.Now.Minute;
            clockTime.second = System.DateTime.Now.Second;
        }

        public void setClockTime(int h, int m, int s)
        {
            clockTime.hour = h; clockTime.min = m; clockTime.second = s;
        }

        public void setAlarmTime(int h, int m, int s)
        {
            alarmTime.hour = h; alarmTime.min = m; alarmTime.second = s;
        }

        public void showClockTime()
        { 
            Console.WriteLine("clock time is:  " +clockTime.hour + ":" + clockTime.min + ":" + clockTime.second);
        }
        public void showAlarmTime()
        {
            Console.WriteLine("alarm time is:  " +alarmTime.hour + ":" +alarmTime.min + ":" +alarmTime.second);
        }

        public event tickHandler Tick;
        public event alarmHandler Alarm;

        public void run()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                clockTime.change();
                Tick(this);
                if (clockTime.equal(alarmTime)) Alarm(this);
            }
        }
    }

    class from
    {
        public Clock clock1 = new Clock();
        public from()
        {
            clock1.Tick += clock1 =>
            {
                Clock clock = (Clock)clock1;
                clock.showClockTime();
            };
            clock1.Alarm += clock1 =>
            {
                Clock clock = (Clock)clock1;
                Console.WriteLine("is alarming now !!!\a\a\a");
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            from from_1 = new from();
            from_1.clock1.setAlarmTime(16,2, 20);
            from_1.clock1.run();
        }
    }
}
