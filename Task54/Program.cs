// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortMatrix(int[,] matrix, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        int[] array = new int[col];
        for (int j = 0; j < col; j++)
        {
            array[j] = matrix[i, j];
        }
        SortArray(array);
        for (int k = 0; k < col; k++)
        {
            matrix[i, k] = array[k];
        }
    }
}

void SortArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int minNum = array[i];
        int j = i - 1;
        while(j >= 0 && array[j] < minNum) 
        {
            array[j + 1] = array[j];
            array[j] = minNum;
            j -= 1;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int row, int col, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(max);
        }
    }
    return matrix;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int row = EnterData("Введите количество строк: ");
int col = EnterData("Введите количество столбцов: ");
int max = 10;
int[,] matrix = CreateMatrix(row, col, max);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix, row, col);
PrintMatrix(matrix);