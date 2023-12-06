// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

void matrixS(int[,] matrix)
{
    int temp;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = temp;
    }
}

int row = readInt("Введите количество строк 2-х мерного массива: ");
int column = readInt("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = matrixG(row, column, -9, 10);
matrixP(myMatrix);
matrixS(myMatrix);
Console.WriteLine("__________________________________");
matrixP(myMatrix);
