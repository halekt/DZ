// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] mas = (FillArray(5)); // ввел размер массива FillArra и передал его в mas
PrintArray(mas); // передал данные массива  в PrintArray

int [] FillArray (int num) // инициализация массива FillArray 
{
    int [] temp = new int[num]; // temp это num, а num это FillArray

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(1, 10); // указал сколько чисел будет в одном размере массива
    }
    return temp; // вернул данные temp в FillArray
}

int sum = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (i % 2 != 0) // != означает неравенство. i % 2 означает остаток от деления переменной i на 2 не равно 0, то число нечетное
    {
        sum += mas[i]; // суммируем нечетные числа
    }
}
Console.WriteLine($"всего {mas.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void PrintArray(int[] array) //Вывод массива и индекса массива на экран 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}