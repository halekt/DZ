// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
// 32679 -> 6

int num;
int numDigit;
Console.Write("Введите любое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            string numStr = Convert.ToString(num);
            numDigit = numStr.Length;
            if (numDigit > 2) 
            Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
            else Console.WriteLine("третьей цифры нет");
            
