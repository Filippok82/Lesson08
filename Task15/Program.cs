// 15. Дан целочисленный двумерный массив, размерности n х m. Найти максимум и минимум. Поменять их местами.

void SetArray2D(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            a[i, j] = new Random().Next(0, 40);

        }

    }

}

void Print(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            Console.Write($"{a[i, j],4}");

        }

        Console.WriteLine();

    }

}


void MinMax(int[,] a, out int min, out int max)
{
    int i = 0;
    int j = 0;
    min = a[i, j];
    max = a[i, j];
    int mini = 0; int minj = 0;
    int maxi = 0; int maxj = 0;
    for ( i = 0; i < a.GetLength(0); i++)
    {
        for ( j = 0; j < a.GetLength(1); j++)
        {


            if (a[i, j] < min) { min = a[i, j]; mini = i; minj = j; }
            if (a[i, j] > max) { max = a[i, j]; maxi = i; maxj = j; }
        }
    }
    Console.WriteLine($"MIN{min} MAX{max}");

    int value = a[mini, minj];
    a[mini, minj] = a[maxi, maxj];
    a[maxi, maxj] = value;
}



int[,] a = new int[3, 4];

int min, max;
SetArray2D(a);
Print(a);
MinMax(a,out min, out max);
Print(a);



