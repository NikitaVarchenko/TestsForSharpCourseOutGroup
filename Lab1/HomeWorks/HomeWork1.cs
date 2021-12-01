using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			int maxNegative = 0;
			int indexNegative = 0;
			int minPositive = 0;
			int indexPositive = 0;

			for (int i = 0; i<temp.Length;i++)
			{
				if (temp[i] < 0)
                {
					if (maxNegative == 0)
                    {
						maxNegative = temp[i];
						indexNegative = i;
					}
					else if (temp[i]< maxNegative)
                    {
						maxNegative = temp[i];
						indexNegative = i;
					}
				}

				if (temp[i] > 0)
				{
					if (minPositive == 0)
					{
						minPositive = temp[i];
						indexPositive = i;
					}
					else if (temp[i] < minPositive)
					{
						minPositive = temp[i];
						indexPositive = i;
					}
				}
			}

			int[] newArray = new int[temp.Length];

			for(int i = 0; i < newArray.Length; i++)
            {
				if (maxNegative == 0 || minPositive == 0)
				{
					return temp;
				}
				if (i == indexNegative)
				{
					newArray[i] = minPositive;
				}
				else if (i == indexPositive)
				{
					newArray[i] = maxNegative;
				}
                else
                {
					newArray[i] = temp[i];
				}
			}

			return newArray;
		}

		/// <summary>
		/// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
		/// </summary>
		/// <param name="temp">Исходный массив</param>
		/// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
		public static int Variant2(int[] temp)
		{
			int sum = 0;

			for (int i = 0; i < temp.Length; i++)
			{
				if (i % 2 == 0 && i != 0)
				{
					sum = sum + temp[i];
				}
			}

			return sum;
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

			for (int i = 0; i < temp.Length -1; i++)
			{
				if (temp[i] > 0 && temp[i+1] < 0)
				{
					temp[i] = temp[i] * 3;
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
			int sum = 0;
			int min = temp[0];

			for (int i = 0; i < temp.Length; i++)
			{
				if (temp[i] < min)
				{
					min = temp[i];
				}

				sum = sum + temp[i];
			}

			double srt = sum / (double)temp.Length;

			return (srt - min);
		}
	}
}
