// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача: Напишите программу которая принимает на вход координаты точки (X и Y), причем X не равно 0 и Y не равно 0 и 
// выдает номер четверти плоскости, в которой находится эта точка.

void chetvert (int x, int y) // void это функция которая ничего не возвращает 
{
    if ( x > 0 && y > 0)
        Console.WriteLine("Координаты точки X и Y принадлежат к 1-ой четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("Координаты точки X и Y принадлежат к 2-ой четверити");
    else if (x < 0 && y < 0)
        Console.WriteLine("Координаты точки X и Y принадлежат к 3-ей четверити");
    else if (x > 0 && y < 0)
        Console.WriteLine("Координаты точки X и Y принадлежат к 4-ой четверити");
    
}

int x;
int y;
Console.Write("Введите число X: ");
    x = int.Parse(Console.ReadLine());
Console.Write("Введите число Y: ");
    y = int.Parse(Console.ReadLine());

chetvert(x,y); // результат расчета функции void