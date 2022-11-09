using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Операции калькулятора: \n1. Сложить 2 числа \n2. Вычесть первое из второго \n3. Перемножить два числа\n4. Разделить первое на второе\n5. Возвести в степень N первое число \n6. Найти квадратный корень из числа\n7. Найти 1 процент от числа\n8. Найти факториал из числа \n9. Выйти из программы");
            // я капли в нос потеряла где то, помогите
            do
            {
                Console.WriteLine("Выберите дейтствие, которое хотит осуществить: ");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Введите первое число: ");
                        double chislo1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double chislo2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{chislo1}+{chislo2}={chislo1 + chislo2}");
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число: ");
                        double chislo12 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double chislo22 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{chislo22}-{chislo12}={chislo22 - chislo12}");
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число: ");
                        double chislo13 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double chislo23 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{chislo13}*{chislo23}={chislo13 * chislo23}");
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число: ");
                        double chislo14 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double chislo24 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{chislo14}/{chislo24}={chislo14 / chislo24}");
                        break;
                    case 5:
                        Console.WriteLine("Введите первое число: ");
                        double chislo5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень: ");
                        double degree = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{chislo5}**{degree}={Math.Pow(chislo5, degree)}");
                        break;
                    // вот знаете в чем беда, я подумала, что степень как в паскале крышечками(^) такими делается, а в итоге нет(
                    case 6:
                        Console.WriteLine("Введите число: ");
                        double chislo6 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"квадратный корень из {chislo6}={Math.Sqrt(chislo6)}");
                        break;
                    case 7:
                        Console.WriteLine("Введите число: ");
                        double chislo7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"1% от {chislo7}={chislo7 / 100}");
                        break;
                    case 8:
                        Console.WriteLine("Введите число: ");
                        double chislo8 = Convert.ToDouble(Console.ReadLine());
                        int factorial = 1;
                        for (int i = 2; i <= chislo8; i++)
                        {
                            factorial = factorial * i;
                        }
                        Console.WriteLine($"!{chislo8}={factorial}");
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибочка(((((( Введенная вами цифра не входит в диапазон");
                        break;
                }
            }
            while (true);
        }
    }
}