//5.Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах.
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

void Task05(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            if (i % 2 == 0 && j % 2 == 0 && a[i, j] % 2 != 0) { Console.WriteLine($"{i,2},{j,2} = {a[i, j],4}"); }

        }

    }

}
int[,] a;
a = new int[2, 2];
SetArray2D(a);
Print(a);
Task05(a);
/* Console.WriteLine($" {a} "); */
