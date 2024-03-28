// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Рекурсия. Метод расчёта элемента в промежутке от M до N
int SummElemetsOfDiapazon (int m, int n)
{
    if (n == m) return m;
    else return SummElemetsOfDiapazon(m, n - 1) + 1;
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
    if (M < 1) M = 1; 
    int sum = 0;
    for (int i = M; i <= N; i++)
    {
    sum = sum + SummElemetsOfDiapazon(M , i);
    }

    Console.Write($"Сумма натуральных элементов в диапазоне от {M} до {N} равна {sum} ");
}

