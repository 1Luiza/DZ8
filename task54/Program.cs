/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] DescendingArray (int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 1; j < inputArray.GetLength(1); j++)
        {
           for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
           {
             if (inputArray[i, k] < inputArray[i, k + 1])
             {
                int buffer = inputArray[i, k + 1];
                inputArray[i, k + 1] = inputArray[i, k];
                inputArray[i, k] = buffer;
             }
           }
        }
    }
    return inputArray;
}
int[,] generatedArray = GenerateArray(5,6,0,10);
ShowArray(generatedArray);
int[,] descendingArray = DescendingArray(generatedArray);
ShowArray(descendingArray);