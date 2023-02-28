//Задача: Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

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


void Transposition(int [,] matrix, ref int [,] transMatrix)
{
    int tmp, n, m;
     n = Convert.ToInt32(matrix.GetLongLength(0))-1;
    // m = matrix.GetLongLength(1);
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            transMatrix[n-i, j] = matrix[i, j];         
            
        }
    }

}

Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];
int[,] transMatrix = new int[size[0], size[1]];



InputMatrix(matrix);
PrintMatrix(matrix);
Transposition(matrix, ref transMatrix);
Console.WriteLine("Транспонированный массив ");
PrintMatrix(transMatrix);

