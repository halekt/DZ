//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

//int numberA = 918;

//Console.WriteLine(numberA);

int temp5 =0;

    if (numberA > 999 || numberA <99 )
            {
                Console.WriteLine("Введите трехзначное число"); 
            }
    else
           temp5 = numberA/10;
           temp5 = temp5 % 10;
           Console.WriteLine($"Вторая цифра введённого числа: {temp5}");
           
    