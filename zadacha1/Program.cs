// Задача 1: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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

void matrixXY(int[,] matrix, int x, int y)
{
    if (x > matrix.GetLength(0) || y > matrix.GetLength(1)){
        Console.WriteLine($"Элемента массива с индексом [{x}, {y}] не существует");

    }
    else Console.WriteLine($"Искомый элемент массива = {matrix[x, y]}");
}


int row = readInt("Введите количество строк 2-х мерного массива: ");
int column = readInt("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = matrixG(row, column, -9, 10);
matrixP(myMatrix);

int x = readInt("Веедите индекс искомой строки: ");
int y = readInt("Ведите индекс искомого столбца: ");
matrixXY(myMatrix, x, y);


