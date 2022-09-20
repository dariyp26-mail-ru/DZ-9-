/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

void NaturNumb(int M, int N)
{
  Console.WriteLine("Hатуральные числа в промежутке от M до N:");
  if (M < 1) M = 1;
  while (M <= N)
  {
    Console.Write(M + " ");
    M++;
  }
}

Console.WriteLine("Задайте значения M и N.");
Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
NaturNumb(M, N);