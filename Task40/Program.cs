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


// Задача 40:   Напишите программу, которая принимает на вход три числа и проверяет, 
//              может ли существовать треугольник со сторонами такой длины.

void Task40()
 {
                int sideA = Convert.ToInt32(Input("Введите сторону A:"));
                int sideB = Convert.ToInt32(Input("Введите сторону B:"));
                int sideC = Convert.ToInt32(Input("Введите сторону C:"));

                if (SideCheck(sideA, sideB, sideC))
                    Console.WriteLine("Треугольник с данными сторонами существует");
                else
                    Console.WriteLine("Треугольник не существует");
            }
Task40();