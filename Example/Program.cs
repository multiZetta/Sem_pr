// Печать массива

void Print(int[] numbers)
{
  int size = numbers.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{numbers[i]} ");
  }
  Console.WriteLine();
}

string ArrayToString(int[] numbers)
{
  int size = numbers.Length;
  string text = String.Empty;

  for (int i = 0; i < size; i++)
  {
    text += $"{numbers[i]} ";
  }

  return text;
}

// Создание массива \[+\][Блок-схема] (diagram.drawio.png)
int[] Create(int count)
{
  return new int[count];
}

// Генерация массива
void Fill(int[] array)
{
  int size = array.Length;

  for (int i = 0; i < size; i++)
  {
    // array[i] = new Random().Next(1, 10);
    array[i] = Random.Shared.Next(1, 10);
  }
}

int[] CreateAndFill(int count)
{
  int[] array = new int[count];

  for (int i = 0; i < count; i++)
  {
    array[i] = Random.Shared.Next(1, 10);
  }
  return array;
}

// Вычисление количества четных чисел массива

int EvenCount(int[] array)
{
  int result = 0;
  int length = array.Length;

  for (int i = 0; i < length; i++)
  {
    if (array[i] % 2 == 0) result++;
  }

  return result;
}

// Получение массива только четных чисел

int[] Solution(int[] input, int count)
{
  int[] output = new int[count];

  int index = 0;
  int length = input.Length;

  for (int i = 0; i < length; i++)
  {
    int el = input[i];
    if (el % 2 == 0)
    {
      output[index] = el;
      index++;
    }
  }
  return output;
}


// Клиентский код

Console.Clear();

int len = 10;
int[] a = Create(len);
Fill(a);
// Print(a);
Console.WriteLine(ArrayToString(a));
File.WriteAllText("a.txt", ArrayToString(a));

int evens = EvenCount(a);
int[] b = Solution(a, evens);
// Print(b);
Console.WriteLine(ArrayToString(b));
File.WriteAllText("b.txt", ArrayToString(b));