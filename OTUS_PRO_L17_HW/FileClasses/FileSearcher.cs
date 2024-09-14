namespace OTUS_PRO_L17_HW.FileClasses
{
    /// <summary>
    ///  Класс, обходящий каталог файлов и выдающий событие при нахождении каждого файла
    /// </summary>
    public class FileSearcher
    {
        public event EventHandler<FileArgs> FileFound;
        /// <summary>
        /// Поиск файлов в указанном каталоге
        /// </summary>
        /// <param name="directory"></param>
        public void Search(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Console.WriteLine($"Каталог не существует: {directory}");

                return;
            }

            foreach (var file in Directory.GetFiles(directory))
            {
                var args = new FileArgs(file);

                OnFileFound(args);

                if (args.Cancel)
                {
                    Console.WriteLine("Поиск отменён");
                    break;
                }
            }
        }
        /// <summary>
        /// Метод, вызывающий событие
        /// </summary>
        /// <param name="args"></param>
        public void OnFileFound(FileArgs args)
        {
            FileFound?.Invoke(this, args);
        }
    }
}
