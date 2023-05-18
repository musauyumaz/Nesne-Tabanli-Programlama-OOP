C c = new();


class A
{
    public virtual void X()
    {
        System.Console.WriteLine("Merbaha A");
    }
}

class B : A
{
    sealed public override void X()
    {
        System.Console.WriteLine("Merbaha B");
    }
}
class C : B
{
    
}