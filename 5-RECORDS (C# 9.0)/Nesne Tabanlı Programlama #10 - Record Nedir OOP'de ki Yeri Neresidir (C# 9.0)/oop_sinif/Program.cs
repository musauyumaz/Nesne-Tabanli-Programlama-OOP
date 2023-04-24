namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        // MyClass my = new MyClass
        // {
        //     MyProperty = 3,
        //     A = 5
        // };

        #region Equals
        // MyClass m1 = new MyClass()
        // {
        //     MyProperty = 5
        // };
        // MyClass m2 = new MyClass()
        // {
        //     MyProperty = 5
        // };

        // System.Console.WriteLine(m1.Equals(m2));

        // MyRecord m3 = new MyRecord()
        // {
        //     MyProperty = 5
        // };
        // MyRecord m4 = new MyRecord()
        // {
        //     MyProperty = 5
        // };

        // System.Console.WriteLine(m3.Equals(m4));
        #endregion
        #region With Expression
        #region Class
        // MyClass m = new MyClass
        // {
        //     MyProperty1 = 5,
        //     MyProperty2 = 10
        // };

        // // m.MyProperty2 = 15;

        // MyClass m2 = new MyClass
        // {
        //     MyProperty1 = m.MyProperty1,
        //     MyProperty2 = 15
        // };
        // MyClass m3 = m.With(15);
        #endregion
        #region Record
        MyRecord m = new MyRecord
        {
            MyProperty1 = 5,
            MyProperty2 = 10
        };

        MyRecord m2 = m with {MyProperty2 = 15};
        #endregion
        #endregion
    }
}
// record MyRecord
// {
//     public int MyProperty { get; init; }
//     public void X()
//     {

//     }
//     public MyRecord()
//     {

//     }
//     ~MyRecord()
//     {

//     }
//     static MyRecord()
//     {

//     }
// }

public record MyRecord
{
    public int MyProperty1 { get; init; }
    public int MyProperty2 { get; init; }
}
public class MyClass
{
    public int MyProperty1 { get; init; }
    public int MyProperty2 { get; init; }
    public MyClass With(int property2){
        return new MyClass
        {
            MyProperty1 = this.MyProperty1,
            MyProperty2 = property2
        };
    }

}

// class MyClass
// {
//     readonly int a;
//     public int A
//     {
//         get
//         {
//             return a;
//         }
//         init 
//         {
//             a = value;
//         }
//     }
//     public int MyProperty { get; init; } = 3;
// }
