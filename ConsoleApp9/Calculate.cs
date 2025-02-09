using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Calculate
    {
        public double num1;
        public double num2;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Calculate() { }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="num1"></param>
        public Calculate(double num1)
        {
            this.num1 = num1;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public Calculate(double num1, double num2) : this(num1)
        {
            this.num2 = num2;
        }
        /// <summary>
        /// Метод формирования строки с информацией об обьекте
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Первое число: {num1}, Второе число: {num2}");
        }
        /// <summary>
        /// Метод обработки значения полей
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Результат: {Math.Sqrt(num1 * num2):F1}";
        }
    }
}
