// Нахождение индекса элемента 

int [] array =  {1, 2 , 5 , 8 , 10 , 12};

int n = array.Length;

int find = 10; // 10 - число которое нужно найти в массиве

int index = 0;

while(index < n )
{
    if(array[index] ==find) // находит индекс заданного числа
    {
        Console.WriteLine(index); // показывает индекс найденного числа
    }

    index++;

}