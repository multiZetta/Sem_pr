/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


/* void Figure(int x, int y)
{
  Console.Clear();
  for (int i = x - 1; i <= x + 1; i++)
  {
    for (int j = y - 1; j <= y + 1; j++)
    {
      Console.SetCursorPosition(i, j);
      Console.Write("+");
    }
  }
}
int x = 10;
int y = 2;

// Логика отрисовки всего
new Thread(() =>
{
  while (true)
  {
    Figure(x, y);
    Thread.Sleep(500);
    y++;
    if (y > 15) y = 1;
  }
}).Start();

// Логика проверки нажатия кнопок
while (true)
{
  var key = Console.ReadKey(true).Key;

  if (key == ConsoleKey.LeftArrow)
  {
    x--;
    Figure(x, y);
  }
  if (key == ConsoleKey.RightArrow)
  {
    x++;
    Figure(x, y);
  }
}
 */



// Разбор задачи из числа  m  прийти к числу  n

int m = 2;
int n = 10;
int k = 1;    // с  k можно только прибавлять
int q = 2;    // на  q можно только умножать


int res = GetWays(m, n, k, q);

int GetWays(int m, int n, int k, int q, string text = " ")
{
    Console.WriteLine($"{m,3}{n,3}{k,3}{q,3}{text}");
    if (n < m) return 0;
    if (n == m) return 1;
    else if (n % q != 0) return GetWays(m, n - k, k, q, text + $"({n}➖{k})");
    else return GetWays(m, n - k, k, q, text + $"({n}➖{k})") + GetWays(m, n / q, k, q, text + $"({n}➗{q})");
}

Console.WriteLine(res);

