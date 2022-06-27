using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Режимы: Сложение +, вычитание -, умножение *, деление /");
            string X = Convert.ToString(Console.ReadLine());
            string Plus;
            string Minus;
            string Umnoj;
            string Razdel;

            if (X == "+")
            {
                int C = A + B;
                Console.WriteLine("Ответ: " + C);
            }
            if (X == "-")
            {
                int C = A - B;
                Console.WriteLine("Ответ: " + C);
            }
            if (X == "*")
            {
                int C = A * B;
                Console.WriteLine("Ответ: " + C);
            }
            if (X == "/")
            {
                int C = A / B;
                Console.WriteLine("Ответ: " + C);
            }


            Console.ReadKey();

        }
    }
}
