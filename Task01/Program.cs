//Двумерный объект
/* 
int[,] a;// ссылочный тип
//int i; значимый 

a = new int[3, 5];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = i * 10 + j;
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0,4}",a[i, j] + " ");
    }
    Console.WriteLine();
}

 */



//Методом

void SetArray2D(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=i*10+j;
        }
    }
}


void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}

//Main
int[,] a;
a=new int[10,4];

Print(a);
SetArray2D(a);
Console.ReadKey();
Console.Clear();
Print(a);
