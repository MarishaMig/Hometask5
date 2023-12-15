/* 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет */

/*
Console.WriteLine("Введите позицию элемента:");
Console.Write("строка - ");
int line=Convert.ToInt32(Console.ReadLine());
Console.Write("столбец - ");
int column=Convert.ToInt32(Console.ReadLine());

int[,] array = new int[5,5];
void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}

void FindElementArray(int line, int column)
{    
    if (line<array.GetLength(0) && column<array.GetLength(1))
    {
        Console.WriteLine(array[line,column]);
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве!");
    }
}

CreateArray();
PrintArray();
Console.WriteLine();
FindElementArray(line,column);
*/

/* 2. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */

int[,] array = new int[5,5];
void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

void ChangeArray()
{    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp=array[0,i];
        array[0,i]=array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i]=temp;
    }
}

CreateArray();
PrintArray();
Console.WriteLine("  -------   ");
ChangeArray();
PrintArray();









/* 3. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.  */








/*Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца  */

