// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArrayRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}
int[] ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}
System.Console.Write("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandomNumber(Length);
System.Console.WriteLine(string.Join(",", array));
System.Console.WriteLine(string.Join(",", ChangeArray(array)));

