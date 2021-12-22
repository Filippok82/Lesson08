//16.Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты.

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

            Console.Write($"{a[i, j],6}");

        }

        Console.WriteLine();

    }

}


void ChangeSquare(int[,] a)
{
    
    for ( int i = 0; i < a.GetLength(0); i++)
    {
        for ( int j = 0; j < a.GetLength(1); j++)
        {

          a[i, j] *= a[i,j];         
                
            
            
        }
    }
   
}



int[,] a = new int[3, 4];

SetArray2D(a);
Print(a);
Console.WriteLine();
ChangeSquare(a);
Print(a);




