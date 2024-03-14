using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeChapter9
{
    public class SerialDate
    {
        private int day;
        private int month;
        private int year;

        private SerialDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public static SerialDate CreateInstance(int day, int month, int year)
        {
            return new SerialDate(day, month, year);
        }

        public static SerialDate AddMonths(int monthsToAdd, SerialDate date)
        {
            DateTime dateTime = new DateTime(date.GetYYYY(), date.GetMonth(), date.GetDayOfMonth());

            // Add months
            dateTime = dateTime.AddMonths(monthsToAdd);

            // Convert DateTime back to SerialDate
            SerialDate newDate = SerialDate.CreateInstance(dateTime.Day, dateTime.Month, dateTime.Year);

            return newDate;
        }

        public int GetDayOfMonth()
        {
            return this.day;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public int GetYYYY()
        {
            return this.year;
        }
    }
}
