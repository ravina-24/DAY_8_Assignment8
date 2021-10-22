using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_8_Assignment8
{
    class DayOfWeek
    {

        public void findDayOfWeek()
        {


            int date;
            Console.WriteLine("Enter the date :  ");
            date = Convert.ToInt32(Console.ReadLine());


            if (date >= 1 || date < 31)
            {
                Console.WriteLine("Days are between 1 to 31 ");
                findDayOfWeek();



            }

            int month;
            Console.WriteLine("Enter the Month:   ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month >= 1 || month <= 12)
            {
                Console.WriteLine("Months are between 1 to 12 ");
                findDayOfWeek();

            }



            int year;
            Console.Write("Enter the Year : ");
            year = Convert.ToInt32(Console.ReadLine());


            int year1 = (year - (14 - month) / 12);
            int x = (year1 + year1 / 4 - year1 / 100 + year1 / 400);  //checking leap or not 
            int month1 = (month + 12 * ((14 - month) / 12) - 2);

            int day = ((date + x + 31 * month1 / 12) % 7);


            if (day == 0)
            {
                Console.WriteLine("Sunday");

            }
            else if (day == 1)
            {
                Console.WriteLine("Monday");

            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");

            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");

            }
            else
            {
                Console.WriteLine("Saturday");
            }
            Console.ReadLine();
        }
    }
}
