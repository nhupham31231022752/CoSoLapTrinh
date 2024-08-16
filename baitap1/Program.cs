using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace baitap1;

class Program
{    static void Main(string[] args)
    {
        //cau_01 ();
        // cau_02();
        //cau_03();
          cau_04();
        //cau_08();
         // cau_09();
    }
    static void cau_01()
     {int a;
     int b;
     Console.WriteLine(" Nhap vao so a :");
     a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Nhap vao so b :");
     b = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Tong hai so a va b:");
     Console.WriteLine("{0} + {1} = {2}",a,b,a+b); }
       static void cau_02()
       { int a = 5;
         int b = 10;
        Console.WriteLine("Before Swap a = "+a+ "b = "+b);
        b = b-a;
        a = a+b;
        Console.WriteLine("Before Swap a = "+a+ "b = "+b);
       }
       static void cau_03()
       { float c = 10.5f ;
       float d = 2.5f ;
       Console.WriteLine($"{c}*{d}"+ "=" + c*d);
       }
       static void cau_04()
       {double meter, feet;
        Console.WriteLine(" Nhap vao so feet: ");
        feet= Convert.ToDouble(Console.ReadLine());
        meter= feet/3.28;
        Console.WriteLine("Doi qua meter " + meter );
       }

       static void cau_08()
       {double R, s, pi ;
       pi=3.14;
       Console.WriteLine("Nhap vao ban kinh");
       R = Convert.ToDouble(Console.ReadLine());
       s= pi* R * R;
       Console.WriteLine("Dien tich hinh tron :" + s);
             
       }

    static void cau_09()
    {
      double canh,S;
      Console.WriteLine("Nhap vao canh hinh vuong"); 
      canh= Convert.ToDouble(Console.ReadLine());
      S = canh*canh;
     Console.WriteLine("Dien tich hinh vuong: "+ S);
    }

}

