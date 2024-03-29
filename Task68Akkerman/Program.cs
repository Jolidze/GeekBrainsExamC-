// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// метод вычисления функции Аккермана
double Akkerman (double m, double n)
{
    if (m == 0 ) return n + 1;
    else // m > 0
    {
        if (n == 0) return Akkerman(m -1 , 1);
        else return Akkerman(m - 1, Akkerman (m, n - 1));
    }
}

// основная программа
Console.Clear(); //Очистка консоли, для удобства
Console.Write ("Введите неотрицательное число M: ");
double M = Convert.ToDouble(Console.ReadLine());
while (M < 0)
{
    Console.Write("Ошибка ввода. Введите неотрицательное число: ");
    M = Convert.ToDouble(Console.ReadLine()); 
}

Console.Write ("Введите неотрицательное число N: ");
double N = Convert.ToDouble(Console.ReadLine());
while (N < 0)
{
    Console.Write("Ошибка ввода. Введите неотрицательное число: ");
    N = Convert.ToDouble(Console.ReadLine()); 
}


Console.Write($"А({M}, {N}) = {Akkerman (M , N)}");
