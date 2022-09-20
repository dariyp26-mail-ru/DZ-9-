/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

int Akkerman(int M, int N)
{
  if (M == 0)
    return N + 1;
  else
    if ((M != 0) && (N == 0))
    return Akkerman(M - 1, 1);
  else
    return Akkerman(M - 1, Akkerman(M, N - 1));
}

Console.WriteLine("Вычисление функции Аккермана с помощью рекурсии -> A(m,n).");
Console.WriteLine("Задайте значения m и n.");
Console.Write("m = ");
int M = int.Parse(Console.ReadLine());
Console.Write("n = ");
int N = int.Parse(Console.ReadLine());
Console.Write("A(m,n) = " + Akkerman(M, N));