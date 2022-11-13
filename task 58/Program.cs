// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m, n, arrmax, arrmin;

Console.WriteLine("Перемножать можно только матрицы одинаковой размерности, поэтому размерность запрашивается один раз для обоих массивов. ");
Console.WriteLine("Введите количество строк массива, m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцов массива, n: ");
n  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение элемента массива: ");
arrmax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arrmin  = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandArray(m, n, arrmax, arrmin);
Console.WriteLine("Исходный массив A:");
PrintArray(matrix1, m, n);
int[,] matrix2 = CreateRandArray(m, n, arrmax, arrmin);
Console.WriteLine("\nИсходный массив B:");
PrintArray(matrix2, m, n);
ResultMatrix(matrix1, matrix2, m, n);


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

//Метод, который находит произведение двух матриц
void ResultMatrix(int[,] array1, int[,] array2,  int rows, int columns)
{
int[,] resultarray = new int[rows, columns];

    Console.WriteLine("\nРезультат:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          for (int k = 0; k < rows; k++)
                {
                    resultarray[i, j] += array1[i, k] * array2[k, j];
                }
            Console.Write(resultarray[i, j] + "\t|");
                }
        Console.WriteLine("<-- row " + (i + 1));
    }
}