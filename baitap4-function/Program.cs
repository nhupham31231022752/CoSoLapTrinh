using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace baitap4_function;

class Program
{
   static void Main(string[] args)
    {
       // Maxofthreenumbers ();
         // PrintSum();
         //PrintFactorial();
         //CheckPrime();
         //PrintPrimeNumbersUnderN (10);
         //PrintFirstNPrimeNumber (10);
         //CheckPerfectNumber();
         PrintPerfectNumberUnderN(1000);
      
        
    }
    static void Maxofthreenumbers()
    {
        int a,b,c;
        a= Convert.ToInt32(Console.ReadLine());
        b= Convert.ToInt32(Console.ReadLine());
        c= Convert.ToInt32(Console.ReadLine());
        int max = Max(a,b,c);
        Console.WriteLine($"max:{max}");
    }
    static int Max( int x, int y, int z )
    {
      int max;
      if (x<y) {max = y;} else {max = x;}
      if(max<z) {max = z;}
      return max;
    }
  static int Sum (params int [] pars)
{
        int sum = 0 ;
    foreach (int i in pars)
    {sum += i;}
    return sum;
}
static void PrintSum()
{int sum = Sum(1,2,3,7,9,10);
 Console.WriteLine($"sum: {sum}"); 
}
static void PrintFactorial ()
{   Console.Write(" Nhap vao so can tinh: ");
    int n = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(n);
Console.WriteLine ($"{n}! = {factorial}");
}
static int Factorial(int n)
{ int factorial=1;
 for (int i=1; i<=n;i++)   
 {      
    factorial *= i;
 }
 return factorial;
}
static void CheckPrime()
{ 
Console.Write("Nhap vap so can kiem tra: ");
int n = Convert.ToInt32(Console.ReadLine());
 bool KetQua= Prime(n);
 System.Console.WriteLine(KetQua);
}

static bool Prime(int n)
{ int mark=1;
if (n<2) {return false;}
else
   for (int i=2; i<n; i++)
{
    if(n%i==0)
    {mark = 0;
    break;}
  
}
if(mark==1){ return true;}
else { return false;}

}
static void PrintPrimeNumbersUnderN(int n)
{
    for (int i=1; i<=n;i++)
    {bool KetQua = Prime(i);
    if (KetQua==true)
    {System.Console.WriteLine(i);}
    }
}
static void PrintFirstNPrimeNumber(int n)
{
    int count = 0;
    int number = 1;
    while (count<=n)
    {
       bool KetQua = Prime(number);
    if (KetQua==true) 
    {
        System.Console.WriteLine($"{count}:{number}");
        count++;
    }
    number++;
    }
}
static bool PerfectNumber(int number)
{
if (number<=1) {return false;}
int sum = 0;
for (int i=1; i<=number/2;i++)
{
    if (number%i==0) {sum+=i;}
}
return sum==number;
}
static void CheckPerfectNumber()
{
   System.Console.WriteLine("Nhap vao so can kiem tra: ");
   int number = Convert.ToInt32(Console.ReadLine());
   if(PerfectNumber(number))
   {
    System.Console.WriteLine($" {number} la so hoan hao");
   }
   else
   {
    System.Console.WriteLine($" {number}  khong la so hoan hao");
   }
}
static void PrintPerfectNumberUnderN(int n)
{
    for (int i=1; i<n;i++)
    {
        if(PerfectNumber(i))
        {System.Console.WriteLine(i);}
    }
}


   

}


