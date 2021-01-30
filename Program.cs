using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchClockRadioJan29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, time to rise & shine with a Scratch Clock Radio!!!");
            Console.WriteLine("");
            ScratchClockRadio myclockAlarmRadio = new ScratchClockRadio("6:00 a.m.", "102.5", true, "6:35 a.m.");
            Console.WriteLine("Your clock says that the time is: " + myclockAlarmRadio.time);
            Console.WriteLine("");
            Console.WriteLine("I set the radio to your favorite FM station, " + myclockAlarmRadio.radioStation + ", and set the alarm for " + myclockAlarmRadio.alarmTime);
            Console.WriteLine("");
            bool alarmOn = true;
            if (alarmOn)
            {
                Console.WriteLine("I turned your alarm 'ON' ... I know it's early!");
                Console.ReadLine();
            }
        }
    }
}
