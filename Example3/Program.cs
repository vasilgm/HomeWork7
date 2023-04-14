// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int [value("количество строк массива"), value("количество столбцов массива")];
newArray(array);
printArray(array);
double[] averageArray = average(array);
System.Console.Write("Среднее арифметическое каждого столбца: ");
printAverageArray(averageArray);




int value(string i)
{
    System.Console.Write($"Введите {i} > ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

void newArray (int[,] array)
{
    int a = value("нижний диапазон массива");
    int b = value("верхний диапазон массива");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(a, b+1);
        }
    }
}

double[] average (int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            average[j] = average[j] + (double)array[i, j];
        }
    }
    for (int i = 0; i < average.Length; i++)
    {
        average [i] = Math.Round(average [i] / array.GetLength(0), 2);
    }
    return average;
}

void printArray (int [,] array)
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

void printAverageArray (double[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]}; ");
        }
}