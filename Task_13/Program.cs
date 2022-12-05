// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine());
while (number > 999)
    {
       number = number/10;
    }
if (number < 99) Console.WriteLine($"В числе {number} нет третьей цифры!");
else Console.WriteLine($"Третья цифра {number%10}.");

