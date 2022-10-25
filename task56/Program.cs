/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateArray(int height, int weight, int randomStart, int randomEnd)
{
    int[,] generatedArray = new int [height,weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i,j] = new Random().Next(randomStart, randomEnd);
        }
    }
    return generatedArray;
}
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(data);
    Console.ResetColor();
}
void ShowArray(int[,] inputArray)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");   
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j]}\t");   
        }
        Console.WriteLine();
    }
}
void MinSumOfString (int[,] inputArray)
{
    int sumOfZeroString = 0;
    int i = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        sumOfZeroString += inputArray[i,j];
    }
    int minSumOfString = 0;
    int stringNumber = 0;
    for (int k = 1; k < inputArray.GetLength(0); k++)
    { 
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
        minSumOfString = inputArray [k,j];
        if (sumOfZeroString < minSumOfString)
            {
                minSumOfString = sumOfZeroString;
                stringNumber = i;
            }  
            else stringNumber = k;
        } 
    }
    Console.WriteLine($"{stringNumber} строка");   
}
    
int[,] generatedArray = GenerateArray(3,2,0,10);
ShowArray(generatedArray);
MinSumOfString(generatedArray);