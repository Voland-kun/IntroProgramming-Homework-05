// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int getNumberFromUser()
{
    int result = 0;
    while (!int.TryParse(Console.ReadLine(), out result) || (result < 1 ))
    {
        Console.WriteLine($"Введите натуральное число.");
    }
    return result;
}

int[] getArray3DigitNunbers(int arrayLength)
{
    int[] array3DigitNumbers = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array3DigitNumbers[i] = new Random().Next(100, 1000);
    }
    return array3DigitNumbers;
}

int getCountEvenNumbers(int[] arrayEven)
{
    int count = 0;
    for (int i = 0; i < arrayEven.Length; i++)
    {
        if (arrayEven[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

Console.WriteLine("Введите длину массива");
int arrayLength = getNumberFromUser();
int[] newArray = getArray3DigitNunbers(arrayLength);
printArray(newArray);
int countEvenNumbers = getCountEvenNumbers(newArray);
Console.WriteLine($"Количество чётных чисел: {countEvenNumbers}");