// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

int readInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrixG(int row, int column, int leftRange, int rightRange)
{   
    int[,] matrix = new int[row, column];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}


void matrixP(int[,] matrix)
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

int matrixM(int[,] matrix)
{
    int minRowIndex = 0;
    int minsum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum){
            minsum = sum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int row = readInt("Введите количество строк 2-х мерного массива: ");
int column = readInt("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = matrixG(row, column, -9, 10);
matrixP(myMatrix);

int minRowIndex = matrixM(myMatrix);
Console.WriteLine($"Идекс строки массива с наиеньшей суммой элеметов = {minRowIndex}");
