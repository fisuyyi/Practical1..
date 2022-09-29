using System.Numerics;

namespace ПР1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, deyst;
            do
            {
                Console.WriteLine("Доступны следующие арифметические операции: \n 1. Сложение \n 2. Вычитание  \n 3. Умножение \n 4. Деление \n 5. Возведение числа в степень \n 6. Нахождение квадратного корня \n 7. Нахождение одного процента от числа \n 8. Нахождение факториала \n 9. Выход    ");
                Console.Write("Введите арифметическую операцию: ");
                deyst = int.Parse(Console.ReadLine());

                switch (deyst)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (a + b));
                        break;

                    case 2:
                        Console.Write("Введите первое число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (a - b));
                        break;

                    case 3:
                        Console.Write("Введите первое число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (a * b));
                        break;

                    case 4:
                        Console.Write("Введите первое число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (a / b));
                        break;

                    case 5:
                        Console.Write("Введите число, возводимое в степень: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + Math.Pow(a, b));
                        break;

                    case 6:
                        Console.Write("Введите число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + Math.Sqrt(a));
                        break;

                    case 7:
                        Console.Write("Введите число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (a * 0.01));
                        break;

                    case 8:
                        Console.Write("Введите число, факториал которого вы хотите найти: ");
                        BigInteger c = Convert.ToInt32(Console.ReadLine());
                        BigInteger d = 1;
                        for (BigInteger i = c; i >= 1; i--)
                            d *= i;
                        Console.WriteLine("Ответ: " + d);

                        break;
                    default:
                        Console.WriteLine("Ошибка! Вы ввели неверный номер операции. \nПожалуйста введите номер операции заново!");
                        break;


                }
            } while (deyst != 9);

        }
    }
}