//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, акакое меньшее.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
    Console.WriteLine("Первое число " + a + " больше чем второе " + b);
else
    Console.WriteLine("Второе число " + b + " больше чем первое " + a);


