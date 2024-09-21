using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace baitap_arrays;

class Program
{
    static void Main(string[] args)
    {    int [] a = new int [5];
        InputRandomArray(a);
         PrintArrayA(a);     
        //PrintAverage(a);
        //PrintResult();
       //PrintIndex();
       //PrintMaxMin();
       /*BubbleSort(a);
       Console.WriteLine();
        PrintArrayA(a);*/
        /*SelectionSort(a);
        Console.WriteLine();
        PrintArrayA(a);*/
        /*Console.WriteLine();
        InsertionSort(a);
        PrintArrayA(a);*/
        /*Console.WriteLine();
        PrintResultRemove(a);*/
        /*Console.WriteLine();
         Reverse(a);
        PrintArrayA(a)*/
        int dupvalue=0;
        PrintResultDuplicate(a,ref dupvalue);
        
        

    }

static  void InputRandomArray (int [] a)
{ 
    
        Random rnd = new Random();
        for (int i = 0; i<a.Length;i++) 
      {a[i] = rnd.Next(10);
      }
      
     
}
static void PrintArrayA(int[] a)
{
foreach (int i in a)
{Console.WriteLine(i);}
}
static void PrintAverage(int [] a)
{
   double average = Average(a);
   Console.WriteLine($"average:{average}");
}
static double Average(int[] a)
{ int sum=0;
foreach (int i in a)
{
    sum+=i;
}
return sum/a.Length;
}
static bool CheckArray ( int []a, int value)
{
foreach (int val in a)
{
    if (val == value)
    {return true;}
}
return false;
}
static void PrintResult ()
 {   int [] a = new int [5];
     bool result = CheckArray( a ,6);
if(result)
{ Console.WriteLine("so 6 co chua trong array");}
else {Console.WriteLine(" so 6 khong co chua trong array");}
}
static bool Index (int[]a, int value)
{
for (int index=0;index<a.Length;index++)
{  
    if(a[index]==value) 
    {   Console.WriteLine($"{a[index]} có index {index}");
        return true;}

}
return false;
}
static void PrintIndex()
{  int [] a = new int [5];
InputRandomArray( a);
PrintArrayA(a);
bool result = Index(a,8);

if(result == false) { Console.WriteLine("khong ton tai so trong array");}
}
static void PrintMaxMin()
{int [] a = new int [5];
int min =0;
int max = 1;
InputRandomArray( a);
PrintArrayA(a);
FindMaxMin(a, ref min , ref max);
}
static void FindMaxMin (int[]a,  ref int min, ref int max)
{ min=a[1];
for (int index=0; index<a.Length;index++)
{
if(a[index]<min) {min= a[index];}
if(a[index]>max) {max = a[index];}
}

Console.WriteLine ($"min : {min}");
Console.WriteLine($"max : {max}");
}
static void BubbleSort(int[]a)
{   
    for(int i=0;i<a.Length;i++)
    {
         for(int j=0; j<a.Length-1;j++)
        {
            if(a[j]>a[j+1])
            {
                int temp = a[j];
                a[j] = a[j+1];
                a[j+1] = temp;
            }
        }
    }

}
static void SelectionSort(int[]a)
{   
    for (int i=0; i<a.Length; i++)
    { int index=i;
     int min  = a[i];
     for(int j = i+1; j<a.Length;j++)
    {
        if(a[j]< a[index])
        {
            index=j;
            min=a[j];

        }
    }
    int t = a[index];
    a[index]= a[i];
    a[i]=t;
    }
 
}
static void InsertionSort(int []a)
{
    for(int i=1;i<a.Length;i++)
    {
       int key=a[i] ;
       int j = i-1;
       while (j>=0 && a[j]>key)
       {
        a[j+1]=a[j];
        j=j-1;
       }
       a[j+1]=key;
    }
    
}
static bool RemoveElement (int[]a,int ele)
{
    for (int i=0; i<a.Length;i++)
    {
        if (a[i]==ele) 
        { for (int j=i; j<a.Length-1;j++)
           { a[j]=a[j+1];
           }
           return true;
        }

        

}
return false;
}
static void PrintResultRemove(int[]a)
{
 
  bool res =  RemoveElement(a,a[1]);
  if (res){Array.Resize(ref a,a.Length -1);}
  PrintArrayA(a);
}
static void Reverse (int []a)
{ int temp = 0;
  
      for (int index=0;index<a.Length-1-index;index++)
        {int j= a.Length-1-index;
        temp=a[index];
        a[index]=a[j];
        a[j]=temp;}
    
}
static bool FindDuplicate(int[]a, ref int dupvalue)
{ int result=0;
    for( int i=0;i<a.Length-1;i++)
    {
        for(int j=1;j<a.Length;j++)
        {
            if(a[i]==a[j] && (i!=j))
            {Console.WriteLine($"a[{i}] la duplicate cua a[{j}]");
            dupvalue = a[i];
            result =1;
            }
        }
    }
    if (result==1){Console.WriteLine("have duplicate value");return true;}
    else {Console.WriteLine("no duplicate value");return false;}
}

static bool RemoveDuplicate(int[]a, ref int dupvalue) 
{ 
bool result = FindDuplicate(a,ref dupvalue);
if (result)
{ 
for (int i=0; i<a.Length;i++)
    {
        if (a[i]==dupvalue) 
        { for (int j=i; j<a.Length-1;j++)
           { a[j]=a[j+1];     }
           return true;
        }      
    }
}
return false;
}
    
static void PrintResultDuplicate(int[]a, ref int dupvalue)
{
   bool res =  RemoveDuplicate(a,ref dupvalue);
  if (res){Array.Resize(ref a,a.Length -1);}
  PrintArrayA(a);
}
}





