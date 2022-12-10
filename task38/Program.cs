// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 69.4 -22 0.4 78] ->56

Console.Write("Input array length: ");
int length = Convert.ToInt32(Console.ReadLine());
double [] array = new double [length];
for(int i = 0; i<array.Length; i++)
    array[i] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"max-min={FindMax(array)-FindMin(array)}");

double FindMax(double[] array)
{ 
    double max = array[0];
    for(int i= 0; i<array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{ 
    double min = array[0];
    for(int i= 0; i<array.Length; i++)
    {
        if(array[i] < min)
            min = array[i]; 
    }
    if(min < 0)
        min = -1*min;
    return min;
}