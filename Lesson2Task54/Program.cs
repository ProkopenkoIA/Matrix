//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


void SortMatrix(int[,] matrix)
{
    int max, a, b;

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            max = matrix[i, j];
            a = i;
            b = j;
            for (int n = j+1; n < matrix.GetLongLength(1); n++)
            {
                if (max < matrix[i, n])
                {   
                    max = matrix[i, n];
                    a = i;
                    b = n;
                }

            }

            matrix[a,b] = matrix[i, j];
            matrix[i, j] = max;
        }
    }

}

Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];



InputMatrix(matrix);
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine("Отсортированный массив ");
PrintMatrix(matrix);

