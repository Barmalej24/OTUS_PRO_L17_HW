namespace OTUS_PRO_L17_HW.Extension
{
    public static class EnumerableExtension
    {
        /// <summary>
        /// Обобщённая функция расширения, находящая и возвращающая первый максимальный элемент коллекции
        /// </summary>
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null || !collection.Any())
            {
                return null;
            }

            float max = float.MinValue;
            T maxElement = null;

            foreach (var element in collection)
            {
                float number = convertToNumber(element);

                if (number > max)
                {
                    max = number;
                    maxElement = element;
                }
            }

            return maxElement;
        }
    }
}
