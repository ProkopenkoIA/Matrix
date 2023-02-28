//Задача: https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=121&id_problem=749

void InputMatrix(string[,] matrix)
{
    //Random n = new Random();
    string enterString;
    string[] massiveString;
    Console.WriteLine("Введите информацию о фото  ");

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        enterString = Console.ReadLine();
        massiveString = enterString.Split(new Char[] { ' ' });
        for (int j = 0; j < massiveString.Length - 1; j++)
        {
            matrix[i, j] = massiveString[j];

        }
        //Console.WriteLine();
    }
}

void InputBrokenMatrix(string[,] matrix)
{
    //Random n = new Random();
    string enterString;
    string[] massiveString;
    Console.WriteLine("Введите информацию о негативе ");

    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        enterString = Console.ReadLine();
        massiveString = enterString.Split(new Char[] { ' ' });
        for (int j = 0; j < massiveString.Length - 1; j++)
        {
            matrix[i, j] = massiveString[j];

        }
        //Console.WriteLine();
    }
}

void PrintMatrix(string[,] matrix)
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


int BrokenCount(string[,] matrix, string[,] transMatrix)
{
    int n = 0;
    // m = matrix.GetLongLength(1);
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            if (Reverse(matrix[i, j]) != transMatrix[i, j])
            {
                n++;
            }

        }
    }
    return n;
}

string Reverse(string str)
{
    if (str == "W" && str != string.Empty)
    { return "B"; }
    else
    {
        return "W";
    }
}

Console.Clear();

Console.Write("Введите размер массива ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

string[,] matrix = new string[size[0], size[1]];
string[,] brokenMatrix = new string[size[0], size[1]];

InputMatrix(matrix);
InputBrokenMatrix(brokenMatrix);
Console.Clear();
Console.WriteLine("Фото ");
PrintMatrix(matrix);
Console.WriteLine("Негатив ");
PrintMatrix(brokenMatrix);

Console.WriteLine($"Обнаружено ошибок {BrokenCount(matrix, brokenMatrix)}");


