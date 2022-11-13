// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность первой матрицы (через Enter): ");
    int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }
Console.WriteLine("Введите размерность второй матрицы (через Enter): ");
    int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        for (int i = 0; i < B.GetLength(0); i++)
        {
              for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
         }
 
Console.WriteLine("\nМатрица A:");
PrintMatrix(A);
Console.WriteLine("\nМатрица B:");
PrintMatrix(B);
Console.WriteLine("\nМатрица C = A * B:");
int[,] C = MultMatrix(A, B);
PrintMatrix(C);
 
    
static int[,] MultMatrix(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }

static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }

// Решение только для матриц одинаковой размерности, заполненных случайными числами
// int m, n, arrmax, arrmin;


// Console.WriteLine("Введите количество строк массива, m: ");
// m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбцов массива, n: ");
// n  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально допустимое значение элемента массива: ");
// arrmax  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
// arrmin  = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = CreateRandArray(m, n, arrmax, arrmin);
// Console.WriteLine("Исходный массив A:");
// PrintArray(matrix1, m, n);
// int[,] matrix2 = CreateRandArray(m, n, arrmax, arrmin);
// Console.WriteLine("\nИсходный массив B:");
// PrintArray(matrix2, m, n);
// ResultMatrix(matrix1, matrix2, m, n);


// //Метод, создающий массив, заполненный случайными числами
// int[,] CreateRandArray(int rows, int columns, int max, int min)
// {
// var array = new int[rows, columns];


// for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }    
//     }
// return array;
// }

// // Метод, выводящий массив на печать
// void PrintArray (int[,] array, int rows, int columns)
// {
//     for (int i = 0; i < rows; i++)
//     {
//        for (int j = 0; j < columns; j++)
//         {
//           Console.Write(array[i, j] + "\t");  
//         }  
//     Console.WriteLine();   
//     }
// }

// //Метод, который находит произведение двух матриц
// void ResultMatrix(int[,] array1, int[,] array2,  int rows, int columns)
// {
// int[,] resultarray = new int[rows, columns];

//     Console.WriteLine("\nРезультат:");
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//           for (int k = 0; k < rows; k++)
//                 {
//                     resultarray[i, j] += array1[i, k] * array2[k, j];
//                 }
//             Console.Write(resultarray[i, j] + "\t|");
//                 }
//         Console.WriteLine("<-- row " + (i + 1));
//     }
// }