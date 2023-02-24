/*
2 Задача
int[,] Created2Array(int rows)
{
    {
        for (int j = 0; j < rows; j++)
        {
            createdArray[i, j] = new Random().Next(0,10);
        }
    }
    return createdArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
    int[,] createdArray = new int[rows, rows];
    for (int i = 0; i < rows; i++)


int  [,] CoupArray(int [,] array, int rows)
{
    int min=0;
    int sum=0;
    int newI=1;
    while(rows>newI)
    {
        for (int i = 0; i < rows; i++)
       {
           for (int j = 0; j < rows; j++)
           {
            
               sum+=array[i,j];
               if(newI==1)
               min=sum;
           }
            Console.WriteLine($"сумма элементов {newI} столбца = {sum};");
            if(sum<min)
               {
                min=sum;
               }
            sum=0;
            newI++;
       }
    } 
    Console.WriteLine();
    Console.WriteLine($"Самая наименьшая сумма это: {min}");
    return array;
}

Console.WriteLine("Строк и столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Created2Array(rows);
Show2Array(newArray);
CoupArray(newArray, rows);
*/
// Частотный словарь
/*
int[,] Created2Array(int rows)
{
    int[,] createdArray = new int[2, rows];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            createdArray[i, j] = new Random().Next(1, 10);
        }
    }
    return createdArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] Forea(int[,] array)
{
    int[] countArray = new int[9];
    {
        foreach (var n in array)
        {
            countArray[n - 1]++;
        }
    }
    Console.WriteLine(string.Join(" ", countArray));
    Console.WriteLine("^ ^ ^ ^ ^ ^ ^ ^ ^ ");
    Console.WriteLine("| | | | | | | | | ");
    Console.WriteLine("1 2 3 4 5 6 7 8 9 ");
    return array;
}

Console.WriteLine("Строк и столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Created2Array(rows);
Console.WriteLine();
Show2Array(newArray);
Forea(newArray);
*/
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] Created2Array(int rows, int cols)
{
    int[,] createdArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            createdArray[i, j] = new Random().Next(0, 10);
        }
    }
    return createdArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CoupArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m];
                    array[i, m] = array[i, m + 1];
                    array[i, m + 1] = temp;
                }
            }
        }
    }
    return array;
}


Console.WriteLine("столбцов: ");
int stob = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("рядов: ");
int col = Convert.ToInt32(Console.ReadLine());
if (stob > 0 && col > 0)
{
    int[,] newArray = Created2Array(stob, col);
    Show2Array(newArray);
    Show2Array(CoupArray(newArray));
}
else Console.WriteLine("Error");
*/
