// 6.Дан целочисленный двумерный массив, размерности n х m. Найти максимум и минимум. Поменять их местами.

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


int MinMax(int[,] a)
{
    int min = 40;
    int max = 0;
    int maxi=0, maxj=0, mini=0, minj=0;
    for (int i = 0; i < a.GetLength(0); i++)
    {

        for (int j = 0; j < a.GetLength(1); j++)

        {
            if (a[i, j] < min) { min = a[i, j]; mini=i; minj=j; }
            if (a[i, j] > max) { max = a[i, j]; maxi=i; maxj=j; }
        }
    }

    Console.WriteLine($"MIN{min} MAX{max}");

    int value = a[mini, minj];
    a[mini, minj] = a[maxi, maxj];
    a[maxi, maxj] = value;
    return min + max;
}


int[,] a;

a = new int[2, 2];

SetArray2D(a);
Print(a);
int sum = MinMax(a);
Console.WriteLine($"OUT: SUM={sum}");
Print(a);



