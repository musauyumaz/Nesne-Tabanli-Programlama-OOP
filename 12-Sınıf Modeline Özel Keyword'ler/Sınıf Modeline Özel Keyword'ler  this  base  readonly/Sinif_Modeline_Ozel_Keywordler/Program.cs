#region this Keyword'ü
//Bir sınıfın, uygulamanın herhangi bir noktasında üretilmiş olan instancle'larını/object'lerini/nesnelerini sınıf içerisinde temsil etmemizi sağlayan bir keyword'dür.

//this keyword'ü, bir sınıf içerisinde bulunan birden fazla constructor overload'ı arasında zıplamamızı yahut atlamamızı sağlayan bir keyworddür.
#endregion

#region base Keyword'ü
//base keyword'ü bir instance'ın base `class`ını sınıf modeli içerisinde temsil eden bir keyworddür.

//`base` keyword'ü base `class`daki constructor'lardan seçim yapmamızı sağlar.
#endregion

#region readonly Keyword'ü
//Bir `class` içerisinde tanımlanmış olan değişkenin yahut referansın sadece okunabilir olmasını sağlayan bir keyword'dür.

//`readonly` keyword'ü ile işaretlenmiş olan referansların değerleri ya tanımlama noktasında ya da constructor'da verilebilir.

//const yapılanmalar, readonly ile karıştırılabilir. Aralarındaki fark şöyledir;
//const tanımlandığı yerde değeri verilmelidir. Ve constructor içerisinde bile değer ataması gerçekleştirilemez! Lakin readonly'de ister tanımlama noktasında isterseniz de constructor içerisinde değer ataması gerçekleştirilebilir. İkisi arasındaki temel farklardan birisi de budur.
#endregion

new MyClass(3, "");
// new MyClass();
// new MyClass();

new MyClass2();

class MyClass
{
    public int MyProperty { get; set; }
    public MyClass()
    {
        System.Console.WriteLine("Boş constructor");
    }
    public MyClass(int a) : this()
    {
        System.Console.WriteLine("a parametreli constructor");
    }
    public MyClass(int a, string b) : this(a)
    {
        System.Console.WriteLine("a ve b parametreli constructor");
    }
}

class MyClass2 : MyClass
{
    public MyClass2() : base(3, "")
    {
        System.Console.WriteLine("Son constructor");
    }
}

class MyClass3
{
    readonly object x = 5;
    const string y = "";
    public MyClass3()
    {
        x = 15;
        y = "";
    }

    public void X()
    {
        x = 155;
    }
}