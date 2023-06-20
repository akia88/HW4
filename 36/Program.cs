//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введитте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
FillArrayRandomNumber(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numders);
int sum = 0;

for (int z = 0; z < number.Length; z+=2)
sum = sum + number[z];

Console.WriteLine($"всего {number.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumber(int[] number)
{
    for(int i = 0; i < number.Length; i++)
    {
        Random rnd = new Random
        number[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] number)
{
    Console.Write("[ ");
    for(int i = 0; i <number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
        Console.Write("]");
        Console.WriteLine();
}
