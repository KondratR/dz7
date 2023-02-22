﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
Random rand = new Random();
int[,] matrix = new int[rows, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rand.Next(0, 21);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[i,j] + "\t");
}
System.Console.WriteLine();
}
}

void Check (int[,] matrix, int Row, int Col)
{
    if (Row<matrix.GetLength(0) && Col < matrix.GetLength(1))
    {
        System.Console.WriteLine($"({Row},{Col}) - {matrix[Row, Col]}");
    }
    else
    {
        System.Console.WriteLine($"({Row},{Col}) - такого числа не существует");
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
Check(myMatrix, ReadInt("Введите номер строки "), ReadInt("Введите номер столбца "));
