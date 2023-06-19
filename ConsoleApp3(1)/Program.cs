/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите день недели в числовом формате: ");
int number = int.Parse(Console.ReadLine());

string day = null;
switch (number)
{
    case (1):
        day = "Понедельник";
        break;
    case (2):
        day = "Вторник";
        break;
    case (3):
        day = "Среда";
        break;
    case (4):
        day = "Четверг";
        break;
    case (5):
        day = "Пятница";
        break;
    case (6):
        day = "Суббота";
        break;
    case (7):
        day = "Воскресенье";
        break;
    default:
        Console.WriteLine("Такого дня недели не существует)))");
        break;
}
if (day != null)
{
    if ( number > 6)
    {
        Console.WriteLine($"{day} - выходной день");
    }   
    else
    {
        Console.WriteLine($"{day} - будний день");
    }
}
