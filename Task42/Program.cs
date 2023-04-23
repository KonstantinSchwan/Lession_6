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


void Task42()
{
    int number = Convert.ToInt32(Input("Введите число:"));
    int value = number;
    int resultInt = 0;
    int shift = 1;
    string resultStr = "";
    while (value > 0)
    {
        resultStr = value % 2 + resultStr;
        resultInt += value % 2 * shift;
        shift = shift * 10;
        value /= 2;
    }
    Console.WriteLine($"Число в двоичном представлении: {resultStr}");
    Console.WriteLine($"Число в двоичном представлении: {resultInt}");
}

Task42();