// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string text)
{
    System.Console.Write(text);
    string value = Console.ReadLine();
    int num = Convert.ToInt32(value);
    return num;
}

int SummNumbers(int m, int n)
{
    if (m == n) return m;
    else return n + SummNumbers(m, n-1);
}

int m = InputNumber("m = ");
int n = InputNumber("n = ");
Console.WriteLine(SummNumbers(m, n));
