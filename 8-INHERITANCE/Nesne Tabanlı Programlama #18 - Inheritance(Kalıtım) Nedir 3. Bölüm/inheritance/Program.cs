using System;
namespace inheritance;
class Program
{
    static void Main(string[] args)
    {
        MyClass m = new MyClass();

    }
}
public class MyClass
{

}
public class A
{
    public void X()
    {

    }
}
public class B : A
{

}
public class C : B
{

}
public class D : C
{
    public new int X()
    {
        return 0;
    }
}