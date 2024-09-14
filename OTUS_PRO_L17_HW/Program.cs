using OTUS_PRO_L17_HW.FileClasses;
using OTUS_PRO_L17_HW.Extension;

namespace OTUS_PRO_L17_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>
                {
                    "привет", // 6 букв
                    "доброе", // 6 букв
                    "утро", // 4 буквы
                    "программирование", // 19 букв
                    "интернет", // 8 букв
                    "машина", // 7 букв
                    "отлично", // 8 букв
                    "время", // 5 букв
                    "компьютер", // 10 букв
                    "книга", // 5 букв
                    "погода", // 6 букв
                    "город", // 5 букв
                    "работа", // 6 букв
                    "счастье", // 8 букв
                    "жизнь" // 5 букв
                };
            var longest = strings.GetMax(s => s.Length);
            Console.WriteLine($"Самая длинная строка: {longest}");

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            var searcher = new FileSearcher();
            searcher.FileFound += SearcherFileFound;
            searcher.Search(Directory.GetCurrentDirectory());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

        private static void SearcherFileFound(object? sender, FileArgs e)
        {
            Console.WriteLine("Найден файл: " + e.FileName);
            if (e.FileName.Contains(".exe"))
            {
                e.Cancel = true;
            }
        }
    }
}
