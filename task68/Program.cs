// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string text)
{
    System.Console.Write(text);
    string value = Console.ReadLine();
    int num = Convert.ToInt32(value);
    return num;
}

int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}

int m = InputNumber("Введите значение M: ");
int n = InputNumber("Введите значение N: ");

Console.Write($"m = {m} , n = {n} -> A({m}, {n}) = {akkerman(m, n)} ");