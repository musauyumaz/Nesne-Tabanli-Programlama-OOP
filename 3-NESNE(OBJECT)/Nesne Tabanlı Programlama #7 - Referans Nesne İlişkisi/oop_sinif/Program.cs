namespace oop_sinif;

class Program
{
    static void Main(string[] args)
    {
        MyClass m = new MyClass();
        m.MyProperty = 10;

        MyClass m2 = null;
        m2.MyProperty = 20;

        new MyClass().MyProperty = 10;

        MyClass m3 = new MyClass() 
        { 
            a = 5,
            MyProperty = 10,
            MyProperty2 = 20,
            MyProperty3 = 30 
        };
    }
}

class MyClass
{
    public int a;
    public int MyProperty { get; set; }
    public int MyProperty2 { get; set; }
    public int MyProperty3{ get; set; }
}
