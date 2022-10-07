//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int wday;
Console.Write("Введите день недели (1-7): ");
wday = Convert.ToInt32(Console.ReadLine());
switch (wday)
{
case 7:
Console.WriteLine("Воскресенье");
break;
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
case 6:
Console.WriteLine("Суббота");
break;
Console.WriteLine("Введите день недели");
break;

Console.ReadLine();
default:

Console.WriteLine("Такого нет дня недели");
break;

}

if (wday >= 1 && wday <= 7)
            {
                if (wday == 6 | wday == 7) Console.WriteLine("Сегодня выходной");
                else Console.WriteLine("Сегодня рабочий день");
            }

