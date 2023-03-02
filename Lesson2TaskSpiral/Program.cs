//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void InputMatrixA(int[,] matrix)
{
    int n = matrix.GetLength(1), m = matrix.GetLength(0), argument = 1;

    int x, y;


    for (int j = 0; j < n; j++)
    {
        matrix[0, j] = argument;
        argument++;
    }

    for (int i = 1; i < m; i++)
    {
        matrix[i, n - 1] = argument;
        argument++;
    }

    for (int j = n - 2; j >= 0; j--)
    {
        matrix[m - 1, j] = argument;
        argument++;
    }

    for (int i = m - 2; i > 0; i--)
    {
        matrix[i, 0] = argument;
        argument++;
    }

    x = 1;
    y = 1;

    while (argument < m * n)
    {
        // в право
        while (matrix[x, y + 1] == 0)
        {
            matrix[x, y] = argument;
            argument++;
            y++;
        }

        //-- в низ
        while (matrix[x + 1, y] == 0)
        {
            matrix[x, y] = argument;
            argument++;
            x++;
        }

        //-- в лево
        while (matrix[x, y - 1] == 0)
        {
            matrix[x, y] = argument;
            argument++;
            y++;
        }

        //-- вверх
        while (matrix[x + 1, y] == 0)
        {
            matrix[x, y] = argument;
            argument++;
            x++;
        }
    }
    //-- последний элемент
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j]==0)
            {
                matrix[i, j] = argument;
            }
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



Console.Clear();

Console.Write("Введите размер матрицы А ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrixA = new int[size[0], size[1]];

InputMatrixA(matrixA);
PrintMatrix(matrixA);





