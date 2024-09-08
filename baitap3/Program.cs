
namespace baitap3;

class Program
{
    static void Main(string[] args)
    {
        //cau_01();
        //cau_02();
        //cau_05();
        //cau_06();
        //cau_09();
        //cau_03();
        //cau_04();
        //cau_07a();
        cau_07b();
        //cau_10();
        //cau_11();





    }
    static void cau_01()
   { 
    Console.WriteLine("Nhap vao so a:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a%2==0)
    {Console.WriteLine("a la so chan");}
    else
    {Console.WriteLine("a la so le"); }
   }
   static void cau_02()
   { 
     float a,b,c,max;
     Console.Write("Nhap vao so a :");
     a = Convert.ToSingle (Console.ReadLine());
     Console.Write("Nhap vao so b : ");
     b = Convert.ToSingle (Console.ReadLine());
     Console.Write("Nhap vao so c :");
     c = Convert.ToSingle (Console.ReadLine());
     if (a>b) {max =a;} else {max = b;}
     if (max<c) {max= c;} 
     Console.WriteLine("max ="+ max);

   }
   static void cau_05()
   {
    float sum = 0;
    
    Console.WriteLine( "Nhap vao 10 so : " );
     for(int i = 0; i<10;i++)
     {
    
       float a = Convert.ToSingle(Console.ReadLine());
        sum+=a;
     }
       float average = sum/10;
       Console.WriteLine($"sum = {sum}");
       Console.WriteLine($"average = {average}");
   }

static void cau_06()
{
    for (int i=1;i<=10;i++)
      { for(int j=1; j<=10; j++)
         {
            Console.WriteLine ("{0}*{1} = {2}", i,j,i*j);
            
         }
         Console.WriteLine("--------------");
      }
     
}
static void cau_09()
{ int n = Convert.ToInt32(Console.ReadLine());
float sum = 0.0f ;
  for (int i=1; i<=n;i++)
 {
    sum+=1/(float)i;
 }
Console.WriteLine($"sum = {sum}");
}
static void cau_03()
{
    float x,y;
    x = Convert.ToSingle(Console.ReadLine());
    y = Convert.ToSingle(Console.ReadLine());
    if (x>0 && y>0) 
    {  Console.Write("The coordinate point {x}{y} lies in the First quandrant."); }
    else 
      if(x<0 && y>0)
      {Console.Write("The coordinate point {x}{y} lies in the Second quandrant.");}
      else if (x<0 && y<0)
      {Console.Write("The coordinate point {x}{y} lies in the Third quandrant.");}
      else if (x>0 && y<0)
      {Console.Write("The coordinate point {x}{y} lies in the Fourth quandrant.");}
      else
      {Console.Write("The coordinate point {x}{y} lies at the origin.");}

}
static void cau_04() 
{
float a,b,c;
Console.WriteLine("Nhap vao 3 canh a,b,c:");
a = Convert.ToSingle(Console.ReadLine());
b = Convert.ToSingle(Console.ReadLine());
c = Convert.ToSingle(Console.ReadLine());
if (a+b>c && a+c>b && b+c>a) 
{
    if(a == b && b!=c|| a==c && c!=b || b==c && c!=a ) {Console.WriteLine( "Day la tam giac can ");}
    else if(a*a==b*b+c*c|| b*b==a*a+c*c || c*c==a*a+b*b) {Console.WriteLine("Day la tam giac vuong ");}
    else if(a==b && b==c ){Console.WriteLine("Day la tam giac deu ");}
    else {Console.WriteLine("Day la tam giac thuong ");}

}
else {Console.WriteLine("Day khong phai la tam giac") ;}
}
static void cau_07a()
{
  for (int i = 1; i<5; i++)
  {
    {for (int j = 1; j<=i;j++)
    Console.Write(j);
  }
  Console.WriteLine();
   
}
}

static void cau_07b()
{ int sohang;
int n =1;
Console.Write("Nhap vao so hang: ");
sohang = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=sohang; i++)
  {
    {for (int j = 1; j<=i;j++, n++)
    Console.Write(n);
       
  }
  
  Console.WriteLine();
  
   
}  
   
}  


static void cau_11()
{
int n;
int mark = 1;
Console.WriteLine("Nhap vao mot so can kiem tra:");
n = Convert.ToInt32(Console.ReadLine());
if(n<2)
{Console.WriteLine($"{n} khong phai la so nguyen to");}
else
  for (int i=2; i<n;i++)
  {
    if((n%i==0))
    {
      mark = 0;
      break;
    }
  }
  if (mark==1)
  {Console.WriteLine ($"{n} la so nguyen to");}
  else
  {Console.WriteLine($"{n} khong la so nguyen to") ; }
   
}
static void cau_10()
{
  int number ;
  int i, sum ;
  sum = 0;
  Console.WriteLine ("Nhap vao so: ");
  number = Convert.ToInt32(Console.ReadLine());
  for (i=1; i< number; i++)
  {
    if ((number%i)== 0)
    {
       sum =sum + i;
    }
     }
      if (sum== number)
    {Console.WriteLine($"So nhap vao {number} la perfect number");}
    else
    {Console.WriteLine($" So nhap vao {number} khong la perfect number");}  
}
}


