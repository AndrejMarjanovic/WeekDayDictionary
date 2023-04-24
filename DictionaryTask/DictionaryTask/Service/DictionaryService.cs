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
            var days = await WeekDayStorage.GetDaysAsync();

            Console.WriteLine("Days of week are: ");
            Console.WriteLine("-----------------");
            foreach (var weekday in days)
            {
                Console.WriteLine("day: {0}, Name: {1}", weekday.Key, weekday.Value);
            }
            Console.WriteLine();
        }

        public Task ReturnDayByKey()
        {     
            string Day =  WeekDayStorage.WeekDays.FirstOrDefault(x => x.Key == 1).Value;
            if(Day != null)
            {
                Console.WriteLine("Day with the key 1 is: {0}", Day);
            }

            Console.WriteLine();

            return Task.FromResult(Day);
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
