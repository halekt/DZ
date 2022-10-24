﻿//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] table = new int[3, 4];
FillArray(table);
PrintArray(table);

if (rows < table.GetLength(0) && colums < table.GetLength(1))
    Console.WriteLine($"{rows}{colums} -> {table[rows, colums]}");
else Console.WriteLine($"{rows}{colums} -> Такого числа в массиве нет");

void FillArray(int[,] array) // инициализация массива FillArray 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); //// Заполнили массив числами
        }
    }
}

void PrintArray(int[,] array) // Вывод массива и индекса массива на экран 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message) // Функция ввода 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

