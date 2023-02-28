//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    Random n = new Random();

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            matrix[i, j] = n.Next(1, 21);

        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");// \n - перенос строки
        }
        Console.WriteLine();
    }
}


void SearchInMatrix(int[,] matrix, int[] point)
{
    if (point[0] <= matrix.GetLongLength(0) && point[1] <= matrix.GetLongLength(1))
    {
        Console.Write($"Ваш элемент = {matrix[point[0], point[1]]} \t");
    }
    else
    {
        Console.Write($"Ваш элемент не найден!");
    }
}
Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.Write("Введите позицию элемента ");
int[] point = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];



InputMatrix(matrix);
PrintMatrix(matrix);
SearchInMatrix(matrix, point);

