// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] table = new int[5, 5];
FillArray(table);
Console.WriteLine("Исходный массив");
PrintArray(table);
Console.WriteLine("Отсортированный построчно массив");
ArrayRowsSort(table);
PrintArray(table);

// Метод Сортировки строк в 2D массиве
void ArrayRowsSort(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        RowsSort(table, rows);
    }
}
// сортировка строки двумерного массива
void RowsSort(int[,] table, int rows)
{
    for (int i = 0; i < table.GetLength(1) - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < table.GetLength(1); j++)
        {
            if (table[rows, j] < table[rows, minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = table[rows, i];
        table[rows, i] = table[rows, minPosition];
        table[rows, minPosition] = temporary;

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
// Заполнение массива случайными числами
void FillArray(int[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++)
        {
            tab[rows, columns] = new Random().Next(-10, 10);
        }
        Console.WriteLine();
    }
}