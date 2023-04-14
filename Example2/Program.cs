// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int [value("количество строк массива"), value("количество столбцов массива")];
newArray(array);
printArray(array);
int findValue = value("искомое число");
if (findValueFunktion(array, findValue)) System.Console.WriteLine($"Число {findValue} есть в массиве");
else System.Console.WriteLine($"Числа {findValue} нет в массиве");
position(array);

void position (int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int line = value("номер строки массива")-1;
    if (line>=0 && line < a)
    {
        int column = value("номер столбца массива")-1;
        if ( column >=0 && column < b) System.Console.WriteLine($"Искомое число > {array[line, column]}");
        else System.Console.WriteLine("Столбца с таким значением в массиве нет");
    }   
    else System.Console.WriteLine("Строки с таким значеникм в массиве нет");
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

int value(string i)
{
    System.Console.Write($"Введите {i} > ");
    int x = int.Parse(Console.ReadLine());
    return x;
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

bool findValueFunktion (int[,] array, int findValue)
{
            bool x = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
             for (int j = 0; j < array.GetLength(1); j++)
             {
                if (array[i, j] == findValue)
                {
                    x = true;
                }
             }
            }
            return x;
}