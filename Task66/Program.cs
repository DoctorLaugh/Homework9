using System;
using static System.Console;
int SumNum(int start, int end)
{
    int sum = 0;
    if(start == end)
    {
        return end;
    }
    sum = start + SumNum(start+1, end);
    return sum;
}
Clear();
Write("Введите первое число: ");
int n = int.Parse(ReadLine());
Write("Введите второе число: ");
int m = int.Parse(ReadLine());
WriteLine(SumNum(n, m));