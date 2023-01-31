// Напишите програму, которая принимает на вход число и выдает сумму цифр в числе
//452 -> 11
//82 -> 10


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    int b = a % 10;
    a = a / 10;
    sum = sum + b;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
