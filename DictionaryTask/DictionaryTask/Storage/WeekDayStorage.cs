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

        public static void AddWeekDays()
        {
            WeekDays.Add(1, "Ponedjeljak");
            WeekDays.Add(2, "Utorak");
            WeekDays.Add(3, "Srijeda");
            WeekDays.Add(4, "Četvrtak");
            WeekDays.Add(5, "Petak");
            WeekDays.Add(6, "Subota");
            WeekDays.Add(7, "Nedjelja");
        }
    }
}
