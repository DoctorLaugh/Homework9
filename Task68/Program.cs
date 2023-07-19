using System;
using static System.Console;
int AkkFun(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if (n != 0 && m == 0)
    {
        return AkkFun(n - 1, 1);
    }
    else
    {
        return AkkFun(n - 1, AkkFun(n, m - 1));
    }
}
Clear();
Write("Введите первое число: ");
int n = int.Parse(ReadLine());
Write("Введите второе число: ");
int m = int.Parse(ReadLine());
WriteLine(AkkFun(n, m));