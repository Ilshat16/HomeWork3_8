//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpirallyFillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int i = 0;
    int j = 0;
    int leftborder = -1;
    int count = 1;
    int iterI = 0;
    int iterJ = 1;
    while (matrix[i, j] == 0)
    {
        matrix[i, j] = count;
        i += iterI;
        j += iterJ;
        if (j == col)
        {
            j -= 1;
            i += 1;
            iterI = 1;
            iterJ = 0;
        }
        if (i == row)
        {
            i -= 1;
            j -= 1;
            iterI = 0;
            iterJ = -1;
        }
        if (j == leftborder)
        {
            j += 1;
            i -= 1;
            iterI = -1;
            iterJ = 0;
        }
        if (matrix[i, j] != 0)
        {
            i += 1;
            j += 1;
            iterI = 0;
            iterJ = 1;
            col -= 1;
            row -= 1;
            leftborder += 1;
        }
        count += 1;
    }
    return matrix;
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

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int row = EnterData("Введите количество строк: ");
int col = EnterData("Введите количество столбцов: ");
int[,] matrix = SpirallyFillMatrix(row, col);
PrintMatrix(matrix);