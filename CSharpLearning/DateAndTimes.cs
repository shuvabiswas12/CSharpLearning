using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class DateAndTimes
    {
        public DateAndTimes()
        {
            GetTodaysDate();
            YesterdaysDate();
            TomorrowsDate();
            GetYears();
            GetMonths();
            GetDays();
            GetCurrentTime();
            GetCurrentTimespan();
            GetTimespan();
            GetCurrentTimestamp();
        }

        static void YesterdaysDate()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            Console.WriteLine("Yesterday : " + yesterday.ToLongDateString());
            Console.WriteLine("Yesterday short date: " + yesterday.ToShortDateString());
        }

        static void TomorrowsDate()
        {
            var tomorrow = DateTime.Now.AddDays(1);
            Console.WriteLine("Tomorrow : " + tomorrow.ToLongDateString());
            Console.WriteLine("Tomorrow short date: " + tomorrow.ToShortDateString());
        }

        static void GetTodaysDate()
        {
            var todaysDateTime = DateTime.Today;
            Console.WriteLine("Todays date and time is : " + todaysDateTime);

            var todaysShortDate = todaysDateTime.ToShortDateString();
            Console.WriteLine("Todays Short Date is : " + todaysShortDate);

            var todaysLongDate = todaysDateTime.ToLongDateString();
            Console.WriteLine("Todays Long Date is : " + todaysLongDate);

            Console.WriteLine("Current Time is : " + DateTime.Now.ToString("t"));
        }

        static void GetYears()
        {
            var thisYear = DateTime.Today.Year;
            Console.WriteLine("This year is : " + thisYear);
        }

        static void GetMonths()
        {
            var thisMonth = DateTime.Today.Month;
            Console.WriteLine("This month is : " + thisMonth);
        }

        static void GetDays()
        {
            var days = DateTime.Now.Day;
            Console.WriteLine("This day is : " + days);
        }


        static void GetCurrentTime()
        {
            var currentTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine("Current Time is : " + currentTime);
        }

        static void GetCurrentTimespan()
        {
            var timespan = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            Console.WriteLine("Timespan: " + timespan);
        }

        static void GetTimespan()
        {
            Console.WriteLine(TimeSpan.FromHours(7));
        }

        static void GetCurrentTimestamp()
        {
            var now = new DateTime(2022, 5, 8);
            Console.WriteLine(now);
            var timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            Console.WriteLine(@"Timestamp: {0}", timestamp);

            // this is preferable
            var timestamp_v2 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            Console.WriteLine(@"Timestamp: {0}", timestamp_v2);

            // finding date time from a timestamp value
            GetDateTimeFromTimestamp(timestamp_v2);
        }

        static void GetDateTimeFromTimestamp(long timestamp)
        {
            var dateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
            // I am converting utc time to local bangladesh time adding 6.0 hours extra
            Console.WriteLine(@"Datetime from timestamp: {0}", dateTime.AddHours(6.0));
        }
    }
}
