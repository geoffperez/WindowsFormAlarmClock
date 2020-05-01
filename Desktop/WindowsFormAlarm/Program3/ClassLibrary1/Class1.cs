using System;
using System.Text;

namespace ClassLibrary1
{
    public class AlarmTime : Time2
    {

        private string AlarmMessage;
        private int snoozeamount;

        public AlarmTime()
        {
            clearstringbuilder();
        }

        public void setTime(string msg, int hour = 0, int minute = 0, int second = 0)
        {

            SetTime(hour, minute, second);
            AlarmMessage = msg;
            //clearstringbuilder();
        }

        public string GetMessage
        {
            get { return AlarmMessage; }
        }



        public string Time()
        {

            return base.ToString();
        }


        public string Snooze() =>

             $"{AlarmMessage}";


    }
}
