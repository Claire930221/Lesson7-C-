/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//инициализация элементов матрицы случайными числами
int[,] InitMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//распечатать массив на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int n = GetNumber("Введите кол-во строк: ");
int m = GetNumber("Введите кол-во столбцов: ");

int[,] matrix = InitMatrix(n, m);

int NPosition = GetNumber("Введите позицию строки: ");
int MPosition = GetNumber("Введите позицию столбца: ");

if (NPosition > matrix.GetLength(0) - 1 || MPosition > matrix.GetLength(1) - 1)
    Console.WriteLine("такой позиции в массиве нет!");
else
{
    PrintMatrix(matrix);
    Console.WriteLine($"Значение элемента [{NPosition};{MPosition}] = {matrix[NPosition, MPosition]}");
}