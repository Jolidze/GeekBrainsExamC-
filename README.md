# Итоговая контрольная работа по основному блоку

## Задача
Написать программу, которая 
* из **имеющегося массива строк** 
* формирует **новый массив из строк**, длина которых меньше, либо равна **_3 символам_**. 

## Ограничения
1. Первоначальный массив:
   * можно ввести с клавиатуры, 
   * либо задать на старте выполнения алгоритма. 
 
 2. При решении __не рекомендуется__ пользоваться коллекциями, лучше обойтись исключительно массивами.

 ## Описание решения

 1. Задать исходный массив строк, вводом с клавиатуры:
  *  запросить у пользователя длину будущего массива, запомнить её (*здесь просятся проверки на то, что введено корректное число - целое положительное, не пустое, не текст, не отрицательное; в текущей версии это не реализуется*)
  *  создать массив строк заданной длины
  *  запросить у пользователя ввод каждого элемента массива, заполнить массив введёнными значениями
  *  для информации, вывести пользователю на экран какой получился исходный массив элементов
 2. Определить длину нового массива = посчитать количество элементов в исходном массиве с длинной элемента не более 3 символов (*здесь создаю более универсальный метод, чтобы 3 не было забито гвоздями, а можно было задавать*)
 3. Сформировать новый массив строк, длина которых не более 3 символов
 * для информации, вывести пользователю на экран новый массив элементов 

 ## Автор решения
 ![Автор решения](newme.jpg)
