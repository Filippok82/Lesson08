//09. 09.Дан целочисленный двумерный массив, размерности n х m. 
//Выяснить, какое число встречается в какой строке раньше — положительное или отрицательное.

void SetArray2D(int[,] a)

{

    for (int i = 0; i < a.GetLength(0); i++)

    {

        for (int j = 0; j < a.GetLength(1); j++)

        {

            a[i, j] = new Random().Next(-40, 40);

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


void FirstElement(int[,] a)
{
    
    
     for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] > 0)
            {
                Console.WriteLine($"{a[i, j]}  положительное встречается раньше ");
                break;
            }
            else if (a[i, j] < 0)
            {
                Console.WriteLine($"{a[i, j]}  отрицательное встречается раньше ");
                break;
            }

        }

    }

    

    
}



int[,] a = new int [3, 4];
SetArray2D(a);
Print(a);
FirstElement(a);
Print(a);




