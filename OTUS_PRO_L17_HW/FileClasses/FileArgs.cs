namespace OTUS_PRO_L17_HW.FileClasses
{
    /// <summary>
    /// Класс, содержащий аргументы события FileFound
    /// </summary>
    public class FileArgs : EventArgs
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Флаг отмены поиска
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// Конструктор, принимающий имя файла
        /// </summary>
        /// <param name="fileName"></param>
        public FileArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}
