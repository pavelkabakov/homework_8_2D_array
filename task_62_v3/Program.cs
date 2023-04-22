// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] table = new int[5, 5];
int startNumber = 1;
Console.WriteLine("Исходный массив");
PrintArray(table);
FillArraySpiral(0, 0, startNumber);
Console.WriteLine("Заполненный массив");
PrintArray(table);

// ЕЩЕ НЕ ДОДЕЛАНО !!!!

// заполнение массива по спирали через рекурсию 
void FillArraySpiral(int row, int col, int startNumber)
{
    if (row >= 0 && row < table.GetLength(0) && col >= 0 && col < table.GetLength(1))
    {
        if (table[row, col] == 0)
        {
            // обход внешнего периметра массива
            table[row, col] = startNumber;
            startNumber++;
            if (row - 1 < 0)// up
            {
                FillArraySpiral(row, col + 1, startNumber);
                // Console.WriteLine($"s1 {row} : {col} : {table[row, col]}");
            }
            if (col + 1 >= table.GetLength(1))// right
            {
                FillArraySpiral(row + 1, col, startNumber);
                // Console.WriteLine($"s2 {row} : {col} : {table[row, col]}");
            }
            if (row + 1 >= table.GetLength(0)) // down
            {
                FillArraySpiral(row, col - 1, startNumber);
                // Console.WriteLine($"s3 {row} : {col} : {table[row, col]}");
            }
            if (col - 1 < 0)
            {
                FillArraySpiral(row - 1, col, startNumber); // left
                // Console.WriteLine($"s4 {row} : {col} : {table[row, col]}");
            }
            if (row - 1 < 1 && col - 1 < 1)
            {
                FillArraySpiral(row - 1, col, startNumber); // left
                // Console.WriteLine($"s4 {row} : {col} : {table[row, col]}");
            }

        }
    }
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

