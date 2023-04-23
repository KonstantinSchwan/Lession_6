void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

void PrintArrayReverse(int[] numbers)
{
    Random rnd = new Random();
    int lastIndex = numbers.Length - 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[lastIndex - i]} ");
    }
    Console.WriteLine();
}

void Reverse(int[] numbers)
{
    int halfSize = numbers.Length / 2;
    int lastIndex = numbers.Length - 1;
    for (int i = 0; i < halfSize; i++)
    {
        (numbers[i], numbers[lastIndex - i]) = (numbers[lastIndex - i], numbers[i]);
        // int temp = numbers[i];
        // numbers[i] = numbers[lastIndex - i];
        // numbers[lastIndex - i] = temp;
    }
}

string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

bool SideCheck(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}



//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
void Task44()
{
    int num_f = 0;
    int num_s = 1;
    int count = Convert.ToInt32(Input("Количество элементов последовательности:"));
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{num_f} ");
        (num_f, num_s) = (num_s, num_f + num_s);
        // int temp = num_f;
        // num_f = num_s;
        // num_s = temp + num_s;
    }
}

Task44();
