// Написать программу, которая преобразует массив целых чисел в массив чисел, 
// в котором находятся только четные числа




int[] array = { 11, 21, 31, 14, 15, 38, 17, 18, 19 };
int index = 0;
int n = array.Length;
while (index < n)
{
    if (array[index] % 2 == 0)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}



