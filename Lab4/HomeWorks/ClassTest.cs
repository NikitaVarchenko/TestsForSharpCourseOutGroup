using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода с обработкой исключений
    /// </summary>
    public static class ClassTest
    {
        public static void MetrodWithException(int temp)
        {
            if(temp == 10 || temp == 4 || temp == 99)
            {
                throw new Exception($"Value should not be 10, 4 or 99!");
            }
        }
    }
}
