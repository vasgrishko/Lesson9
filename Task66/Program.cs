// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine(GetSum(1, 10));
int GetSum(int n, int m)
{
    if(n == m)
    {
        return 0;
    }
    else if(n < m) 
    {
        return m + GetSum(n, m - 1);
    }
    else return m + GetSum(n, m + 1);
}
