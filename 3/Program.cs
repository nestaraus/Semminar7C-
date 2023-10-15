// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] =new Random().Next(-10,11);
        }
    }
}

void PrintMatrix(int[,] matrix) 
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
            for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i%2==1&&j%2==1)
            matrix[i,j]*=matrix[i,j];
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);