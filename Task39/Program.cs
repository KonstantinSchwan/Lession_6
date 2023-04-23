            void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
            {
                maxValue++;
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(minValue, maxValue);
                }
            }

            // LINQ
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

// Задача 39:   Напишите программу, которая перевернёт одномерный массив
//              (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
//              Решите задачу без создания второго массива

 void Task39()
            {
                int size = 4;
                int[] numbers = new int[size];
                FillArray(numbers);
                Console.WriteLine("Начальный массив");
                PrintArray(numbers);
                Reverse(numbers);
                Console.WriteLine("Перевёрнутый массив");
                //PrintArrayReverse(numbers);
                PrintArray(numbers);
            }
Task39();