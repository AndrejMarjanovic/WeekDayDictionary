using DictionaryTask.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask.Storage
{
    public class WeekDayStorage
    {
        public static IDictionary<int, string> WeekDays { get; set; }

        static WeekDayStorage ()
        {
            WeekDays = new Dictionary<int, string> ();
            AddWeekDays();
        }

        public static Task<IDictionary<int,string>> GetDaysAsync()
        {
            return Task.FromResult(WeekDays);
        }

        public static void AddWeekDays()
        {
            WeekDays.Add(1, Weekdays.Monday);
            WeekDays.Add(2, Weekdays.Tuesday);
            WeekDays.Add(3, Weekdays.Wednesday);
            WeekDays.Add(4, Weekdays.Thursday);
            WeekDays.Add(5, Weekdays.Friday);
            WeekDays.Add(6, Weekdays.Saturday);
            WeekDays.Add(7, Weekdays.Sunday);
        }
    }
}
