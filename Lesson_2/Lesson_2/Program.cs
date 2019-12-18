using System;

namespace Lesson_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Program.whichNumberIsMore();
            //Program.whichNumberIsMoreSmallVer();
            //Program.switchConstuct();
            //Program.countValue();
            //Program.countAge();
            //Program.sayHello();
            //Program.twoNumbers();
            //Program.foreachTest();
            //Program.conBreTest();
            //Program.arrInArr();
            //Program.Loop(20,34);
            //Program.notRecursive(100);
            //Console.Write(Program.Recursive(280));
            //Program.numberIsOdd(100);
            //Program.methodEuclid();
            //Program.summNumbersMoreTen();
            //Program.WriteYourOld();
            //Program.Ege9();
            //Program.FindSimpleNumber();
            //Console.WriteLine(Program.Factorial(29));
            //Console.WriteLine(Program.RecFactorial(5));
            //Console.WriteLine(Program.Fibonachi(10));
            //Console.WriteLine(Program.RecFibonachi(6, ""));
            //Console.WriteLine(Program.RecFactorial(5));
            //Program.Move();
            //Program.GetVal();
            //Program.GetCount();
            //Program.putTheNumbers();
            //Program.PutLoginAndPassword();
            //Program.CountIndexHumanBody();
            //Program.GoodNumbers();
            //Program.PutNumberFromAToB();
            Program.GetSumNumbersFromAToB();
        }
    }

    class Program
    {
        public static void whichNumberIsMore()
        {
            int a, b, max;
            Console.WriteLine("Введите два целых числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            Console.WriteLine("Наибольшее число {0}", max);
        }

        public static void whichNumberIsMoreSmallVer()
        {
            int a, b, max;
            Console.WriteLine("Введите два целых числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            max = a;
            if (b > max)
                max = b;

            Console.WriteLine("Наибольшее число {0}", max);
        }


        public static void switchConstuct()
        {
            int m = 6;
            string s;
            switch (m)
            {
                case 1:
                case 2:
                case 12:
                    s = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    s = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    s = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    s = "Осень";
                    break;
                default:
                    s = "Ничего";
                    break;
            }
            Console.WriteLine("Период года: {0}", s);
        }

        public static void countValue()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
        }

        public static void countAge()
        {
            int a, count = 0;

            do
            {
                Console.WriteLine("Введите ваш возраст:");
                a = int.Parse(Console.ReadLine());
                count++;
            }
            while (a < 1 || a > 99);
            Console.WriteLine("Вы сделали {0} попыток ввода", count);
        }

        public static void sayHello()
        {
            int count = 5;

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("{0} Привет мир", i);
            }
        }

        public static void twoNumbers()
        {
            int a, b, n, s;
            n = 0;
            s = 0;
            Console.WriteLine("Напишите значение буквы A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите значение буквы B");
            b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                for (int i = b; i >= a; i--)
                {
                    n++;
                    s = s + i;
                    Console.WriteLine("i = {0}, n = {1}, s = {2}", i, n, s);

                }
            }
            else
            {
                Console.WriteLine("Неверно введено значение!");
            }
        }

        public static void foreachTest()
        {
            string s = "Hello, my, man";
            foreach (char c in s)
                Console.WriteLine("{0}", c);
        }


        public static void conBreTest()
        {
            string s = "1. Привет, Foreach. \n2. А так же break и continue! А это не выведется";
            foreach (char c in s)
            {
                if (c >= '0' && c <= '9') continue;
                if (c == '!') break;
                Console.Write("{0}", c);
            }
        }

        public static void arrInArr()
        {
            for (int i = 0; i < 80; i++)
            {
                for (int k = 0; k < 24; k++)
                {
                    Console.SetCursorPosition(i, k);
                    Console.Write("*");
                    System.Threading.Thread.Sleep(20);
                }
            }
            Console.ReadKey();
        }

        public static void Loop(int a, int b)
        {
            Console.Write("{0, 4}", a);
            if (a < b) Loop(a + 1, b);
        }

        public static void notRecursive(long a)
        {
            long s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            Console.Write(s);
        }

        public static long Recursive(long a)
        {
            if (a != 0)
            {
                Console.Write(a / 10 + " - ");
                Console.Write(a % 10);
                Console.WriteLine(" Пойдет в рекурсию число = " + ((a / 10) + a % 10));
                return Recursive(a / 10) + a % 10;
            }
            else
            {
                return 0;
            }
        }
        //Вывести сумму цифр
        public static int SummCyfr(int n)
        {
            int s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            return s;
        }

        public static bool isOdd(int n)
        {
            return n % 2 == 0;
        }
        public static void numberIsOdd(int n)
        {
            for (int i = 1; i < n; i++)
            {
                int sc = SummCyfr(i);
                if (isOdd(sc)) Console.WriteLine("{0} {1}", i, sc);
            }
        }

        //Реализовать метод нахождения NOD, используя алгоритм Евклида: 
        public static int NOD(int a, int b)
        {
            while (a != b)
            {
                Console.WriteLine(a + " " + b);
                if (a > b) a = a - b;
                else b = b - a;
                Console.WriteLine(a + "-" + b);
            }
            return a;
        }

        public static void methodEuclid()
        {
            int a = 125;
            int b = 28;
            Console.WriteLine(NOD(a, b));
        }

        //Вывести в диапазоне от 10 до 100 все числа, сумма двух последних цифр которых равна 10:
        public static bool summNumbers(int a)
        {
            if ((a % 10 + a / 10 % 10 == 10)) return true; else return false;

        }

        public static void summNumbersMoreTen()
        {
            for (int i = 10; i <= 100; i++)
            {
                Console.Write(i + " - ");
                Console.WriteLine(summNumbers(i));
            }
        }

        //С клавиатуры вводится возраст от 1 до 50. Требуется написать программу, которая правильно определит, какое слово нужно написать после возраста. 

        //Вам 11 лет.
        //Вам 21 год.
        //Вам 33 года.
        public static void WriteYourOld()
        {
            int age;
            Console.WriteLine("Введите ваш возрост от 1 до 50");
            age = int.Parse(Console.ReadLine());
            Console.Write(GetYourOld(age));
        }

        public static string GetYourOld(int age)
        {
            string s = "Вам " + age;
            if (age % 10 == 1 && age != 11) s += " год";
            if (age == 11 || age >= 2 && age <= 4 || (age >= 22 && age <= 24) || (age >= 32 && age <= 34) || (age > 41 && age < 45)) s += " года";
            if ((age >= 5 && age <= 20) || (age >= 25 && age <= 30) || (age >= 35 && age < 41) || (age > 44 && age < 51)) s += " лет";
            return s;
        }

        //Напишите программу, которая в последовательности целых чисел определяет среднее арифметическое положительных чисел, кратных 8.
        //Программа получает на вход целые числа, среди них есть хотя бы одно положительное число, кратное 8,
        //количество введённых чисел неизвестно, последовательность чисел заканчивается числом 0 (0 - признак окончания ввода, не входит в последовательность).

        public static void Ege9()
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            int k = 0, s = 0;
            while (a != 0)
            {
                if (a > 0 && a % 8 == 0)
                {
                    k++;
                    s = s + a;
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine((double)s / k);
        }

        //Решим задачу нахождения простых чисел в диапазоне от 1 до 1000000.
        //Напишем метод проверки, является ли число простым, и используем его для подсчета количества чисел.
        //В начале цикла сохраним текущее время, по выходу
        //из цикла вычтем текущее время из сохраненного и выведем результат на экран.


        public static void FindSimpleNumber()
        {
            DateTime start = DateTime.Now;
            int k = 0;
            for (int i = 2; i < 5; i++)
            {
                Console.WriteLine(i);
                if (IsSimpleNumber(i))
                {

                    k++;
                    Console.WriteLine("{0}, {1}", k, i);
                }
            }
            Console.WriteLine(k);
            Console.WriteLine(DateTime.Now - start);
        }

        public static bool IsSimpleNumberOld(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSimpleNumber(int n)
        {
            Console.WriteLine(Math.Sqrt(n));
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                Console.WriteLine(i);
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Дано натуральное число n.Вычислить n!
        public static int Factorial(int n)
        {

            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(res);
                res *= i;
            }
            return res;
        }

        public static int RecFactorial(int n)
        {
            Console.WriteLine(n);
            if (n == 0)
            {
                Console.WriteLine("Из RecFactorial(" + n + ") не вызываем больше.");
                Console.WriteLine("RecFactorial(" + n + ") возвращает " + 1);
                return 1;
            }
            else
            {
                Console.WriteLine("Из RecFactorial(" + n + ") вызываем RecFactorial(" + (n - 1) + ")");
                int result = RecFactorial(n - 1) * n;//1*1=1*2=2*3=6*4=24*5=120;
                Console.WriteLine("RecFactorial(" + n + ") возвращает " + (result / n) + " * " + n + " = " + result);
                return result;
            }
        }

        //Последовательность Фибоначчи
        public static int Fibonachi(int n)
        {
            int a = 0;
            int b = 1;
            int c = b;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;//1//2//3//5
                a = b;//1//1//2//2
                b = c;//1//2//3//5
            }
            return b;
        }

        public static int RecFibonachi(int n, string s)
        {
            Console.WriteLine(s);
            if (n == 0)
            {
                Console.WriteLine("Из RecFibonachi(" + n + ") не вызываем больше.");
                Console.WriteLine("RecFibonachi(" + n + ") возвращает " + 0);
                return 0;

            }
            if (n == 1)
            {
                Console.WriteLine("Из RecFibonachi(" + n + ") не вызываем больше.");
                Console.WriteLine("RecFibonachi(" + n + ") возвращает " + 1);
                return 1;
            }
            var str1 = "Из первой функции RecFibonachi(" + n + ") вызываем RecFibonachi(" + (n - 1) + ")";
            var str2 = "Из второй функции RecFibonachi(" + n + ") вызываем RecFibonachi(" + (n - 2) + ")";
            int result = RecFibonachi(n - 1, str1) + RecFibonachi(n - 2, str2);
            return result;
        }

        //“Ханойская башня”

        public static void Move(int n = 4, int a = 1, int b = 2, int c = 3, string s = "", int finish = 0)
        {

            if (n > 0)
            {
                Console.WriteLine("Первая функция Move({0} - 1,{1},{2},{3}) - ", n, a, b, c);
                Move(n - 1, a, b, c, "Первая", 1);
                Console.WriteLine("{0} => {1}", a, b);
                Console.WriteLine("Вторая функция Move({0} - 1,{1},{2},{3}) - ", n, c, b, a);
                Move(n - 1, c, b, a, "Вторая", 2);
            }
            else
            {
                if (finish == 2 && n == 0)
                {
                    Console.WriteLine(s + " функция закончила цикл");
                }
                Console.WriteLine(s + " функция остановилась, потому что n - " + n);
            }

        }

        //Написать метод возвращающий минимальное из трех чисел;

        public static void GetVal()
        {
            Console.WriteLine("Впишите 3 значения");
            Console.WriteLine("Для a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Для b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Для c:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Самое минимальное значение - "+GetMinValFromThreeNumber(a, b, c));
        }

        public static int GetMinValFromThreeNumber(int a, int b, int c)
        {
            if(a < b && a < c)
            {
                return a;
            }
            if(b < a && b < c)
            {
                return b;
            }
            if(c < a && c < b)
            {
                return c;
            }
            return 0;
        }

        //Написать метод подсчета количества цифр числа;
        public static void GetCount()
        {
            Console.WriteLine("Введите число для подчета колличества цифр в нем");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Колличество цифр: " + GetCountCharInNumber(i));
        }

        public static int GetCountCharInNumber(int n)
        {
            var count = 0;
            while(n != 0){
                n = n / 10;
                count++;
            }
            return count;
        }

        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел;
        public static void putTheNumbers()
        {
            Console.WriteLine("Введите число для подсчета всех нечетных положительных чисел:");
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            int s = 0;
            while(n != 0)
            {
                Console.WriteLine("Вы ввели "+c+" чисел.");
                n = int.Parse(Console.ReadLine());
                c++;
                if (n % 2 != 0 && n >= 0)
                {
                    s = s + n;
                }
                if(n < 0)    
                {
                    Console.WriteLine("Ошибка! Вы ввели не положительное значение!");
                }
                
            }
            Console.WriteLine("Сумма нечетных чисел = " + s);
        }

        /*Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
        На выходе истина, если прошел авторизацию, и ложь, если не прошел.
        Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        С помощью цикла do while ограничить ввод пароля тремя попытками;*/

        public static void PutLoginAndPassword()
        {
            Console.WriteLine("Введите ваш Логин");
            var login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите ваш Пароль");
            var password = Convert.ToString(Console.ReadLine());
            //Вход
            EnterToSystem(login, password);
          
           
        }

        public static bool EnterToSystem(string login, string password)
        {
            int count = 3;
            var flag = false;
            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Чтобы войти введите ваш логин");
                var enterLog = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите ваш пароль");
                var enterPass = Convert.ToString(Console.ReadLine());
                Console.WriteLine("-------------------");

                if (enterLog == login && enterPass == password)
                {
                    Console.WriteLine("Вы удачно вошли в систему");
                    return true;
                }
                else
                {
                   
                    if (flag)
                    {
                        count--;
                        if (count != 0)
                        {
                            Console.WriteLine("Вы неверно ввели логин или пароль");
                            Console.WriteLine("Колличество попыток для входа в систему " + count);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы неверно ввели логин или пароль");
                        Console.WriteLine("Колличество попыток для входа в систему " + count);
                        flag = true;
                    }
                }
            }
            while (count != 0);
            Console.WriteLine("Доступ запрещен! Вы исчерпали колличество попыток на вход!");

            return false;
        }

        //Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        public static void CountIndexHumanBody()
        {
            Console.WriteLine("Введите свою массу:");
            var m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой рост:");
            var h = double.Parse(Console.ReadLine());

            var result = m / ((h * 0.01) * (h * 0.01));
            Console.WriteLine("Ваш идекс массы тела = " + result);

            int k = 0;
            bool flag = false;
            if(result < 16)
            {
                Console.WriteLine("У вас выраженный дефицит массы тела");
            }
            if (result >= 16 && result < 18.5 ){
                Console.WriteLine("Не достаточная(дефицит) массы тела");
            }
            if(result >= 18.5 && result < 25)
            {
                Console.WriteLine("Норма");
            }
            if (result >= 25 && result < 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение)");
                flag = true;
            }
            if(result >= 30 && result < 34)
            {
                Console.WriteLine("Ожирение первой степени");
                flag = true;
            }
            if (result >= 35 && result < 40)
            {
                Console.WriteLine("Ожирение второй степени");
                flag = true;
            }
            if (result >= 40)
            {
                Console.WriteLine("Ожирение третьей степени(морбидное)");
                flag = true;
            }

            int index = Convert.ToInt32(result);
            do
            {
                if (flag)
                {
                    index--;
                    k += 1;
                }
                else
                {
                    index++;
                    k += 1;
                }
                
            }
            while (index > 25 || index <= 18.5);

            if (flag)
            {
                Console.WriteLine("Вам необходимо похудеть на " + k + " кг");
            }
            else
            {
                Console.WriteLine("Вам необходимо потолстеть на " + k + " кг");
            }
        }
        /*Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000.
        Хорошим называется число, которое делится на сумму своих цифр.
        Реализовать подсчет времени выполнения программы, используя структуру DateTime. */

        public static void GoodNumbers()
        {
            DateTime start = DateTime.Now;
            int countNumber = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                int sumNumber = 0;
                int k = i;
                while(k > 0)
                {
                    sumNumber = sumNumber + k % 10;
                    k = k / 10;
                }
                if(sumNumber != 0)
                {
                    if (i % sumNumber == 0)
                    {
                        countNumber++;
                    }
                }
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Колличество хороших чисел = "+countNumber);
            Console.WriteLine("Программа выполнилась за:");
            Console.WriteLine(DateTime.Now - start);
        }
        //Разработать рекурсивный метод, который выводит на экран числа от a до b;
        public static void PutNumberFromAToB()
        {
            Console.WriteLine("Введите число A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int b = int.Parse(Console.ReadLine());

            ShowNumbers(a, b);
        }

        public static void ShowNumbers(int a, int b)
        {
            Console.WriteLine(a + " - " + b);
            if (a != b)
            {
                ShowNumbers(a, b-1);
            }            
        }


        //*Разработать рекурсивный метод, который считает сумму чисел от a до b.

        public static void GetSumNumbersFromAToB() {
            Console.WriteLine("Введите число A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int b = int.Parse(Console.ReadLine());

            int res = 0;

            res = CountSum(a, b ,res);

            Console.WriteLine("Сумма чисел = " + res);
        }

        public static int CountSum(int a, int b, int res)
        {
            Console.WriteLine(a + " - " + b);
            if(b != a)
            {
                res = res + b;
                CountSum(a, b - 1, res);
                
            }
            return res;
        }
    }
}
