
using System;

namespace DAY_8_Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calender calender = new Calender();
            calender.printCalender();

            DayOfWeek dayOfWeek = new DayOfWeek();
            dayOfWeek.findDayOfWeek();
        }
    }
}

