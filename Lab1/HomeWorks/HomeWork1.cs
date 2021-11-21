using System;
using System.Linq;

namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        { 
            int min = 0;
            int max = 1000000;
            int n = -1;
            int m = -1;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i]<0)
                {
                    if (temp[i] < min)
                    { 
                        min = temp[i];
                        n = i;
                    } 
                }
                else
                { 
                    if (temp[i] < max)
                    {
                        max = temp[i];
                        m = i;
                    }
                }
            }

            if ((n != -1) && (m != -1))
            {
                temp[n] = max;
                temp[m] = min;
            }
            
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
        {   
        int summ = 0;
            for (int i = 0; i < temp.Length; i+=2)
            {
                summ += temp[i];
            }
            return summ;
        }

        /// <summary>
        /// В массиве целых чисел заменить нулями отрицательные элементы.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
        public static int[] Variant3(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    temp[i] = 0;
                }
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
        public static int[] Variant4(int[] temp)
        {
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if ((temp[i+1] < 0) && (temp[i] >= 0))
                {
                    temp[i] *= 3 ;
                    Console.WriteLine(temp[i]);
                }
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
        public static double Variant5(int[] temp)
        {
            int w = 0;
            int i = 0;
            int min = temp[1];
              for (i = 0; i < temp.Length; i++)
              {
                     w += temp[i];
    
                  if (temp[i] < min)
                  {
                     min = temp[i];
                  }
              }
            double x = (double)w / i - min;
            
            return x;
        }
    }
}