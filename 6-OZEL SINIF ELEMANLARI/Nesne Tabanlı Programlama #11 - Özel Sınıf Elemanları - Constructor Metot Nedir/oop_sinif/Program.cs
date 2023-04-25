namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        // new MyClass(5);
        // new MyClass(10);
        // new MyClass();
        // new MyClass();
        // MyClass m = new(15);

        new MyClass();
        new MyClass(5);


    }
}
// class MyClass
// {
//     MyClass()
//     {

//     }

//     void X()
//     {
//         new MyClass();
//     }
// }

// class MyClass
// {
//     public MyClass()
//     {

//     }
//     public MyClass(int a)
//     {
//         System.Console.WriteLine("Bir adet myclass nesnesi oluşturulmuştur. " + a);
//     }

//     public MyClass(string a)
//     {

//     }
//     public MyClass(string a, int b)
//     {

//     }
//     public void X(){}
// }

class MyClass
{
    public int x;
    public MyClass()
    {
        System.Console.WriteLine("1. Constructor");
    }
    public MyClass(int a) : this()
    {
        System.Console.WriteLine($"2. Constructor : a = {a}");
    }
    public MyClass(int a, int b) : this(a)
    {
        System.Console.WriteLine($"2. Constructor : a = {a} |b = {b}");
    }
}

record MyRecord
{
    public MyRecord()
    {
        
    }
    public MyRecord(int a) : this()
    {
        
    }
}