/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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


//нахождение средней арифметической каждого столбца
double GetAverageInColumn(int[,] matrix)
{
    double count = 0;
    double average = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            count+=matrix[j, i];
        }
        average = count / matrix.GetLength(0);
        System.Console.Write(Math.Round(average, 2) + "; "); 
        count = 0;       
    }   
    return average;

}

int[,] resultMatrix = InitMatrix(GetNumber("Введите размерность строк n: "), 
GetNumber("Введите размерность столбцов m: "));
PrintMatrix(resultMatrix);
GetAverageInColumn(resultMatrix);