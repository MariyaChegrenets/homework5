// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Input array length: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i=0; i<array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("SumNegativeIndex: " +SumNegativeIndex(array));

int SumNegativeIndex(int[] array)
{
    int sum = 0;
    for(int i =0; i<array.Length; i++)
    {
        if(i % 2 == 1)
        {
        sum += array[i];
        Console.Write($"{array[i]} ");
        }
    }  
    Console.WriteLine();
    return sum;
}