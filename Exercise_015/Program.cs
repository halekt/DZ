// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Сделать в функции, сделать проверку на отрицательность.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



bool not_numbers = true; 
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число В: ");
int b = int.Parse(Console.ReadLine());

int result = 1;  

if ( a < 0 || b < 0 )
{

//not_numbers = false; 
result = 0;
//Console.WriteLine("Нет  чисел!");  

}
else
    for( int i = 0; i < b; i++)
    {
    result*=a;
    not_numbers = false; 
    }
    
Console.WriteLine($"Число {a} в степени {b} равно {result} ");