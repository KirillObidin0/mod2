using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task6();
        }
        public static void task1()
        {
            //1.Написать программу, которая считывает символы с 
            //    клавиатуры, пока не будет введена точка.Программа 
            //    должна сосчитать количество введенных пользователем 
            //    пробелов.
            string str = Console.ReadLine();
            string res = str.Substring(0, str.IndexOf('.'));
            int counter = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == ' ') counter++;
            }
            Console.WriteLine(counter);
        }
        public static void task2()
        {
            //2.Ввести с клавиатуры номер трамвайного билета(6 - значное число)
            //    и проверить является ли данный билет счастливым(если на билете 
            //        напечатано шестизначное число, и сумма первых трёх цифр равна 
            //        сумме последних трёх, то этот билет считается счастливым).
            string number = Console.ReadLine();
            if (Convert.ToInt32(number[0])+ Convert.ToInt32(number[1])+ 
                Convert.ToInt32(number[2])== Convert.ToInt32(number[3])+ 
                Convert.ToInt32(number[4])+ Convert.ToInt32(number[5]))
            {
                Console.WriteLine("Ticket is lucky!");
            }
            else
            {
                Console.WriteLine("Ticket is unlucky.");
            }
        }
        public static void Task3()
        {
            //3.Числовые значения символов нижнего регистра в коде ASCII 
            //    отличаются от значений символов верхнего регистра на 
            //    величину 32.Используя эту информацию, написать программу, 
            //которая считывает с клавиатуры и конвертирует Домашнее задание 
            //    №1 Домашнее задание № все символы нижнего регистра в символы 
            //    верхнего регистра и наоборот.
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    str[i] = Convert.ToChar(str[i] + 32);
                else if (str[i] >= 'a' && str[i] <= 'z')
                    str[i] = Convert.ToChar(str[i] - 32);

            }
            Console.WriteLine(str);
            //Console.WriteLine(Convert.ToChar('a'-32));
        }
        public static void Task4()
        {
            //4.Даны целые положительные числа A и B(A<B). 
            //Вывести все целые числа от A до B включительно;
            //каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество 
            //    раз, равное его значению. Например: если А = 3, 
            //    а В = 7, то программа должна сформировать в консоли 
            //    следующий вывод: 
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void Task5()  
        {
            //5.Дано целое число N(> 0), найти число, полученное 
            //    при прочтении числа N справа налево. Например, 
            //если было введено число 345, то программа должна вывести 
            //    число 543.
            string str = Console.ReadLine();
            int n = Int32.Parse(string.Format("{0}", str.Reverse()));
            Console.WriteLine(n);
        }
        public static void Task6()
        {
            //6.Составить программу вывода на экран в 
            //    одну строку трех любых чисел с двумя 
            //    пробелами между ними.
          Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}  ",rnd.Next(10000));
            }
            Console.WriteLine();
        }
        public static void Task7()
        {
            //7.Вывести на экран числа 5, 10 и 21 одно под другим.
          Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        public static void Task8()
        {
            //8.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            int sm = 250;
            int m = sm / 100;
            Console.WriteLine(m);
        }
        public static void Task9()
        {
            //9.С некоторого момента прошло 234 дня.
            //    Сколько полных недель прошло за этот период ?
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine(weeks);
        }
        public static void Task10()
        {
            //10.Дано двузначное число. Найти:
            //a.число десятков в нем;
            //b.число единиц в нем;
            //c.сумму его цифр;
            //d.произведение его цифр

            int n = 25;
            Console.WriteLine(n/10);
            Console.WriteLine(n%10);
            Console.WriteLine(n/10+n%10);
            Console.WriteLine(n/10*n%10);
        }
    }
}
