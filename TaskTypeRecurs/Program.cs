﻿// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        Task4();
        // Task5();
        // Task6();
        // Task7();
    }
    #region Задача 1
    //     1. Написать метод, рассчитывающий число из рада Фиббоначчи используя
    // рекурсию
    static void Task1()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int number0 = 0;
        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            int sum = number0 + result;
            number0 = result;
            result = sum;
        }
        Console.WriteLine(result);
        Console.WriteLine(NumberFibonaci(number));
    }
    static int NumberFibonaci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return NumberFibonaci(n - 2) + NumberFibonaci(n - 1);
    }
    #endregion
    #region Задача 2
    //     2. Дано натуральное число (вводится с клавиатуры). Вычислите сумму его цифр
    // используя рекурсию

    // static void Task2()
    // {
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine(NumberSumm(number));
    // }
    // static int NumberSumm(int n)
    // {
    //     if (n == 0 )
    //     {
    //         return 0;
    //     }
    //     return ;
    // }

    #endregion
    #region Задача 3
    // 3. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите все простые
    // делители этого числа используя рекурсию
    // static void Task3()
    // {
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine(NumberDivider(number));
    // }
    // static int NumberDivider(int n)
    // {
    //     if (n == 0 )
    //     {
    //         return 0;
    //     }
    //     return ;
    // }
    #endregion
    #region Задача 4
    // 4. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите «Точная
    // степень двойки», если число является точной степенью двойки, или «Не
    // являеться степенью двойки», в противном случае используя рекурсию.
    static void Task4()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(NumberPOW2(number));
    }
    static int NumberPOW2(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine("Точная степень двойки");
            return NumberPOW2(n / 2);
        }
        else
        {
            Console.WriteLine("Не являеться степенью двойки");
            return 0;
        }
    }
    #endregion
    #region Задача 5
    // 5. Написать метод возвращающий индекс максимального и минимального
    // значения массива (два способа используя кортеж и out).
    
    #endregion
    #region Задача 6
    // 6. На входе 2 числа, написать метод по замене местами чисел в переменных, если
    // первое число кратно двум, второе не кратно и первое число меньше двух
    // (результат вернуть в виде кортежа)
    #endregion

    #region Задача 7.
    // 7. Дана строка. Написать метод по подсчёту количеству вхождений символа
    // (подстроки). Метод возвращает символ (подстроку), количество вхождений, перое
    // и последнее вхождение в строку. (использовать IndexOf, LastIndexOf, Split и тд
    // запрещено)
    static void Task7()
    {
        string? text = Console.ReadLine();
        string? symbol = Console.ReadLine();
        if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
        {
            Console.WriteLine(MethodAllSearch(text, symbol));
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    static (string, int, int, int) MethodAllSearch(string text, string symbol)
    {
        int count = 0;
        int indexFirst = -1;
        int indexLast = -1;
        int LengthSymbol = symbol.Length;
        for (int i = 0; i <= text.Length - LengthSymbol; i++)
        {
            string temp = "";
            for (int j = i; j <= i + (LengthSymbol - 1); j++)
            {
                temp += text[j];
            }
            if (temp == symbol)
            {
                if (indexFirst == -1)
                {
                    indexFirst = i;
                }
                indexLast = i;
                count++;
            }
        }
        return (symbol, count, indexFirst, indexLast);
    }
    #endregion
}

