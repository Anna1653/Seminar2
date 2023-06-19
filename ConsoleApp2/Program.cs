/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

Console.Write("Введите число: ");
int num = int.Parse (Console.ReadLine());

if (num < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    int i = 0;
    List<int> numbers = new List<int>();
    while (num > 10)
    {
       numbers.Add(num % 10);
       num = num / 10;
       i++;
    }
    int result = numbers[numbers.Count - 2];
    Console.WriteLine($"Третья цифра: {result}");
}


