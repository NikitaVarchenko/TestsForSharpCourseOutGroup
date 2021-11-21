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
        public static double Calculator(double x, double y, char mathOperation)
        {
            double calcul = 0;
            switch (mathOperation)
            {
                case '+': calcul = x + y; break;
                case '-': calcul = x - y; break;
                case '*': calcul = x * y; break;
                case '/':
                    {
                        if (y == 0)
                        {
                            Console.WriteLine("Деление на ноль не поддерживается.");
                            calcul = 0;
                            throw new Exception();
                        }
                        else
                        {
                            calcul = x / y;
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Укажите одну из операций: +, -, *, /");
                        calcul = 0;
                        throw new Exception();
                        break;
                    }

            }

            return calcul;
        }
    }
}