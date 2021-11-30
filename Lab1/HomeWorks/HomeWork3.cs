using System;

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
        public static double Calculator(double x, double y, char mathOperation = '+')
        {
            double res = 0;

            switch (mathOperation)
            {
                case '+':
                    res = x + y;
                    break;
                case '-':
                    res = x - y;
                    break;
                case '*':
                    res = x * y;
                    break;
                case '/':
                    res = x / y;
                    if (y == 0)
                    {
                        throw new System.Exception("Деление на ноль запрещено!");
                    }
                    break;
                default:
                    {
                        throw new System.Exception("Ошибка");
                    }
            }
            return res;
        }

    }
}