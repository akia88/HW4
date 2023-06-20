// 31: Задайте массив из 5 элементов, заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] FillArrayRandomeNumbers(int size)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}

System.Console.WriteLine("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandomeNumbers(Length);
System.Console.WriteLine(string.Join(", ", array));

int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive+=array[i];
    }
    else
    {
        sumNegative+=array[i];
    }
}
System.Console.WriteLine($"сумма положительных чисел равна {sumPositive}, сумма отрицательных чисел равна {sumNegative}");
