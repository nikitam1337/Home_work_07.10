/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
*/

Console.Clear();

int EnterNumber;
while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out EnterNumber))
    {
        if (9999 < EnterNumber && EnterNumber < 100000)
        break;
    }
    Console.WriteLine($"Ошибка ввода!");
}

Console.WriteLine("Вроде всё гуд");