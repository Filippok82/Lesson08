// Дан целочисленный двумерный массив, размерности n х m. 
//Вывести на экран те элементы, у которых остаток от деления на m равен k. 

void SetArray2D(int[,] a)

{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            a[i, j] = random.Next(0, 40);

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


void ElementSpecific(int[,] a, int m)
{
   
    Console.WriteLine(" Введите число k: ");
    int k = Convert.ToInt32(Console.ReadLine());


    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {

            if (a[i, j] % m == k)
            {
                Console.Write($"\n элемент:{a[i, j]}");

            }
            
        }

    }




}


int m = 4;
int n = 3;
int[,] a = new int[n, m];
SetArray2D(a);
Print(a);
Console.WriteLine();
ElementSpecific(a,m);
