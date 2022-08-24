// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Напишите число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = number1 / 100;
int number3 = (number1 / 100) % 10;

if(number2 > 0 && number2 < 10)
{
    Console.WriteLine($"{number2}");
}
if(number2 > 9 && number2 < 100)
{
    Console.WriteLine($"{number3}");
}

else
{
    Console.WriteLine("Третьей цифры нет");
}