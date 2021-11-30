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
            int lengthMax = 0;
            string min = temp[0];
            int lengthMin = temp[0].Length;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Length >= lengthMax)
                {
                    max = temp[i];
                    lengthMax = temp[i].Length;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {

                if (temp[i].Length <= lengthMin)
                {
                    min = temp[i];
                    lengthMin = temp[i].Length;
                }
            }
            return (max, lengthMax, min, lengthMin);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            string str;
            string res = null;
            int c = 0;


            for (int i = 0; i < temp.Length; i++)
            {
                int countNum = 0;
                str = temp[i];
                for (int j = 0; j < str.Length; j++)
                {
                    if(str[j] == '0' ||
                       str[j] == '1' ||
                       str[j] == '2' ||
                       str[j] == '3' ||
                       str[j] == '4' ||
                       str[j] == '5' ||
                       str[j] == '6' ||
                       str[j] == '7' ||
                       str[j] == '8' ||
                       str[j] == '9')
                    {
                        countNum++;
                    }else
                    {
                        countNum = 0;
                    } 
                }
                if(countNum != 0)
                {
                    c++;
                    res = temp[i];
                    if (c == 2)
                        return res;
                }
            }
            return res;
        }

    }
}