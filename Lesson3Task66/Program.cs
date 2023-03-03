//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int PrintMatrix(int m, int n)
{
    int answer;

    if (m == n)
    {
        return n;
    }

    answer = m + PrintMatrix(m + 1, n);
    return answer;
}



Console.Clear();

Console.Write("Введите значение M и N ");
int[] MN = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();


Console.WriteLine($"Сумма чисел от {MN[0]} до {MN[1]} = {PrintMatrix(MN[0], MN[1])}");





