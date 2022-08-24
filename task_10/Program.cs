// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Напишите трёх значное число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = number1 / 10;
int number3 = number2 % 10;
Console.WriteLine($"{number3}");