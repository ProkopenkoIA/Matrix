//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    int answer = 0;

    if (m == 0)
    {
        answer = answer + n + 1;
    }

    if (m > 0 && n == 0)
    {
        answer = answer + Akkerman(m-1, 1);
    }

    if (m > 0 && n > 0)
    {
        answer = answer + Akkerman(m-1, Akkerman(m, n-1));
    }

    return answer;
}

Console.Clear();

Console.Write("Введите значение M и N ");
int[] MN = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();


Console.WriteLine($"Сумма чисел от {MN[0]} до {MN[1]} = {Akkerman(MN[0], MN[1])}");





