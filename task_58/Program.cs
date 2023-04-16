// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// ----------- пример вывода программы -----------
// Исходная матрица A
// строка 0 -  '5' '1'
// строка 1 -  '8' '4'
// Исходная матрица B
// строка 0 -  '-1' '-9'
// строка 1 -  '-8' '-9'
// Матрица А умноженная на матрицу В
// строка 0 -  '-13' '-54'
// строка 1 -  '-40' '-108'

int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];
Console.Clear();
FillArray(matrixA);
Console.WriteLine("Исходная матрица A");
PrintArray(matrixA);
FillArray(matrixB);
Console.WriteLine("Исходная матрица B");
PrintArray(matrixB);
if (matrixA.GetLength(0) == matrixB.GetLength(1))
{
    Console.WriteLine($"Матрица А умноженная на матрицу В");
    PrintArray(MatrixMultiplication(matrixA, matrixB));
}
else
{
    Console.WriteLine("Кол-во строк матрицы А не равно кол-ву столбцов матрицы B");
}

// Метод умножения двух матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixProduct = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    for (int i = 0; i < (matrixA.GetLength(0)); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
           for (int k = 0; k < matrixA.GetLength(1); k++)
           {
            matrixProduct[i, j] += matrixA [i, k] * matrixB [k, j];
           }
        }
    }
    return matrixProduct;
}
// вывод массива
void PrintArray(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        Console.Write($"строка {rows} - ");
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($" '{table[rows, columns]}'");
        }
        Console.WriteLine();
    }
}
// Заполнение массива случайными числами
void FillArray(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            table[rows, columns] = new Random().Next(-10, 10);
        }
    }
}