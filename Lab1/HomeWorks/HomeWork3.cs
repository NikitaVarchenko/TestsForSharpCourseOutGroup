using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.HomeWorks
{
	/// <summary>
	/// Метод калькулятор
	/// Исходные условия: Метод принимает два числа и знак операции.
	/// </summary>
	public class HomeWork3
	{
		/// <summary>
		/// Метод калькулятора
		/// </summary>
		/// <param name="x">Первый операнд</param>
		/// <param name="y">Второй операнд</param>
		/// <param name="mathOperation">Знак операции</param>
		/// <returns>Результат вычисления</returns>
		public static double Calculator(double x, double y, char mathOperation)
		{
			double result = 0;

			if (y==0 && mathOperation == '/')
            {
				throw new System.Exception("Деление на ноль!");
			}

			switch (mathOperation)
			{
				case '+':
				{
				 result = x + y;
				 break;
				}
				case '-':
				{
					result = x - y;
					break;
				}
				case '*':
				{
					result = x * y;
					break;
				}
				case '/':
				{
					result = x / y;
					break;
				}
				default:
                {
					throw new System.Exception("Неправильный символ!");
				}
			}

			return result;
		}
	}
}
