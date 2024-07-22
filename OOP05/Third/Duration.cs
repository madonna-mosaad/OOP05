using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Third
{
    internal class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public override bool Equals(object? obj)
        {
            Duration duration = (Duration) obj ;
            return this == duration ;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            if (hours == 0) 
            { 
                if (minutes == 0)
                {
                    return $"Seconds : {seconds}";
                }
                return $"Minutes : {minutes}, Seconds : {seconds}";
            }
            return $"Hours : {hours}, Minutes : {minutes}, Seconds : {seconds}";
        }

        public Duration(int hours, int minutes, int seconds )
        {
            if (hours >= 0 && minutes >= 0 && seconds >= 0)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
            }
        }
        public Duration(int seconds)
        {
            if (seconds >= 0)
            {
                hours = seconds / 3600;
                seconds %= 3600;
                minutes = seconds / 60;
                this.seconds = seconds % 60;
            }
        }

        public static Duration operator +(Duration a, Duration b) 
        { 
            return new Duration(a.hours+b.hours,a.minutes+b.minutes,a.seconds+b.seconds);
        }
        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration(a.hours - b.hours, a.minutes - b.minutes, a.seconds - b.seconds);
        }
        public static Duration operator +(int a, Duration b)
        {
            return new Duration(a + (b.hours*3600 + b.minutes*60 +b.seconds));
        }
        public static Duration operator +(Duration a, int b)
        {
            return new Duration((a.hours * 3600 + a.minutes * 60 + a.seconds)+b);
        }
        public static Duration operator ++(Duration a)
        {
            return new Duration(a.hours,a.minutes+1,a.seconds);
        }
        public static Duration operator --(Duration a)
        {
            return new Duration(a.hours, a.minutes - 1, a.seconds);
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (((a?.hours ?? 0) * 3600 + (a?.minutes ?? 0) * 60 + (a?.seconds ?? 0)) < ((b?.hours ?? 0) * 3600 + (b?.minutes ?? 0) * 60 + (b?.seconds ?? 0)))
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Duration a, Duration b)
        {
            if (((a?.hours??0) * 3600 + (a?.minutes??0) * 60 + (a?.seconds??0)) < ((b?.hours??0) * 3600 + (b?.minutes ??0)* 60 + (b?.seconds??0)))
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            if (((a?.hours ?? 0) * 3600 + (a?.minutes ?? 0) * 60 + (a?.seconds ?? 0)) <= ((b?.hours ?? 0) * 3600 + (b?.minutes ?? 0) * 60 + (b?.seconds ?? 0)))
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Duration a, Duration b)
        {
            if (((a?.hours ?? 0) * 3600 + (a?.minutes ?? 0) * 60 + (a?.seconds ?? 0)) >= ((b?.hours ?? 0) * 3600 + (b?.minutes ?? 0) * 60 + (b?.seconds ?? 0)))
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Duration a, Duration b)
        {
            if (((a?.hours ?? 0) * 3600 + (a?.minutes ?? 0) * 60 + (a?.seconds ?? 0)) == ((b?.hours ?? 0) * 3600 + (b?.minutes ?? 0) * 60 + (b?.seconds ?? 0)))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Duration a, Duration b)
        {
            if (((a?.hours ?? 0) * 3600 + (a?.minutes ?? 0) * 60 + (a?.seconds ?? 0)) != ((b?.hours ?? 0) * 3600 + (b?.minutes ?? 0) * 60 + (b?.seconds ?? 0)))
            {
                return true;
            }
            return false;
        }
        public static explicit operator DateTime(Duration duration) 
        {
            DateTime now = DateTime.Now;
            return new DateTime( now.Year , now.Month, now.Day, (duration?.hours ?? 0), (duration?.minutes??0), (duration?.seconds ?? 0));
        }
        public static implicit operator bool(Duration duration) 
        { 
               return duration != null;
        }
    }
}
