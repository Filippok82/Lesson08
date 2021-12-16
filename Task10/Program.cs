// 10.Дан целочисленный двумерный массив, размерности n х m. 
//Выяснить, в какой строке последовательность является возрастающей или убывающей.
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


void FirstElementSequence(int[,] a)
{
    
    
     for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] > a[i,j+1])
            {
                Console.WriteLine($"{a[i, j]} последовательность убывающая ");
                break;
            }
            else if (a[i, j] < a[i,j+1])
            {
                Console.WriteLine($"{a[i, j]}  последовательность возрастающая ");
                break;
            }

        }

    }

    

    
}



int[,] a = new int [3, 4];
SetArray2D(a);
Print(a);
FirstElementSequence(a);






