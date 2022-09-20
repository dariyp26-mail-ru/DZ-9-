/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void SummNaturNumb(int M, int N)
{
  int summ = 0;
  Console.Write("Cуммa натуральных элементов в промежутке от M до N: ");
  if (M < 1) M = 1;
  while (M <= N)
  {
    summ += M;
    M++;
  }
  Console.WriteLine(summ);
}

Console.WriteLine("Задайте значения M и N.");
Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
SummNaturNumb(M, N);