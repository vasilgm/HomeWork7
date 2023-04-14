// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array = new double [value("количество строк массива"), value("количество столбцов массива")];
newArray(array);
printArray(array);



void newArray (double[,] array)
{
    double a = value("нижний диапазон массива");
    double b = value("верхний диапазон массива");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*(b-a)+a, 2);
        }
    }
}

int value(string i)
{
    System.Console.Write($"Введите {i} > ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

void printArray (double[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i, j]+" ");
            }
            System.Console.WriteLine();
         }
}
