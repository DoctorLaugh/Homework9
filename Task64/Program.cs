using System;
using static System.Console;
string RevNatRow(int n)
{
    if(n > 1)
    {
        Write($"{n}, ");
        RevNatRow(n - 1);
    }
    return "1";
}
Clear();
Write("Введите число: ");
int n = int.Parse(ReadLine());
WriteLine(RevNatRow(n));