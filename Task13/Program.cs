// 13.Дан целочисленный двумерный массив, размерности n х m.
// Вывести на экран элементы, которые являются квадратами какого-либо числа.

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


void ElementsSquareNumber(int[,] a)
{
    Console.WriteLine("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {

            if (a[i, j] == (int)Math.Pow(n, 2))
            {
                Console.WriteLine($" Квадрат числа {n} - {a[i, j]}");
                
            }

           
        }

    }




}



int[,] a = new int[5, 6];
SetArray2D(a);
Print(a);
ElementsSquareNumber(a);





