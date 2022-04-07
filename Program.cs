using System;

namespace GenericTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime JavaD = new DateTime(1995,05,23);
            ProgLanguage Java = new ProgLanguage("Java",JavaD);
            DateTime CSharpD = new DateTime(2000,07,08);
            ProgLanguage CSharp = new ProgLanguage("C#",CSharpD);

            Collections<ProgLanguage> collection = new Collections<ProgLanguage>();
            collection.Add(Java);
            collection.Add(CSharp);

            collection.SortDate();
            collection.SortLang();
            foreach (ProgLanguage item in collection.language)
            {
                Console.WriteLine(item.Language, item.Date);
            }
        }
    }
}
