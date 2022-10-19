
/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */



int [] mas = (FillArray(5)); // ввел размер массива FillArra и передал его в mas
PrintArray(mas); // передал данные массива  в PrintArray

int [] FillArray (int num) // инициализация массива FillArray 
{
    int [] temp = new int[num]; // temp это num, а num это FillArray

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(99, 999); // указал сколько чисел будет в одном размере массива
    }
    return temp; // вернул данные temp в FillArray
}

int count = 0;
for (int i = 0; i < mas.Length; i++)
if (mas[i] % 2 == 0)   // n % 2 проверяем n - четное или нет, 0 четное 1 не четное
count++;

Console.WriteLine($"всего {mas.Length} чисел, {count} из них чётные");

void PrintArray(int[] array) //Вывод массива и индекса массива на экран 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}