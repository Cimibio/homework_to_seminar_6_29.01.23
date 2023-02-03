// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Write("Введите количество строк матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];

void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,10);
        }
    }
}

void SqrMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < arg.GetLength(1); j++)
            {
                if (j % 2 == 0) arg[i,j] = arg[i,j] * arg[i,j];
            }
        }
    }
}


FillMatrix(matrix);
Console.WriteLine("Матрица до изменения");
PrintMatrix(matrix);

SqrMatrix(matrix);

Console.WriteLine("Матрица после изменения");
PrintMatrix(matrix);