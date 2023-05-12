namespace polimorfizm;
class Program
{
    static void Main(string[] args)
    {
        MyClass2 m = new MyClass();

        // A a = new B();
        // B b = new B();
        // C c = new B();

        Erkek e = new Erkek();
        Insan i = new Erkek();

        Kadın k = new Kadın();
        Insan i2 = new Kadın();


        C c = new C();
        B b = new C();
        A a = new C();
        
        


    }
}
#region Örnek 1
public class MyClass : MyClass2
{

}
public class MyClass2
{

}
#endregion

#region Örnek 2
// class A : C
// {

// }


// class B : A
// {

// }
// class C
// {

// }
#endregion

#region Örnek 3
class Insan
{

}
class Erkek : Insan
{

}
class Kadın : Insan
{

}
#endregion

#region Örnek 4
class A
{
    public void X() { }
}


class B : A
{
    public void Y() { }
}
class C : B
{
    public void Z() { }
}
#endregion

