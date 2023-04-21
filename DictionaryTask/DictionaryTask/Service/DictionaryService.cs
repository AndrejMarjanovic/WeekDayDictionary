using DictionaryTask.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask.Service
{
    public class DictionaryService
    {
        public async Task DisplayDictionary()
        {
            Console.WriteLine("Days of week are: ");
            Console.WriteLine("-----------------");
            foreach (var weekday in WeekDayStorage.WeekDays)
            {
                Console.WriteLine("day: {0}, Name: {1}", weekday.Key, weekday.Value);
            }
            Console.WriteLine();
        }

        public async Task ReturnDayByKey()
        {
     
            var Day =  WeekDayStorage.WeekDays.FirstOrDefault(x => x.Key == 1).Value;
            if(Day != null)
            {
                Console.WriteLine("Day with the key 1 is: {0}", Day);
            }

            Console.WriteLine();
        }

        public async Task ChangeToEnglish()
        {
            for (int i = WeekDayStorage.WeekDays.First().Key; i <= WeekDayStorage.WeekDays.Count; i++)
            {
                WeekDayStorage.WeekDays[i] = Enum.GetName(typeof(DayOfWeek), i % 7);
                
            }

            await DisplayDictionary();

        }

        public async Task FindWeekday()
        {

            int DayKey = WeekDayStorage.WeekDays.FirstOrDefault(x => x.Value == "Tuesday").Key;
            if (DayKey != 0)
            {
               WeekDayStorage.WeekDays.Remove(DayKey);
            }

            await DisplayDictionary();
        }

        public async Task AddWeekday()
        {
            WeekDayStorage.WeekDays.Add(2, "Tuesday");
            Thread.Sleep(0);

            await DisplayDictionary();
        }
    }
}
