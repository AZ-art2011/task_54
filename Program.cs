// Задача 54: Задайте двумерный массив. Сделайте упорядочивание по убыванию 
// элементы каждой строки двумерного массива.

Console.Clear();

void RecordTempMatrix(int[,] TempMatrix)
{
    for (int i = 0; i < TempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < TempMatrix.GetLength(1); j++)
        {
            TempMatrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortMatrix(int[,] TempMatrix)
{
    for (int i = 0; i < TempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < TempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < TempMatrix.GetLength(1) - 1; k++)
            {
                if (TempMatrix[i, k] < TempMatrix[i, k + 1])
                {
                    int temp = TempMatrix[i, k + 1];
                    TempMatrix[i, k + 1] = TempMatrix[i, k];
                    TempMatrix[i, k] = temp;
                }
            }
        }
    }
}

void WriteTempMatrix(int[,] TempMatrix)
{
    for (int i = 0; i < TempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < TempMatrix.GetLength(1); j++)
        {
            Console.Write($"{TempMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Matrix = new int[3, 4];
RecordTempMatrix(Matrix);
Console.WriteLine($"Исходный массив");
WriteTempMatrix(Matrix);
SortMatrix(Matrix);
Console.WriteLine();
Console.WriteLine($"Отсортированный массив");
WriteTempMatrix(Matrix);


