// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.WriteLine("Введите сторону A: ");
int a  = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону B: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
System.Console.WriteLine("Треугольник существует");
else
System.Console.WriteLine("Треугольник не существует");
