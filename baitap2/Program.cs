using Microsoft.Win32.SafeHandles;

namespace baitap2;

class Program
{
    static void Main(string[] args)
    { //cau_01();
    //cau_02();
    //cau_03();
    cau_04();
        
    }
    static void cau_01()
    {float a,b;
    Console.Write ("Nhap va so a:");
    a = Convert.ToSingle (Console.ReadLine());
    Console.Write ("Nhap va so b:");
    b = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine($"a+b = {a+b}");
    Console.WriteLine($"a-b = {a-b}");
    Console.WriteLine($"a*b = {a*b}");
    Console.WriteLine($"a/b = {a/b}");
    }
static void cau_02()
{
int x, y ;

for (y=-5;(y>=-5)&& (y<=5);y++)

{
x= y*y + 2*y + 1;
Console.WriteLine ($"y = {y}| x = {x}");

}

}
static void cau_03()
{
    float distance, hour,minute, second,kmph,milesph,h;
    distance = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("distance:"+ distance);
    hour = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("hour:"+ hour);
    minute = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("minute:"+ minute);
    second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("second:"+ second);
    h = hour + minute/60 + second/360;
    kmph = distance/h;
    milesph= kmph/1.60934f;
    Console.WriteLine("kilometers per hour:" + kmph);
    Console.WriteLine($"miles per hour: {milesph}" );   


}
static void cau_04()
{
    float radius, surface, volume, pi;
    pi=3.14f;
    radius = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("radius:" + radius);
    surface = 4*pi*(radius*radius);
    volume = (float)4/3 *pi*radius*radius*radius;
    Console.WriteLine (" The surface of the sphere:" + surface);
    Console.WriteLine (" The volume of the sphere:"+ volume);
}

}
