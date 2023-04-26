using Internal;
using System;
namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        #region 1. Örnek
        X();
        GC.Collect();//Garbage Collector devreye sokulmuş oldu
        Console.ReadLine();
        #endregion
        #region 2. Örnek
        int sayi = 100;
        while(sayi >= 1)
        {
            new MyClass2(sayi--);
        }
        System.Console.WriteLine("********************************");
        GC.Collect();

        Console.ReadLine();
        #endregion
    }
    static void X()
    {
        MyClass m = new MyClass();
    }

}
class MyClass
{
    public MyClass()
    {
        System.Console.WriteLine("Nesne Üretilmiştir");
    }

    ~MyClass()
    {
        System.Console.WriteLine("Nesne imha ediliyor...");
        System.Console.WriteLine("Nesne son duasını ediyor...");
        System.Console.WriteLine("Nesne son nefesini veriyor");
    }
}
class MyClass2
{
    int no;
    public MyClass2(int no)
    {
        this.no = no;
        System.Console.WriteLine($"{no}. nesne oluşturulmuştur");
    }
    ~MyClass2()
    {
        System.Console.WriteLine($"{no}. Nesne imha ediliyor...");
    }
}
