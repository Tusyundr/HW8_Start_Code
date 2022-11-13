// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int arraymax = 100;
    int arraymin = 10;
    int arraysize = 2;
    int[,,] array = new int[arraysize, arraysize, arraysize];

    int[] darray = new int[arraysize * arraysize * arraysize];
    int temp;
    for (int i = 0; i < darray.Length; i++) 
    {
        while (darray[i] == 0)
        {
            temp = new Random().Next(arraymin, arraymax);
            if (Array.IndexOf(darray, temp, i) == -1)
            {
                darray[i] = temp;
            }
        }
    }
      int count = 0;
    for (int arraydepth1 = 0; arraydepth1 < arraysize; arraydepth1++)
    {
        Console.Write(">");
        for (int arraydepth2 = 0; arraydepth2 < arraysize; arraydepth2++)
        {
            Console.Write(">");
            for (int arraydepth3 = 0; arraydepth3 < arraysize; arraydepth3++)
            {
                array[arraydepth1, arraydepth2, arraydepth3] = darray[count];
                count++;
                Console.WriteLine($"\t{array[arraydepth1, arraydepth2, arraydepth3]}\t({arraydepth1},{arraydepth2},{arraydepth3})");
            }
        }  
    }