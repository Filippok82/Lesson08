//14.Дан целочисленный двумерный массив, размерности n х m. 
//Найти номера нечетных элементов, стоящих на четных местах
void SetArray2D(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            a[i, j] = new Random().Next(0, 100);

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


void ElementsIndexs(int[,] a)
{

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {

            if (a[i, j] % 2 != 0 && i % 2 == 0 && j % 2 == 0)
            {
                Console.WriteLine($" {i}, {j}");

            }


        }

    }




}



int[,] a = new int[3, 4];
SetArray2D(a);
Print(a);
ElementsIndexs(a);






