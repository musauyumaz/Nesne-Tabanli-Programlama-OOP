namespace polimorfizm;
class Program
{
    static void Main(string[] args)
    {
        #region Statik Polimorfizm
        Matematik m = new Matematik();
        m.Topla(40, 50);
        #endregion
        #region Dinamik Polimorfizm
        Arac a = new Arac();
        a.Calistir();

        Taksi t = new Taksi();
        t.Calistir();

        Taksi t2 = new Taksi();
        t.Calistir();
        #endregion
        #region Cast
        // A a2 = new C();

        // C c = (C)a2;

        // D d = (D)a2;

        // object o = 123;
        // int i = (int)o;
        #endregion
        #region As
        A a2 = new C();
        // D d = (D)a2;//Hata
        D d = a2 as D;//Null
        #endregion
        #region is
        A a3 = new C();
        if (a3 is D)
        {
            D d2 = a3 as D;
        }
        else if (a3 is C)
        {
            C c = a3 as C;
        }
        #endregion
    }
}
#region Statik Polimorfizm
class Matematik
{
    public long Topla(int s1, int s2)
        => s1 + s2;

    public long Topla(int s1, int s2, int s3)
        => s1 + s2 + s3;

    public long Topla(int s1, int s2, int s3, int s4)
        => s1 + s2 + s3 + s4;

}
#endregion

#region Dinamik Polimorfizm
public class Arac
{
    public virtual void Calistir()
        => System.Console.WriteLine("Araç Çalıştı...");
}
public class Taksi : Arac
{
    public override void Calistir()
        => System.Console.WriteLine("Taksi Çalıştı...");
}
#endregion

#region Cast
// public class A { }
// public class B : A { }
// public class C : B { }
// public class D : C { }
#endregion
#region As
public class A { }
public class B : A { }
public class C : B { }
public class D : C { }
#endregion
