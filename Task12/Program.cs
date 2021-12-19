// 12.Дан целочисленный двумерный массив, размерности n х m. Найти количество элементов кратных 7.

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


void ElementDivisible7(int[,] a)
{
    
    
     for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i,j]%7==0 && a[i,j]!=0)
            {
                Console.WriteLine($"{a[i, j]} Число кратное 7 ");
                
            }
            

        }

    }

    

    
}



int[,] a = new int [3, 4];
SetArray2D(a);
Print(a);
ElementDivisible7(a);






