using X;

var m = new MyClass();

#region partial class

namespace X;

partial class MyClass
{
    partial class MyClass2 { }

    public void A() { }
}

partial class MyClass
{
    partial class MyClass2 { }

    public void B() { }
}

partial class MyClass
{
    public void C() { }
}
#endregion
#region partial record
partial record X { }

partial record X { }
#endregion
#region partial abstract class
abstract partial class MyClass { }

abstract partial class MyClass { }
#endregion
#region partial struct
partial struct c
{ 

}
partial struct c
{ 

}
partial struct c
{ 

}
#endregion
#region partial interface
partial interface IInterface
{

}
partial interface IInterface
{
    
}
#endregion

#region partial yapılanmaları tercih ettiğimiz senaryolar
#region kod bölümleme
    
#endregion
#region iş bölümü
    
#endregion
#region code generator
    
#endregion
#endregion

#region partial metotlar
new MyClass4();
partial class MyClass4
{
    public MyClass4()
    {
        X();
        Y();
        Z();
    }

    partial void X();
    partial void Y();
    partial void Z();

    partial void Y()
    {
        Console.WriteLine("Y tetiklendi...");
    }
}
#endregion
