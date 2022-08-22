// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число : ");
int numberC = Convert.ToInt32(Console.ReadLine());


if(numberA > numberB)
{
    int MaxNumber = numberA;
    if(numberA > numberC)
    {
    MaxNumber = numberA;
    Console.WriteLine("Max = "+ numberA);
    }
    else
    {
    MaxNumber = numberC;
    Console.WriteLine("Max = "+ numberC);
    }
    
}
else
{
    int MaxNumber = numberB;
    if(numberB > numberC)
    {
    MaxNumber = numberB;
    Console.WriteLine("Max = "+ numberB);
    }
    else
    {
    MaxNumber = numberC;
    Console.WriteLine("Max = "+ numberC);
    }
}