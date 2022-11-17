// Коды с семинаров

// Позволяет вводить числа, до тех пор пока не введется верное число, 
// которое попадает в границы

/* int value = -1;
while (value <= -1 || value > 100000)
{
    Console.Write(" 0 <= value <= 100000: ");
    value = Convert.ToInt32(Console.ReadLine());
} */


// Позволяет выявить последнюю цифру в числе

/* int value = -1;
while (value <= -1 || value > 100000)
{
    Console.Write(" 0 <= value <= 100000: ");
    value = Convert.ToInt32(Console.ReadLine());
} 
Console.WriteLine(value % 10);

*/

// Задача 18. Проверить истинность утверждения 
// ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// X = { 0|1 }
// Y = { 0|1 }
// ¬(0 ⋁ 0) = ¬0 ⋀ ¬0   => 1 = 1   => 1  ИСТИНА
// ¬(0 ⋁ 1) = ¬0 ⋀ ¬1   => 1 = 0   => 0  ЛОЖЬ
// ¬(1 ⋁ 0) = ¬1 ⋀ ¬0   => 0 = 1   => 0  ЛОЖЬ
// ¬(1 ⋁ 1) = ¬1 ⋀ ¬1   => 1 = 1   => 1  ИСТИНА


// КАК ПРЕДСТАВИТЬ ЦИФРУ В ВИДЕ МАССИВА


/* int GetNumberCount(int value)
{
    if (value == 0) return 1;       //  == 0 -это нужно, если в числе есть 0, тогда присвоить ему 1
    if (value < 0) value = -value;  // если будут отрицательные цифры
    
    int result = 0;

    while (value != 0)    // != это "не равно"
    {
        result += 1;
        value = value / 10;
    }

    return result;
}
Console.WriteLine(GetNumberCount(256987));  // например вводим число 256987. В ответе
                                            // выходит цифра 6, т.к. 
                                            //в числе 256987 всего 6 цифр  */



//  продолжение кода
//  посчитали кол-во цифр в числе, теперь хотим разбить число по
//  цифрам, т.е. получить массив из цифр


/* int GetNumberCount(int value)
{
    if (value == 0) return 1;       //  == 0 -это нужно, если в числе есть 0, тогда присвоить ему 1
    if (value < 0) value = -value;  // если будут отрицательные цифры
    
    int result = 0;

    while (value != 0)    // != это "не равно"
    {
        result += 1;
        value = value / 10;
    }

    return result;
}
int[] GetNumberBy(int value)
{
   int count = GetNumberCount(value) - 1;
   int[] numbers =  new int [count + 1];
   
   while (value != 0)
   {
      numbers[count --] = value % 10;     //  value % 2; если надо, то так можно представить в двоичном
      value = value / 10;                 //  value / 2; перевернутое представление двоичного числа
   }
   return numbers;
}

int value = 11131235;
int[] nums = GetNumberBy(value);
                                 // Console.WriteLine(nums[2]);  если надо указать например третью цифру в числе слева
                                 // Console.WriteLine(nums[nums.Length - 1 - 2]); если надо указать например третью цифру в числе справа
int size = nums.Length;
int index = 0;
Console.Write($"{value} → ");
while (index < size)
{
    Console.Write(nums[index++] + " ");
}
Console.WriteLine();

// Как правильно делить
14/5 = 2.8      классическое деление
14 div 5 = 2    только целых 2
14 mod 5 = 4    остаток от целого( 14 яблок отдали по 2шт 5 чел, осталось 4 шт целых яблок)



// Узнать третью цифру у числа

int value = 156;
if (value < 0) value = -value;
if (value <= 99) 
}
Console.WriteLine("нет третьей цифры");
}
else
{
int ans = value / 100 % 10;
Console.WriteLine(ans);

while (value > 1000) value = value /10;
Console.WriteLine(value % 10);
} */


