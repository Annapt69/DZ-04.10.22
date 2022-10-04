/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int getSumOfOddNumber(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(i % 2 == 1)
        {
            result += incomingArray[i];
        }
    }
    return result;
}

int[] currentArray = getRandomArray(10, -99, 99);
printArray(currentArray);
int sumOfNumber = getSumOfOddNumber(currentArray);
Console.WriteLine($"Сумма элементов с нечетным индексом {sumOfNumber}");