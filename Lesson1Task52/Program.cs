//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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


void AverageMatrix(int[,] matrix, ref double[] average)
{
    double n = 0;
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            n = n + Convert.ToDouble(matrix[i, j]);
        }
        average[i] = n / matrix.GetLongLength(1);
        n = 0;
    }

}

void PrintAverage(double[] average)
{

    for (int i = 0; i < average.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое строка {i + 1} = {average[i]} \t");
    }

}

Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

double [] average = new double[size[1]];

int[,] matrix = new int[size[0], size[1]];



InputMatrix(matrix);
PrintMatrix(matrix);
AverageMatrix(matrix, ref average);
PrintAverage(average);

