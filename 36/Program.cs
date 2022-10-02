// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        array3DigitNumbers[i] = new Random().Next(-1000, 1000);
    }
    return array3DigitNumbers;
}

int getSumOddIndex(int[] arrayOddIndex)
{
    int sum = 0;
    for (int i = 1; i < arrayOddIndex.Length; i += 2)
    {
        sum += arrayOddIndex[i];
    }
    return sum;
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
int sumOddIndex = getSumOddIndex(newArray);
Console.WriteLine($"Сумма элементов на нечетных позиция: {sumOddIndex}");
