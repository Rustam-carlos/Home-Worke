using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Составить программу вывода на экран в одну строку трех " +
                "любых чисел с двумя пробелами между ними.");
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);

            Console.Write(a + "  " + b + "  " + c);
            Console.WriteLine("\n");

            Console.WriteLine("2.Вывести на экран числа 5, 10 и 21 одно под другим.");
            Console.WriteLine(@"5
10
21");
            Console.WriteLine("\n");
            Console.WriteLine("3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            Console.WriteLine("Введите расстояние в см :");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Полных м: ");
            Console.WriteLine(i / 100);
            Console.WriteLine("\n");

            Console.WriteLine("4.	С некоторого момента прошло 234 дня. " +
                "Сколько полных недель прошло за этот период?");
            Console.Write("Полных прошло: 33 недели ");
            Console.WriteLine("\n");

            Console.WriteLine("5.Дано двузначное число. Найти:" +
            "a.число десятков в нем; b.число единиц в нем;" +
            "c.сумму его цифр; d.произведение его цифр");
            Console.WriteLine("Введите двузначное число :");
            int x = int.Parse(Console.ReadLine());
            int y = x / 10;
            int z = x - (y * 10);
            Console.Write("В вашем числе колличество десяток равно : ");
            Console.WriteLine(y);
            Console.Write("В вашем числе колличество единиц равно : ");
            Console.WriteLine(z);
            Console.Write("Сумма его цифр равна : ");
            Console.WriteLine(y + z);
            Console.Write("произведение его цифр равна : ");
            Console.WriteLine(y * z);

            Console.WriteLine(" 6.Вычислить значение логического выражения при" +
                "следующих значениях логических величин А, В и С: А = Истина, " +
                "В = Ложь, С = Ложь: a.А или В; b.А и В; c.В или С.");
            bool A = true;
            bool B = false;
            bool C = false;
            bool result = A || B;
            bool result2 = A && B;
            bool result3 = B || C;
            Console.WriteLine("А или В = " + result);
            Console.WriteLine("А и В = " + result2);
            Console.WriteLine("В или С = " + result3);

            Console.WriteLine("7.Даны радиус круга и сторона квадрата.У какой фигуры площадь больше ?");

            Console.WriteLine("Введите радиус круга");
            int r;
            int.TryParse(Console.ReadLine(), out r);
            double sr = 3.14 * (r * r);

            Console.WriteLine("Введите сторону квадрата");
            int h;
            int.TryParse(Console.ReadLine(), out h);
            double sh = h * 2;
            if (sr > sh)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше площади круга");

            };


            Console.WriteLine("Даны объемы и массы двух тел из разных материалов." +
                "Материал какого из тел имеет большую плотность ?");
            Console.WriteLine("Введите объем первого тела в м.куб: ");
            int q1;
            int.TryParse(Console.ReadLine(), out q1);
            Console.WriteLine("Введите массу первого тела в кг. : ");
            int m1;
            int.TryParse(Console.ReadLine(), out m1);
            double p1 = m1 / q1;

            Console.WriteLine("Введите объем второго тела в м.куб: ");
            int q2;
            int.TryParse(Console.ReadLine(), out q2);
            Console.WriteLine("Введите массу второго тела в кг. : ");
            int m2;
            int.TryParse(Console.ReadLine(), out m2);
            double p2 = m2 / q2;
            if (p1 > p2)
            {
                Console.WriteLine("Первое тело имеет большую плотность");
            }
            else
            {
                Console.WriteLine("Второе тело имеет большую плотность");

            };


            Console.WriteLine("Известны сопротивления двух несоединенных друг с другом" +
                "участков электрической цепи и напряжение на каждом из них. По какому" +
                "участку протекает меньший ток?");
            Console.WriteLine("Введите сопротивление на первом участке цепи : ");
            int R1;
            int.TryParse(Console.ReadLine(), out R1);
            Console.WriteLine("Введите напряжение на первом участке цепи : ");
            int U1;
            int.TryParse(Console.ReadLine(), out U1);
            int I1 = U1 / R1;

            Console.WriteLine("Введите сопротивление на втором участке цепи : ");
            int R2;
            int.TryParse(Console.ReadLine(), out R2);
            Console.WriteLine("Введите напряжение на втором участке цепи : ");
            int U2;
            int.TryParse(Console.ReadLine(), out U2);
            int I2 = U2 / R2;

            if (I1 > I2)
            {
                Console.WriteLine("По первому участку цепи протекает больший ток");
            }
            else
            {
                Console.WriteLine("По второму участку цепи протекает больший ток");

            };

            Console.WriteLine("10. Напечатать столбиком :" +
            "a.все целые числа от 20 до 35;" +
            "b.квадраты всех целых чисел от 10 до b" +
            "(значение b вводится с клавиатуры; b > 10);" +
            "c.третьи степени всех целых чисел от a до 50" +
            "(значение a вводится с клавиатуры; a < 50);" +
            "d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).");
            Console.WriteLine("пункт а. выполнение");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("пункт b. выполнение");
            Console.WriteLine("Введите целое число больше десяти : ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine();
            for (int i = 10; i <= n; i++)
            {
                Console.WriteLine(i * i);
            }

            Console.WriteLine("пункт c. выполнение");
            Console.WriteLine("Введите целое число меньше пятидесяти : ");
            int n2;
            int.TryParse(Console.ReadLine(), out n2);
            Console.WriteLine();
            for (int i = n2; i <= 50; i++)
            {
                Console.WriteLine(i * i * i);
            }

            Console.WriteLine("пункт d. выполнение");
            Console.WriteLine("Введите целое число начало диапазона : ");
            int n3;
            int.TryParse(Console.ReadLine(), out n3);
            Console.WriteLine("Введите целое число конец диапазона : ");
            int n4;
            int.TryParse(Console.ReadLine(), out n4);
            Console.WriteLine();
            for (int i = n3; i <= n4; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
