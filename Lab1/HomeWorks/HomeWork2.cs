namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            string max = temp[0];
            string min = temp[0];

            for (int i = 0; i < temp.Length; i++) 
            {
                if (temp[i].Length >= max.Length) max = temp[i];
                if (temp[i].Length <= min.Length) min = temp[i];
            }
            return (max, max.Length, min, min.Length);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            string result = null;

            for (int i = 0; i < temp.Length; i++) if (int.TryParse(temp[i], out _ )) result = temp[i];
            return result;
        }
    }
}