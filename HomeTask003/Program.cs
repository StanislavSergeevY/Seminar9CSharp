// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ACK(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return ACK(m - 1, 1);
  else return ACK(m - 1, ACK(m, n - 1));
}

void PrintResultNumberSum(int n)
{
  Console.WriteLine(n);
}

Console.Clear(); Console.WriteLine("Введите два числа через пробел, что бы запустить функцию Аккермана: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
PrintResultNumberSum(ACK(numbers[0], numbers[1]));