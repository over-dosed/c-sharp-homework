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
        public Time clockTime { set; get; } = new Time();

        public Time alarmTime { set; get; } = new Time();

        public delegate void show(object sender);
        public delegate void tickHandler(object sender);
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

        public event show showClockTime;
        public event show showAlarmTime;
        public event tickHandler Tick;
        public event alarmHandler Alarm;

        public void showClock() { showClockTime(this); }
        public void showAlarm() { showAlarmTime(this); }

        public void tickNow() { Tick(this); }

        public void alarmNow() { Alarm(this); }

    }

    class from
    {
        public Clock clock1 = new Clock();
        public from()
        {
            clock1.showClockTime += clock1 =>
            {
                Clock clock = (Clock)clock1;
                Console.WriteLine("clock time is:  "+clock.clockTime.hour + ":" + clock.clockTime.min + ":" + clock.clockTime.second);
            };

            clock1.showAlarmTime += clock1 =>
            {
                Clock clock = (Clock)clock1;
                Console.WriteLine("alarm time is:  " + clock.alarmTime.hour + ":" + clock.alarmTime.min + ":" + clock.alarmTime.second);
            };

            clock1.Tick += clock1 =>
            {
                Clock clock = (Clock)clock1;
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    clock.clockTime.change();
                    clock.showClock();
                    if (clock.clockTime.equal(clock.alarmTime)) clock.alarmNow();
                }
            };

            clock1.Alarm += clock1 =>
            {
                Clock clock = (Clock)clock1;
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    clock.clockTime.change();
                    clock.showAlarm();
                    clock.showClock();
                    Console.WriteLine("is alarming now !!!");
                }
            };

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            from from_1 = new from();
            from_1.clock1.setAlarmTime(11, 30, 10);
            from_1.clock1.tickNow();
        }
    }
}
