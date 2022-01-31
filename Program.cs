using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1   //Сейдалы Бекасыл
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какое задание вы хотите посмотреть? \n1)Анкета \n2)Вес и рост чела \n3)Расстояние между точками \n4)Поменять значение переменных чисел \n5)Вывести на центре консоди данные \n6)Пауза\n\nВведите номер задании: ");
            int TaskNum = int.Parse(Console.ReadLine());

            if (TaskNum == 1)
            {
                Task1();
            }
            else if (TaskNum == 2)
            {
                Task2();
            }
            else if (TaskNum == 3)
            {
                Task3();
            }
            else if (TaskNum == 4)
            {
                Task4();
            }
            else if (TaskNum == 5)
            {
                Task5();
            }
            else if (TaskNum == 6)
            {
                Task6();
            }
        }
        static void Task1()
        {
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Ваше Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Ваш рост: ");
            string height = Console.ReadLine();
            Console.Write("Ваш вес: ");
            string weight = Console.ReadLine();

            Console.Write("Как вы хотите вывести информацию? 1)Склеивание 2)Форматированный вывод 3)Со знаком $ ");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine(name + " " + surname + " " + age + " лет " + height + " см " + weight + " кг ");
                Console.ReadLine();
            }
            else if (x == 2)
            {
                Console.WriteLine("{0} {1} {2} лет {3} см {4} кг", name, surname, age, height, weight);
                Console.ReadLine();
            }
            else if (x == 3)
            {
                Console.WriteLine($"{name} {surname} {age} лет {height} см {weight} кг");
                Console.ReadLine();
            }
        }
        static void Task2()
        {
            Console.Write("Ваш рост (Если 185 писать 1,85): ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Ваш вес: ");
            int m = int.Parse(Console.ReadLine());
            double i = m / (h * h);
            Console.WriteLine($"ИМТ: {i}");
            Console.ReadLine();
        }
        static void Task3()
        {
            Console.Write("Введите x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            int y2 = int.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Ответ: {0:f2}", r);
            Console.ReadLine();

        }
        static void Task4()
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = 0;

            Console.Write("Как вы хотите решить задание? 1)с использованием третьей переменной 2)без использования третьей переменной: ");
            int method = int.Parse(Console.ReadLine());
            if (method == 1)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;
                Console.WriteLine("==============================================");
                Console.WriteLine("Первое число теперь: {0}, Второе число: {1}", num1, num2);
                Console.ReadLine();
            }
            else if (method == 2)
            {
                num1 = num1 - num2;
                num2 = num2 + num1;
                num1 = num2 - num1;
                Console.WriteLine("==============================================");
                Console.WriteLine("Первое число теперь: {0}, Второе число: {1}", num1, num2);
                Console.ReadLine();
            }
        }
        static void Task5()
        {
            Console.Write("Ваше имя: ");
            string name1 = Console.ReadLine();
            Console.Write("Ваше Фамилия: ");
            string surname1 = Console.ReadLine();
            Console.Write("Ваш город: ");
            string country1 = Console.ReadLine();
            print(name1, surname1, country1);
            Console.ReadLine();
        }
        static void Task6()
        {
            Console.Write("На сколько секунд вы хотите приостановить программу? ");
            int o = int.Parse(Console.ReadLine());
            o = o * 1000;

            for(int p = 0; p < 5; p++)
            {
                Console.WriteLine(p + 1);
                Pause(o);
            }
        }
        static void print(string a, string b, string c)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("{0} {1} {2} (не меняте размер экрана)", a, b, c);
        }
        static void Pause(int x)
        {
            System.Threading.Thread.Sleep(x);
        }
    }
}
