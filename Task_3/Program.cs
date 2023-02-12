/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


Console.WriteLine("Введите размер матрицы:");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[n, m];
Random rnd = new Random();
int[] summ = new int[m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = rnd.Next(0, 10);
    }
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {

        Console.Write(matrix[i, j] + "\t ");
        summ[i] += matrix[j, i];
    }
    Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{

    Console.Write(elem / m + "\t ");
}