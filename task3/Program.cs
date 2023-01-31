// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.

int[] CreatArray(int A)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.WriteLine($"{array[j]}");
    }
}
int[] array = CreatArray(8);
ShowArray(array);
