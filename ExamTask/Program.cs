// Метод. Определить длину нового массива = посчитать количество элементов в исходном массиве с длинной элемента не более 3 символов
int CountNoMoreSymbols (string[] ar, int c) //количество символов можно задать, так метод будет универсальнее
{
    int Len = ar.Length;
    int inIndex = 0;   
    int counter = 0;                         

    while (inIndex < Len) 
    {
        if (ar[inIndex].Length <= c)
        counter++;
        inIndex++;
    }

    return counter;
}

// Метод. Сформировать новый массив строк, длина которых не более 3 символов
string[] ArrayNoMoreSymbols (string[] array, int count)
{
    if (CountNoMoreSymbols(array, count) == 0) //если таких элементов нет, возвращаем пустой массив и выходим
    {
        string[] outArray = new string[0];
        return outArray;
    }
    else 
       {int inIndex = 0;                            
        int outIndex = 0;
        string[] outArray = new string[CountNoMoreSymbols(array, count)];  //создаём новый массив, длину его вычисляем отдельным методом   

        while (inIndex < array.Length) 
        {
            if (array[inIndex].Length <= count)
            {
                outArray[outIndex] = array[inIndex];
                outIndex++;
            }
            inIndex++;
        }
        return outArray;
       }

}

// Задать исходный массив строк, вводом с клавиатуры: 
Console.WriteLine("Задайте, пожалуйста, массив строк. "); //  запросить у пользователя длину будущего массива
Console.Write("Для начала, укажите длину будущего массива: ");
int inLen = Convert.ToInt32(Console.ReadLine()); // запомнить длину
while (inLen < 1 ) // провеерить корректность длины
{
    Console.Write("Ошибка ввода. Введите положительное целое число: ");
    inLen = Convert.ToInt32(Console.ReadLine()); 
}
//*********** а как проверить что целые? а как проверить что не пусто? что не текст? может, если ошибка преобразования то .... не приоритетно

string[] inArray = new string[inLen]; //  создать массив строк заданной длины

//  запросить у пользователя ввод каждого элемента массива, заполнить массив введёнными значениями
int i = 0;
while (i < inLen)
{
    Console.Write("Введите элемент массива с индексом " + i + " : ");
    inArray[i] = Console.ReadLine();
    i++;
}

Console.WriteLine("Вы задали массив: [" + string.Join(",", inArray ) + "]"); // для информации, вывести пользователю на экран какой получился исходный массив элементов 
string[] res = ArrayNoMoreSymbols(inArray, 3); //Сформировать новый массив строк, длина которых не более 3 символов
Console.WriteLine("Новый массив элементов, c длинной не более 3 символов: [" + string.Join(",", res ) + "]"); // для информации, вывести пользователю на экран новый массив элементов 


