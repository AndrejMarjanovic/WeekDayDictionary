using DictionaryTask.Service;

class Program
{
    static void Main()
    {
        Actions();
    }

    static void Actions()
    {
        DictionaryService service = new DictionaryService();
        service.DisplayDictionary();
        service.FindOne();
        service.ChangeToEnglish();
        service.FindTuesday();
    }
}