// Задача 40:   Напишите программу, которая принимает на вход три числа и проверяет, 
//              может ли существовать треугольник со сторонами такой длины.

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b+c && b < a+c && c < a+b)
{
    Console.WriteLine("Треугольник существует"); 
    
}
else  Console.WriteLine("Треугольник не существует"); 