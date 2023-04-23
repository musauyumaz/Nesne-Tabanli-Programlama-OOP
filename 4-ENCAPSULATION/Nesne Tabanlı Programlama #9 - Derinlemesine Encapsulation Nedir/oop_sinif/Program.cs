namespace oop_sinif;

class Program
{
    static void Main(string[] args)
    {
        MyClass m = new MyClass();
        m.ASet(15);
        System.Console.WriteLine(m.AGet());

        m.A = 123123;
        System.Console.WriteLine(m.A);
    }
}

class MyClass
{
    int a;

    #region Eskiden Encapsulation Nasıl Yapılıyordu?
    public int AGet()
    {
        return this.a; //AGet fonksiyonu tetiklendiğinde/çağırıldığında sen `this`deki yani o anki nesnedeki a field'ının değerini geri gönder.
    }

    public void ASet(int value)
    {
        this.a = value;
    }
    #endregion
    
    public int A
    {
        get { return a; }
        set { a = value; }
    }
    
}
