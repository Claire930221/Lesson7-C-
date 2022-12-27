/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

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
double[,] InitMatrix(double n, double m)
{
    double[,] matrix = new double[n, m];
    Random rnd = new Random();
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//распечатать массив на консоль
void PrintMatrix(double[,] matrix)
{
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

double n = GetNumber("Введите количество строк:");
double m = GetNumber("Введите количество столбцов:");
double[,] matrix = InitMatrix(n, m);
PrintMatrix(matrix);


