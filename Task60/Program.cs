// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[j,k,i]}({j}, {k}, {i}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] CreateMatrix(int row, int col, int level, int max)
{
    int[,,] matrix = new int[row, col, level];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < level; k++)
            {
                matrix[i,j,k] = new Random().Next(max);
            }
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
int level = EnterData("Ввдеите количество уровней: ");
int max = 10;
int[,,] matrix = CreateMatrix(row, col, level, max);
PrintMatrix(matrix);