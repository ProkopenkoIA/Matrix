//Задача: матрицу 4*10 заполнить по диагонали

void InputMatrix(int[,] matrix)
{
    int value , D;    

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            D = i+j;
            value = ((D*D+D)/2);     
            matrix[i, j] = value;

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



Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);


