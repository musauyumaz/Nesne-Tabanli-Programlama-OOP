namespace virtual_override_example;
class Program
{
    static void Main(string[] args)
    {
        #region Örnek - Ek
        Terlik t = new Terlik();
        t.Bilgi();

        Kalem k = new Kalem();
        k.Bilgi();
        #endregion
        #region Örnek 1
        Maymun m = new Maymun();
        m.Konus();

        Inek i = new Inek();
        i.Konus();
        #endregion
        #region Örnek 2
        Ucgen u = new Ucgen(3, 4);
        System.Console.WriteLine(u.AlanHesapla());

        Dortgen d = new Dortgen(3, 4);
        System.Console.WriteLine(d.AlanHesapla());
        #endregion
    }
}
#region Örnek - Ek
public class Obje
{
    public virtual void Bilgi()
    {
        System.Console.WriteLine("Ben bir objeyim...");
    }
}
public class Terlik : Obje
{
    public override void Bilgi()
    {
        System.Console.WriteLine("Ben bir terliğim...");
    }
}
public class Kalem : Obje
{
    public override void Bilgi()
    {
        System.Console.WriteLine("Ben bir kalemim...");
    }
}
#endregion
#region Örnek 1
public class Memeli
{
    public virtual void Konus()
    {
        System.Console.WriteLine("Ben konuşmuyorum...");
    }
}
public class Maymun : Memeli
{
    public override void Konus()
    {
        System.Console.WriteLine("Ben maymunum...");
    }
}
public class Inek : Memeli
{
    public override void Konus()
    {
        System.Console.WriteLine("Ben ineğim...");
    }
}
#endregion
#region Örnek 2
public class Sekil
{
    protected int _boy;
    protected int _en;
    public Sekil(int boy, int en)
    {
        _boy = boy;
        _en = en;
    }
    public virtual int AlanHesapla()
    {
        return 0;
    }
}
public class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)
    {

    }
     public override int AlanHesapla()
    {
        return _boy * _en / 2;
    }
}
public class Dortgen : Sekil
{
    public Dortgen(int boy, int en) : base(boy, en)
    {

    }

    public override int AlanHesapla()
    {
        return _boy * _en;
    }
}
public class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base(boy, en)
    {

    }
     public override int AlanHesapla()
    {
        return _boy * _en;
    }
}

#endregion

