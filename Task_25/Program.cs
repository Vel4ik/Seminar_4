﻿while (true)
{
    Console.WriteLine("Введите next для продолжения или end для выхода");
    string Operator = Console.ReadLine();
    if (Operator == "end")
    {
        break;
    }
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Pow(number1, number2));
}