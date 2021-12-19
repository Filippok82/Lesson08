// 11.Дан целочисленный двумерный массив, размерности n х m.
//Вывести его элементы, индексы которых являются степенями двойки (1, 2, 4, 8, 16, ...).
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


void ElementsIndexSquare(int[,] a)
{
    
    int n=0;
     for (int i =0; i < a.GetLength(0); i++)
    {
        for (int j =0; j < a.GetLength(1); j++)
        {
          
          if (i == (int)Math.Pow(2, n) && j == (int)Math.Pow(2, n))
            {
                Console.WriteLine($"{i},{j} - {a[i, j]}");
                n++;
            }
            
           

        }

    }

    

    
}



int[,] a = new int [20, 25];
SetArray2D(a);
Print(a);
ElementsIndexSquare(a);




