using DictionaryTask.Service;
using System.ComponentModel.Design;

class Program
{
    private static DictionaryService service = new DictionaryService();
    static void Main()
    {
        Actions();
    }

    static async void Actions()
    {
        await service.DisplayDictionary();
        await service.ReturnDayByKey();
        await service.ChangeToEnglish();
        await service.FindWeekday();
        await service.AddWeekday();
    }
}