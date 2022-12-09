// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Input array length: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for(int i=0; i<array.Length; i++)
    array[i] = new Random().Next(100,1000);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(CountPositive(array));

int CountPositive(int[] array)
{
    int countpositive = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            countpositive ++;
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
    return countpositive;
}
