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


   void Task45()
            {
                int size = 4;
                int[] numbers = new int[size];
                FillArray(numbers);
                Console.WriteLine("Первый массив");
                PrintArray(numbers);

                int[] numbers_copy = new int[size];
                
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers_copy[i] = numbers[i];
                }
                numbers[0] = 10000;
                Console.WriteLine("Копия массива");
                PrintArray(numbers_copy);
            }

            Task45();