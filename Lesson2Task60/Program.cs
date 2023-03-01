//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void InputMatrixA(int[,,] matrix)
{
    Random n = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = n.Next(1, 101);
            }
        }
    }
}




void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i, j,z]} ({i}{j}{z}) \t");// \n - перенос строки
            }
            Console.WriteLine();
        }
        
    }
}



Console.Clear();

Console.Write("Введите размер матрицы А ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,,] matrixA = new int[size[0], size[1], size[2]];

InputMatrixA(matrixA);
PrintMatrix(matrixA);





