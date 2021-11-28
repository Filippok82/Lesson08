//2.Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.
void SetArray2D(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            a[i, j] = new Random().Next(1, 25);

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

void Task02(int[,] a, out int sum, out int multi)

{

    sum = 0;

    multi = 1;

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            if (a[i, j] % 2 == 0) { sum = sum + a[i, j]; multi = multi * a[i, j]; }

        }

    }

}

int[,] a;
a = new int[2, 2];
int s, m;
SetArray2D(a);
Print(a);
Task02(a, out s, out m);
Console.WriteLine($"{s} {m}");




