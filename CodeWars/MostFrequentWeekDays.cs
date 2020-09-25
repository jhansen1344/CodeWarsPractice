using System;
using System.Collections;

namespace CodeWars
{
    public class Kata
    {
        public static string[] MostFrequentDays(int year)
        {
            var startDate = new DateTime(year, 1, 1);
            var endDate = new DateTime(year, 12, 31);

            var firstDay = startDate.DayOfWeek;
            var arrayLength = 1;
            var returnArray = new string[1] { firstDay.ToString() };
            while (endDate.DayOfWeek.ToString() != firstDay.ToString())
            {
                arrayLength += 1;
                Array.Resize<string>(ref returnArray, arrayLength);
                returnArray[arrayLength - 1] = endDate.DayOfWeek.ToString();
                endDate = endDate.AddDays(-1);
            };
            return returnArray;
        }
    }
}
