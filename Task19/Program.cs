// Дан целочисленный двумерный массив, размерности n х m. 
//Сформировать новый массив, состоящий из противоположных соответствующих элементов .

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

void Print2D(int[,] a)

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


void NewArray2D(int[,] a, int[,] newArray)
{
    int l = 0;
    int k = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (l = 0; l < newArray.GetLength(0); l++)
            {
                for (k = 0; k < newArray.GetLength(1); k++)
                {
                    
                    if (i==l&&j==k) newArray[l, k] = a[i, j] * -1;
                   
                }         

            }

        }

    }

}
void PrintNewArray(int[,] newArray)

{

    for (int l = 0; l < newArray.GetLength(0); l++)

    {

        for (int k = 0; k < newArray.GetLength(1); k++)

        {

            Console.Write($"{newArray[l, k],4}");

        }

        Console.WriteLine();

    }

}


int n = 3;
int m = 3;
int[,] newArray = new int[m, n];
int[,] a = new int[m, n];

SetArray2D(a);
Print2D(a);
Console.WriteLine();
NewArray2D(a, newArray);
PrintNewArray(newArray);

