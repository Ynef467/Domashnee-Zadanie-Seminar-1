// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число для проверки на чётность : ");

double number = Convert.ToInt32(Console.ReadLine());

if ((double)number % 2 == 0) {
Console.WriteLine("Чётное");
}
else
{
Console.WriteLine("Не чётное");
}