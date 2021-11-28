//4.Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.
void SetArray2D(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            a[i, j] = new Random().Next(-25, 25);

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
void Task04(int[,] a, out int count)

{

    count = 0;

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            if (a[i, j] > -9 && a[i, j] < 0) { count++; } // count=count+1;

        }

    }

}

int[,] a;
a = new int[2, 2];
int count;
SetArray2D(a);
Print(a);
Task04(a, out count);
Console.WriteLine($"количество отрицательных элементов больше -9: {count} ");
