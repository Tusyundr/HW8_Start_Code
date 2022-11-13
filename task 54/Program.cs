// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m, n, arrmax, arrmin;

Console.WriteLine("Введите количество строк массива, m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцов массива, n: ");
n  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение элемента массива: ");
arrmax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arrmin  = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateRandArray(m, n, arrmax, arrmin);
Console.WriteLine("Исходный массив:");
PrintArray(arr, m, n);
 for (int currentindex = 0; currentindex < m; currentindex++)
    {
        SortStrOfArray(arr, currentindex);
    }
    Console.WriteLine("\nРезультат: ");
PrintArray(arr, m, n);


//Метод, создающий массив, заполненный случайными числами
int[,] CreateRandArray(int rows, int columns, int max, int min)
{
var array = new int[rows, columns];


for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }    
    }
return array;
}

// Метод, выводящий массив на печать
void PrintArray (int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
        {
          Console.Write(array[i, j] + "\t");  
        }  
    Console.WriteLine();   
    }
}

// Метод, производящий сортировку массива
void SortStrOfArray(int[,] array, int currentstringindex)
    {
        int temp;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = array.GetLength(1) - 1; j > i; j--)
            {
                if (array[currentstringindex, j] < array[currentstringindex, j - 1])
                {
                    temp = array[currentstringindex, j];
                    array[currentstringindex, j] = array[currentstringindex, j - 1];
                    array[currentstringindex, j - 1] = temp;
                }
            }
        }
    }