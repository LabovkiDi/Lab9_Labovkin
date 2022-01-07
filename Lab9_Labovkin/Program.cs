using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 2 целых числа x и y\n");
            if (int.TryParse(Console.ReadLine(), out int x) && int.TryParse(Console.ReadLine(), out int y))
            //проверем, можно ли получить число из строки. Если возможно, то возвращается out параметр.
            {
                Calc(x, y);
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в число");
            }

            Console.ReadLine();
        }

        static void Calc(double x, double y) /*напишем метод Calc*/
        {
            string mathsactions;
            Console.WriteLine("Выберите операции:\n1\n2\n3\n4\n");
            mathsactions = Console.ReadLine();

            switch (mathsactions)
            //номер case обозначает арифметические операции: 1 - "+";2 - "-";3 - "*";4-"/"
            {
                case "1":
                    Console.WriteLine(x + y);
                    break;
                case "2":
                    Console.WriteLine(x - y);
                    break;
                case "3":
                    Console.WriteLine(x * y);
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine(x / y);
                    }

                    catch (DivideByZeroException e) /*проверяем деление на 0*/
                    {
                        Console.WriteLine("Ошибка!\t" + e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка! Нет операции с указанным номером");
                    break;
            }
        }
    }
}
