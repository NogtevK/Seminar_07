/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
 */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int m = 5, n = 6;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i+=2)
{
    for (int j = 0; j < mass.GetLength(1); j+=2)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
            mass[i, j] = mass[i, j] * mass[i, j];
    }
}
Print(mass);
