using System;

namespace oop_sinif;

class Program
{
    static void Main(string[] args)
    {
        #region Class İçerisinde Tanımlanan Class Sınıf Elemanı mıdır?
        MyClass m1 = new();

        MyClass.MyClass2 m2 = new MyClass.MyClass2();
        #endregion
        #region Class Elemanlarına Açıklama Satırı Nasıl Eklenir?
        Random random = new();

        MyClass myClass = new MyClass();
        myClass.X();
        #endregion
    }
}

/// <summary>
/// Bu bir örnek classtır
/// </summary>
class MyClass
{
    int a;

    /// <summary>
    /// Bu bir property'dir.
    /// </summary>
    public int MyProperty { get; set; }

    /// <summary>
    /// Bu bir örnek metottur.
    /// </summary>
    public void X() { }

    /// <summary>
    /// Bu bir örnek metot overload'ıdır.
    /// </summary>
    /// <param name="a">a parametresi</param>
    public void X(int a) { }

    public int this[int a]
    {
        get { return 0; }
    }

    class MyClass2 { }
}
