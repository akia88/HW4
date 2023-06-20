// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
int num1 = 0; // сосед №1
int num2 = 0; // сосед №2
System.Console.Write("0 1");
for (int i = 2; i < n; i++)
{
    res = num1 + num2;
    System.Console.Write($"{res} ");
    num1 = num2;
    num2 = num1;
}