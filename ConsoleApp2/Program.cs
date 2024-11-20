int[,] matrix = new int[4, 3]
        {
            { 12, 5, 8 },
            { 3, 15, 6 },
            { 10, 2, 4 },
            { 9, 7, 14 }
        };
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
int min1Index = 0;
int min1Value = matrix[0, 0];

for (int j = 1; j < 3; j++)
{
    if (matrix[0, j] < min1Value)
    {
        min1Value = matrix[0, j];
        min1Index = j;
    }
}

int min3Index = 0;
int min3Value = matrix[2, 0];

for (int j = 1; j < 3; j++)
{
    if (matrix[2, j] < min3Value)
    {
        min3Value = matrix[2, j];
        min3Index = j;
    }
}
matrix[0, min1Index] = min3Value;
matrix[2, min3Index] = min1Value;
Console.WriteLine("Матрица после замены:");
PrintMatrix(matrix);
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
