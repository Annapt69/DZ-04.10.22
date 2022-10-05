/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] getDoubleArray(int length, double startPoint, double endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = Math.Round((new Random().NextDouble() * 100), 2);
    }
    return resultArray;
}
void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(";");
        }
    }
    Console.WriteLine("]");
}

double getDifferenceMaxOfMin(double[] incomingArray)
{
    double max = 0;
    double min = int.MaxValue;
    for (int j = 0; j < incomingArray.Length; j++)
    {
        if (incomingArray[j] > max) 
        {
            max = incomingArray[j];
        }
        if (incomingArray[j] < min)
        {
            min = incomingArray[j];
        }

    }
double result = 0;  
    if (max > 0 && min > 0)
    {   
        result = max - min;
    }
    return result;
}

double[] currentArray = getDoubleArray(5, 1, 10);
printArray(currentArray);

double DifferenceMaxOfMin = getDifferenceMaxOfMin(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива {DifferenceMaxOfMin} ");