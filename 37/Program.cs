// Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int getNumberFromUser()
{
    int result = 0;
    while (!int.TryParse(Console.ReadLine(), out result) || (result < 1 ))
    {
        Console.WriteLine($"Введите натуральное число.");
    }
    return result;
}

int[] getRandomArray(int arrayLength)
{
    int[] randomArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        randomArray[i] = new Random().Next(-10, 10);
    }
    return randomArray;
}

int[] getProductOfPairsOfNumbers(int[] array)
{
    int newArrayLength = array.Length / 2 + array.Length % 2;
    int[] productOfNumbersArray = new int[newArrayLength];
    for (int i = 0; i < newArrayLength; i++)
    {
        if (i != array.Length - i - 1)
        {
        productOfNumbersArray[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            productOfNumbersArray[i] = array[i];
        }
    }
    return productOfNumbersArray;
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
int[] newArray = getRandomArray(arrayLength);
printArray(newArray);
Console.WriteLine($"Произведения пар чисел:");
int[] productOfNumbersArray = getProductOfPairsOfNumbers(newArray);
printArray(productOfNumbersArray);
