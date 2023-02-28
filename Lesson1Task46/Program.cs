//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void InputMatrix(double [,] matrix)
{
    Random n = new Random();

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            matrix[i, j] = n.NextDouble();;
            
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");// \n - перенос строки
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите размер массива ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double [,] matrix = new double[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
