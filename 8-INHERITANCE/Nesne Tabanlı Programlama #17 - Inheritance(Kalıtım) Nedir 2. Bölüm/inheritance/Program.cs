namespace inheritance;
class Program
{
    static void Main(string[] args)
    {
        new D();
        new MyClass2();
    }
}
// public class BuyukBaba
// {

// }
// public class Baba : BuyukBaba
// {

// }
// public class Anne : Baba
// {

// }
// public class Ogul : Anne
// {

// }
// public class A
// {
//     public A()
//     {
//         System.Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur.");
//     }
// }
// public class B : A
// {
//     public B()
//     {
//         System.Console.WriteLine($"{nameof(B)} nesnesi oluşturulmuştur.");
//     }
// }
// public class C : B
// {
//     public C()
//     {
//         System.Console.WriteLine($"{nameof(C)} nesnesi oluşturulmuştur.");
//     }
// }
// public class D : C
// {
//     public D()
//     {
//         System.Console.WriteLine($"{nameof(D)} nesnesi oluşturulmuştur.");
//     }
// }

public class MyClass
{
    public MyClass(int a)
    {

    }
    public MyClass(string a)
    {

    }
    public MyClass(int a, string b)
    {

    }
    public MyClass()
    {

    }
}
public class MyClass2 : MyClass
{
    public MyClass2() : base(5, "afsafsafafasd")
    {

    }
    public MyClass2(int a) : base(a)
    {

    }
}

public class A
{
    int a;
    public int b;
    public int MyProperty { get; set; }
}
public class B : A
{
    int c;
    public void X()
    {
        MyProperty = 123;
    }
}