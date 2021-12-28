//17. Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их противоположные значения.

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


void OppositeElement(int[,] a)
{

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {

            a[i, j] = a[i, j] * -1;
            Console.Write($"{a[i, j],4}");

        }
        Console.WriteLine();
    }

}


int[,] a = new int[3, 3];
SetArray2D(a);
Print(a);
Console.WriteLine();
OppositeElement(a);





