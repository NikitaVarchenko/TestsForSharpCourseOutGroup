using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			string min = temp[0];
			string max = temp[0];

			for (int i = 0; i < temp.Length; i++)
			{
				if (temp[i].Length <= min.Length)
				{
					min = temp[i];
				}

				if (temp[i].Length >= max.Length)
				{
					max = temp[i];
				}
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
			List<string> word = new List<string>();

			for (int i = 0; i < temp.Length; i++)
			{
				char[] a = temp[i].ToCharArray();

				bool numberWorld = true;

				if (temp[i].Length == 0)
				{
					numberWorld = false;
				}

				for (int j = 0; j < a.Length; j++)
				{
					if (!Char.IsNumber(a[j]))
					{
						numberWorld = false;
						break;
					}         
				}

				if (numberWorld == true)
				{
					word.Add(temp[i]);
				}
			}

			if (word.Count == 0)
			{
				return null;
			}
			else if (word.Count > 1)
			{
				return word[1];
			}
			else
			{
				return word[0];
			}

		}
	}
}
