// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumberSum(int m, int n)
{
  if(m > n) return 0;
  if (m == n) return m;
  return n + NumberSum(m, n - 1);
}

void PrintResultNumberSum(int n)
{
  if(n == 0) Console.WriteLine("Error! Число 'M', не может превышать числа 'N'!");
  else Console.WriteLine(n);
}

Console.Clear(); Console.WriteLine("Введите два числа через пробел, что бы получить сумму элементов от M до N: ");
int[] sizeMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
PrintResultNumberSum(NumberSum(sizeMatrix[0], sizeMatrix[1]));