// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] table = new int[5, 5];
Console.WriteLine("Исходный массив");
PrintArray(table);
FillArraySpiral(table);
Console.WriteLine("Заполненный массив");
PrintArray(table);

// заполнение массива по спирали
void FillArraySpiral(int[,] table)
{
    int number = 1; int row = 0; int col = 0;
    int rowBeg = 0; int rowFin = 0; int colBeg = 0; int colFin = 0;
    while (number <= table.GetLength(0) * table.GetLength(1))
    {
        table[row, col] = number;
        if (row == rowBeg && col < table.GetLength(1) - colFin - 1)
        {
            ++col;
        }
        else if (col == table.GetLength(1) - colFin - 1 && row < table.GetLength(0) - rowFin - 1)
        {
            ++row;
        }
        else if (row == table.GetLength(0) - rowFin - 1 && col > colBeg)
        {
            --col;
        }
        else
        {
            --row;
        }
        if ((row == rowBeg + 1) && (col == colBeg) && (colBeg != table.GetLength(1) - colFin - 1))
        {
            ++rowBeg;
            ++rowFin;
            ++colBeg;
            ++colFin;
        }
        ++number;
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

