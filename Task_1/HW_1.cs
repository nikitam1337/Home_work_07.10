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
        else if (-100000 < EnterNumber && EnterNumber < -9999)
            break;
    }
    Console.WriteLine($"Ошибка ввода!");
}

Console.Write($"{EnterNumber} -> ");

int num1 = EnterNumber / 10000;
int num1_2 = EnterNumber / 1000;
int num2 = num1_2 % 10;
int num4_5 = EnterNumber % 100;
int num4 = num4_5 / 10;
int num5 = EnterNumber % 10;

if (num1 == num5 && num2 == num4) Console.Write("Да");
else Console.Write("Нет");