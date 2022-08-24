// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Напишите цифру: ");
int num = int.Parse(Console.ReadLine());

if(num >= 6 & num <= 7)
{
    Console.WriteLine("Да");
}
if(num >= 1 & num <= 5)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Такого дня недели не бывает");
}