namespace oop_sinif;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = a;

        #region Shallow Copy
        #region Örnek 1
        // MyClass m1 = new MyClass();
        // MyClass m2 = m1;
        // MyClass m3 = m2;
        // MyClass m4 = new MyClass();
        #endregion
        #region Örnek 2
        // MyClass m1 = null;
        // MyClass m2 = new MyClass();
        // MyClass m3 = m2;
        // m1 = m3;
        #endregion
        #region Örnek 3
        // MyClass m1 = new MyClass();
        // MyClass m2 = new MyClass();
        // MyClass m3 = m1;
        // m1 = m2;
        // m2 = m1;
        // m1 = m1;
        #endregion
        #endregion
        #region Deep Copy
        MyClass m1 = new MyClass();
        MyClass m2 = m1;//Shallow copy
        MyClass m3 = m1.Clone(); //Deep Copy
        #endregion
    }
}

class MyClass
{
    public MyClass Clone()
    {
        return (MyClass)this.MemberwiseClone();
    }
}
