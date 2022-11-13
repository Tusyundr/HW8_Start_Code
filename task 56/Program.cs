// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
MinSumString (arr, m, n);



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

//Метод, который выводит номер строки с наименьшей суммой элементов
void MinSumString (int[,] array, int rows, int columns)
{
 int currentminstring = Int32.MaxValue;
 int currentindexminstring = -1;

    for (int i = 0; i < rows; i++)
    {
        int sumstringelement = 0;
        for (int j = 0; j < columns; j++)
        {
            sumstringelement += array[i, j];
        }
           
        if (sumstringelement < currentminstring)
        {
            currentminstring = sumstringelement;
            currentindexminstring = i;
        }
    }
 Console.WriteLine("Строка с наименьшей суммой элементов: \nrow " + (currentindexminstring + 1) + " sum = " + currentminstring);
}