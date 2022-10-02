// Задача на дни недели

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

Console.WriteLine("Такого дня нет дня недели");
break;

}