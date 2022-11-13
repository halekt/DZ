//Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
//N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Numbers(number, count);

void Numbers(int number, int count)
{
    if (count > number)
    {
        return;
    }
    else
    {
        Numbers(number, count + 1);
        Console.Write(count + " ");
    }
}
