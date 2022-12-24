// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultipleMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                resultMatrix[i, j]  +=matrix1[k, j] * matrix2[i, k];
            }
        }
    }
    return resultMatrix;
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
int[,] matrix1 = CreateMatrix(row, col, max);
int[,] matrix2 = CreateMatrix(row, col, max);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] resultMatrix = MultipleMatrix(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц равна:");
PrintMatrix(resultMatrix);