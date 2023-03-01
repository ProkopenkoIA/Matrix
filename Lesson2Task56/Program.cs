//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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


void Answer(int[] n, ref  int answer)
{
    int minSum;
    minSum = n[0];

    for (int i = 0; i < n.Length; i++)
    {
        Console.WriteLine($"Сумма строки {i+1} = {n[i]}");// \n - перенос строки

        if (n[i]<minSum)
        {
            answer = i;
            minSum = n[i];
        }
    }
}



void SumLineMatrix(int[,] matrix, ref int[] n)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        n[i] = sum;
        sum = 0;
    }

}

Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];

int[] minLine = new int[size[0]];
 int answer = 0;


InputMatrix(matrix);
PrintMatrix(matrix);
SumLineMatrix(matrix, ref minLine);
Answer(minLine, ref answer);
Console.WriteLine($"Cтрока с наименьшей суммой элементов {answer+1}");


