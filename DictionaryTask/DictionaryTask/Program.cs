using DictionaryTask.Service;
using System.ComponentModel.Design;

class Program
{
    private static DictionaryService service = new DictionaryService();
    static void Main()
    {
        service.DisplayDictionary();
        Actions();
    }

    static void Actions()
    {
        service.ReturnDayByKey();
        service.ChangeToEnglish();
        service.FindWeekday();
        service.AddWeekday();
    }
}