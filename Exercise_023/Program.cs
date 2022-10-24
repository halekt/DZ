//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:  ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] table = new double[rows, colums];

void PrintArray(double[,] tab) // Вывод массива и индекса массива на экран 
{
    for (int rows = 0; rows < tab.GetLength(0); rows++) // указали 0 потому что в массиве строки начинаются с 0 
    {
        for (int colums = 0; colums < tab.GetLength(1); colums++) // указали 1 потому что в массиве  столбцы начинаются с 1 
        {
            Console.Write($"{tab[rows, colums],4} "); // обращаемся к массиву  строк и столбцов
        }
        Console.WriteLine(); // что бы отделить числа друг от друга 
    }
}

void FillArray(double[,] tab) // инициализация массива FillArray 
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int colums = 0; colums < tab.GetLength(1); colums++)
        {
            tab[rows, colums] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; // Заполнили массив числами
        }
    }
}


FillArray(table);
Console.WriteLine(); // что бы отделить столбцы друг от друга 
PrintArray(table); // вывод заполненных данных массива на экран 