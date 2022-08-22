// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA != numberB)
{    
    if(numberA > numberB)
    Console.WriteLine("max = "+ numberA);

    else
        Console.WriteLine("max = "+ numberB);
}
else
Console.WriteLine(numberA + " и " + numberB + " равны между собой введите разные числа для сравнения");