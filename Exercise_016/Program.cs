// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = ReadInt("Введите число N: ");
int sum = 0;
for (int i = 1; i <= number; i++)
{ 
     sum += number % 10;
        number /= 10;
    
}
Console.WriteLine($"сумма цифр {sum}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
