// Напишите цикл, который на вход принимает два числа (A & B) и возводит число A в натуральную степень B
//3,5 -> 243 (3 в 5степ)
//2,4 -> 16 (2 в 4степ)

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(a, b);
System.Console.WriteLine(result);

