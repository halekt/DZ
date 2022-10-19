// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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

int maxFillarray = mas[0]; // создана переменная массива максимум 
int minFillarray = mas[0]; // создана переменная массива минимум 

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > maxFillarray) // если число массива больше максимум 
    {
        maxFillarray = mas[i]; // то это число записываем в максимум 
    }
    if (mas[i] < minFillarray) // если число массива меньше минимума 
    {
        minFillarray = mas[i]; // то это число записываем в минимум 
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}"); // считаем и выводим на экран разницу между максимальным и минимальным элементов массива.

void PrintArray(int[] array) //Вывод массива и индекса массива на экран 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}