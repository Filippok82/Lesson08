// вывести на экран числа от 1 до 10, без использов. цикла

/* void Loop(int i)
{
    Console.WriteLine($"{i} ");
    if(i<10) Loop(i+1);
}
Loop(1); */

//Факториал

/* ulong F (ulong n) 
{
    if(n==0) return 1;
    
    else return F(n-1)*n;
}
Console.WriteLine(F(5));
 */

 //Фибоначи

 int Fib(int n)
 {
     if (n==0) return 0;
     if(n==1|| n==2) return 1;
     else return  Fib(n-1)+Fib(n-2);
 }
 Console.WriteLine(Fib(6));