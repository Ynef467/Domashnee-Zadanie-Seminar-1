// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите любое число от 1: ");

double numberN = Convert.ToInt32(Console.ReadLine());

double a = 1;

if(numberN <= 0)
{
    System.Console.WriteLine("Число меньше 0 или равно 0");
}    
else{
    while(a <= numberN)
    {
        if(a % 2 == 0)
        {
        System.Console.Write(a +",");
        }
    a++;
    }
}
