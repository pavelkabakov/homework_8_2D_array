// Задача 60.
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] table = new int[3, 3, 3];
Console.WriteLine("Исходный массив");
Print3DArray(table);
Fill3DArray(table);
Console.WriteLine("Заполненный массив");
Print3DArray(table);

// вывод массива
void Print3DArray(int[,,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            for (int k = 0; k < tab.GetLength(2); k++)
            {
                Console.Write($"{tab[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}
// Заполнение трехмерного массива неповторяющимися двузначными случайными числами
void Fill3DArray(int[,,] tab)
{
    Dictionary<int, int> elements = new Dictionary<int, int>();
    Random rnd = new Random();
    int randomValue;

    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            for (int k = 0; k < tab.GetLength(2); k++)
            {
                while (true)
                {
                    randomValue = rnd.Next(10, 100);
                    Console.WriteLine($"цикл - i:{i},j:{j},k:{k}");
                    if (!elements.ContainsKey(randomValue))
                    {
                        elements.Add(randomValue, +1);
                        tab[i, j, k] = randomValue;
                        break;
                        // Console.WriteLine($"tab:{tab[i, j, k]}, elements:{elements[tab[i, j, k]]}");
                    }
                }
            }
        }
    }
}