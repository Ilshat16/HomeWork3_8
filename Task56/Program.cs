// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка.

void FindRow(int[,] matrix, int row, int col)
{
    int[] sumNumsInRow = new int[row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumNumsInRow[i] += matrix[i, j];
        }
    }
    int min = sumNumsInRow[0];
    int index = 0;
    for (int i = 1; i < sumNumsInRow.Length; i++)
    {
        if (sumNumsInRow[i] < min) 
        {
            min = sumNumsInRow[i];
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Суммы строк матрицы: " + string.Join(" ", sumNumsInRow));
    Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1}");
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
FindRow(matrix, row, col);