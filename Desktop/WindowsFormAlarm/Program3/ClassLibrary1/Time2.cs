using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Time2 : IComparable<Time2>
    {
        private int hour; //0-23
        private int hour2;
        private int minute;//0-59
        private int second;//0-59
        private bool AMorPM;
        StringBuilder sb = new StringBuilder("");
        StringBuilder sb2 = new StringBuilder("");

        public Time2()
        {



        }




        public int CompareTo(Time2 obj, AlarmTime obj2)
        {
            if (obj.Hour == obj2.Hour && obj.Minute == obj2.Minute)
            {
                if (obj.Second == obj2.Second)
                {
                    return 1;
                }
                else return 0;
            }
            else
                return 0;
        }

        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }


        public void clearstringbuilder()
        {
            sb2.Clear();
            sb.Clear();
        }



        public void Addtime(int h, int m, int s)

        {
            int newhour = h + hour;
            int newminute = m + minute;
            int newsecond = s + second;
            sb.Clear();
            sb2.Clear();

            if (newsecond >= 60)
            {
                newsecond = newsecond % 60;
                newminute++;
            }
            if (newminute >= 60)
            {
                newminute = newminute % 60;
                newhour++;
            }
            if (newhour >= 24)
            {
                newhour = newhour % 24;
            }


            SetTime(newhour, newminute, newsecond);

        }



        public void Addtime(Time2 time)

        {

            Addtime(time.Hour, time.Minute, time.Second);



        }


        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Hour)}must be 0-23");
                }
                hour = value;
                hour2 = resetHour(value);
                AMorPM = MorningorAfternoon(value);

                if (value <= 9)
                {
                    sb.Append("0" + value + ":");
                    sb2.Append("0" + hour2 + ":");

                }
                else
                {
                    sb.Append(value + ":");
                    sb2.Append(hour2 + ":");
                }

                //sb2.Append(hour2 + ":");
            }

        }



        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(minute)}must be 0-59");
                }
                minute = value;
                if (value <= 9)
                {
                    sb.Append("0" + value + ":");
                    sb2.Append("0" + value + ":");
                }
                else
                {
                    sb.Append(value + ":");
                    sb2.Append(value + ":");
                }


            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(second)}must be 0-59");
                }
                second = value;
                if (value <= 9)
                {
                    sb.Append("0" + value);
                    sb2.Append("0" + value);
                    if (AMorPM == true) { sb2.Append(" AM"); }
                    else sb2.Append(" PM");
                }
                else
                {
                    sb.Append(value);
                    sb2.Append(value);
                    if (AMorPM == true) { sb2.Append(" AM"); }
                    else sb2.Append(" PM");
                }

            }
        }

        public int resetHour(int hour)
        {
            if (Hour == 0)
            {
                return 12;
            }
            if (Hour > 12)
            {
                return hour % 12;
            }
            else return hour;
        }

        public bool MorningorAfternoon(int hour)
        {
            if (hour < 12)
            {
                return true;
            }
            else return false;
        }

        /* public virtual string ToUniversalString() =>

              $"{sb}";
 */

        public override string ToString() =>

             $"{sb2}";

        int IComparable<Time2>.CompareTo(Time2 other)
        {
            throw new NotImplementedException();
        }
    }
}