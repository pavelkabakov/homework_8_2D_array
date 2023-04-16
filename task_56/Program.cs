// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] table = new int[5, 5];
FillArray(table);
Console.WriteLine("Исходный массив");
PrintArray(table);
for (int i = 0; i < table.GetLength(0); i++)
{
    Console.WriteLine($"Сумма строки номер {i} = {RowsSumm(table, i)}");
}
Console.WriteLine($"Индекс строки с наименьшей суммой = {MinSummRowsIndex(table)}");

// Метод Сортировки строк в 2D массиве
int MinSummRowsIndex(int[,] table)
{
    int minRowsIndex = 0;
    for (int i = 0; i < (table.GetLength(0)-1); i++)
    {
        for (int j = 1; j < table.GetLength(0); j++)
        {
            if (RowsSumm(table, minRowsIndex) > RowsSumm(table, j))
            {
                minRowsIndex = j;
            }
        }
    }
    return minRowsIndex;
}
// расчет сумма строки двумерного массива
int RowsSumm(int[,] table, int rows)
{
    int rowsSumm = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        rowsSumm = table[rows, i];
    }

    return rowsSumm;
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
        Console.WriteLine();
    }
}