// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. 
//Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 10]
//63, 12, 33, 36 -> [9, 3, 6, 9]



int lenArray = ReadInt("Введите длинну массива: ");
int[] randomArray = new int[lenArray];
int sum = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,8);
    Console.Write(randomArray[i] + " ");

    sum += randomArray[i];

}
 Console.WriteLine($"сумма цифр {sum}");

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}