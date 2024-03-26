﻿// Задача 66. 
// Задайте значения M и N
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
// Например M = 1; N = 15 -> 120
// Например M = 4; N = 8 -> 30

// Метод расчёта суммы натуральных элементов в промежутке от M до N
int SumOfNaturalMembers (int a, int b)
{
    int sum = 0;
    // в идеале, ещё бы проверить а и b на то что они целые, и если не целые, то найти ближайшее целое больше а и меньше b, и выполнить цикл с ними
    // но понимаю, что изначально с консоли забираю только int, потому не заморачиваюсь
    while ( a <= b )
    {
        if (a > 0) sum = sum + a;
        a++;
    }

    return sum;  
}


// Основная программа
Console.Clear(); //Очистка консоли, для удобства
Console.Write ("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// проверю, что есть интервал, что N > M
// проверю, что есть интервал с натуральными числами, N > 0
if (N <= M || N <= 0) 

{
    Console.WriteLine ("В промежутке от " + M + " до " + N + " нет натуральных элементов, нечего складывать.");
}
else
{
    Console.WriteLine ("Сумма натуральных элементов в промежутке от " + M + " до " + N + " равна " + SumOfNaturalMembers(M, N));
}

