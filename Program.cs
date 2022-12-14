// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("[" + arr[i, j] + "]");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixWithRundomNumbers(double [,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rand.Next(-9, 10) + rand.NextDouble(), 1);
        }
    }
}
int EnterNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int columns = EnterNumber("Enter the number of columns");
int lines = EnterNumber("Enter the number of lines");
double [,] matrix = new double [columns, lines];
FillMatrixWithRundomNumbers(matrix);
PrintMatrix(matrix);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



void FindNumber(string meseg, int[,] arr)
{
    System.Console.WriteLine(meseg);
    string[] desiredNumber = Console.ReadLine().Split("; ");
    int numberY = Convert.ToInt32(desiredNumber[0]);
    int numberX = Convert.ToInt32(desiredNumber[1]);
    if (numberX <= arr.GetLength(0) && numberY <= arr.GetLength(1))
        System.Console.WriteLine("Number: " + arr[numberX - 1, numberY - 1]);
    else
        System.Console.WriteLine("Not suitable id");
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("[" + arr[i, j] + "]");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

int EnterNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int columns = EnterNumber("Enter the number of columns");
int lines = EnterNumber("Enter the number of lines");
int[,] matrix = new int[columns, lines];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
FindNumber("Write the id of the number (example 1; 1)", matrix);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int m = 10;
int n = 10;
int [,] array = new int [m, n];
int indexCol = 0;
int indexRow = 0;

for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {   
        array[indexRow, indexCol] = new Random().Next(10,100);
        Console.Write($"{array[indexRow, indexCol]}  ");
        indexCol++;
    }
    Console.WriteLine();
    indexRow++;
    indexCol = 0;
}
indexRow = 0;
Console.WriteLine();

double result = 0;
int count = 1;
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++)
    {   
        result += array[indexRow, indexCol];
        indexRow++;
    }
    result = result / m;
    Console.WriteLine($"Среднее арифметическое {count} столбца равно {result}");
    count++;
    result = 0;
    indexRow = 0;
    indexCol++;
}