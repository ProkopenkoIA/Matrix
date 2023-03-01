//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


void InputMatrixA(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"A[{i},{j}] = ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}


void InputMatrixB(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"B[{i},{j}] = ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");// \n - перенос строки
        }
        Console.WriteLine();
    }
}


int[,] Multiply(int[,] matrixA, int[,] matrixB)
{
    int[,] answer = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя перемножить!");
    }

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                answer[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }

    }

    return answer;
}

Console.Clear();

Console.Write("Введите размер матрицы А ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrixA = new int[size[0], size[1]];

InputMatrixA(matrixA);

Console.Write("Введите размер матрицы B ");
int[] sizeB = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrixB = new int[sizeB[0], sizeB[1]];

InputMatrixB(matrixB);


/*PrintMatrix(matrixA);

PrintMatrix(matrixB);*/

PrintMatrix(Multiply(matrixA, matrixB));




