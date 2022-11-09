using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_09_11
{
    public class Time
    {
        private int currentTime;

        public int Hours { get; set; }
        public float Minutes { get; set; }
        public int Seconds { get; set; }
        public int CurrentTime
        {
            get { return currentTime; }
            set
            {
                if (value < 0)
                    currentTime = 0;
                else if (value > Seconds)
                    currentTime = Seconds;
                else
                    currentTime = value;
            }
        }

        public Time()
        { }
        public Time( int hours=0 ,float minutes = 0, int seconds = 0)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;

        }
       public override string ToString()
        {
            return $"Time: {Hours}:{Minutes}:{Seconds}";
        }
        public static Time operator ++(Time t)
        {
            t.Seconds += 1;
            return t;
        }
        public static Time operator --(Time t)
        {
            t.Seconds -= 1;
            return t;
        }
        public static bool operator >(Time t, Time t2)
        {
            return t.Seconds > t2.Seconds;
        }
        public static bool operator <(Time t, Time t2)
        {
            return !(t > t2);
        }
        public override bool Equals(object? obj)
        {
            return obj is Time t &&
                   Seconds == t.Seconds;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Seconds);
        }

        public static bool operator ==(Time t, Time t2)
        {
            return t2.Equals(t);
        }
        public static bool operator !=(Time t, Time t2)
        {
            return !(t == t2);
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Time t = new Time()
                {
                    Hours = 9,
                    Minutes = 33,
                    Seconds = 43
                };
                Time t2 = new Time()
                {
                    Hours = 15,
                    Minutes = 02,
                    Seconds = 22
                };
                Console.WriteLine(t);
                Console.WriteLine(t2);
                Console.WriteLine(DateTime.Now);

                t++;
                Console.WriteLine(t);
                t--;
                Console.WriteLine(t);
                if (t > t2) Console.WriteLine("Time 1 bigger than time 2!");
                else Console.WriteLine("Time 1 not bigger than time 2!");

            }
        }
    }
}