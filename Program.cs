﻿// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A ");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число B ");
// int b = Convert.ToInt32 (Console.ReadLine());

// int GetSqt ()
// {
//     int numb = Convert.ToInt32 (Math.Pow(a,b));
//     return numb;
// }

// Console.WriteLine("A в степени B = " + GetSqt());


// --------------------------------------
// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int num =  Convert.ToInt32 (Console.ReadLine());

// int GetSum()
// {
//     int sum = 0;
//     int ostatok = 0;
//     while (num != 0)
//     {
//         ostatok = num % 10;             // получаем остаток от числа, то есть последний символ числа
//         num = num/10;                   // Удаляем последнее число в цепочке 
//         sum = sum + ostatok;            //суммируем полученный последний символ числа 
//     }
//     return sum;
// }
// Console.WriteLine("Сумма цифр = " + GetSum());


// ------------------------------------------
// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] GetArray ()
{
    int [] array = new int [8];
    for (int i =0; i< array.Length; i++)
    {
        Console.Write("Введите [" + i + "] элемент: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
    }
    return array;
}
Console.WriteLine(String.Join(",",GetArray()));
