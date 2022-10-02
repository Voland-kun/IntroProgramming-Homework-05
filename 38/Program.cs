// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int getNumberFromUser()
{
    int result = 0;
    while (!int.TryParse(Console.ReadLine(), out result) || (result < 1 ))
    {
        Console.WriteLine($"Введите натуральное число.");
    }
    return result;
}

double[] getArrayRealNumbers(int arrayLength)
{
    double[] arrayRealNumbers = new double[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        arrayRealNumbers[i] = new Random().Next(-100, 100);
    }
    return arrayRealNumbers;
}

void printArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

double getMinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double result = max - min;
    return result;
}

Console.WriteLine("Введите длину массива");
int arrayLength = getNumberFromUser();
double[] newArray = getArrayRealNumbers(arrayLength);
printArray(newArray);
double maxMinDifference = getMinMaxDifference(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {maxMinDifference}");