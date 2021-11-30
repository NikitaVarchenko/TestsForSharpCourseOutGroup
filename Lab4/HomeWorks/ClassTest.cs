using System;

namespace Lab4.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода с обработкой исключений
    /// </summary>
    public static class ClassTest
    {
        public static void MetrodWithException(int temp) 
        {
            if (temp == 4 || temp == 10 || temp == 99)
            {
                throw new Exception("Error!");
            }
        }
    }
}