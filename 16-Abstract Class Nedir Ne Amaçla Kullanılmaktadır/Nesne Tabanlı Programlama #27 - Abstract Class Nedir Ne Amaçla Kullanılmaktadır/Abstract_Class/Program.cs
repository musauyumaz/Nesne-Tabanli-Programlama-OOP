Z z = new();

abstract class X
{
    public void A() { }

    public void B() { }

    public void C() { }

    public abstract void D();
    abstract public void Z();
}

abstract class Y : X
{
    public void E() { }
    abstract public void F();
}

class Z : Y
{
    public override void D()
    {
        throw new NotImplementedException();
    }

    public override void F()
    {
        throw new NotImplementedException();
    }

    public override void Z()
    {
        throw new NotImplementedException();
    }
}

//A a = new _A();

abstract class A
{
    public A()
    {
        System.Console.WriteLine("A Abstract Class");
    }
}

class _A : A
{
    public _A()
    {
        System.Console.WriteLine("_A class");
    }
}

abstract class MyAbstractClass
{
    int a;

    public void X() { }

    public int MyProperty { get; set; }

    abstract public void Z();
    abstract public void W(string a, int b);
    public abstract int Y { get; set; }
    abstract public bool H();
}

//Abstract Class içerisindeki `abstract` yapıların concrete `class` içerisinde tanımları `public` olmak zorundadır.
class MyClass : MyAbstractClass
{
    public override int Y { get; set; }

    public override bool H()
    {
        throw new NotImplementedException();
    }

    public override void W(string a, int b)
    {
        throw new NotImplementedException();
    }

    public override void Z()
    {
        throw new NotImplementedException();
    }
}
