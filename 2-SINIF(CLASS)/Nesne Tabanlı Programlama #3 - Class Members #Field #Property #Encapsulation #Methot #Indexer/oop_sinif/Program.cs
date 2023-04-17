namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        #region Class Members
        #region Field
        //Nesne içerisinde değer tutmamızı sağlayan alanlardır. 

        // MyClass m1 = new MyClass();//Nesne Oluşturduk!!!
        // // m1.a = 5;
        // System.Console.WriteLine(m1.a);

        // int a;
        // System.Console.WriteLine(a);

        // MyClass m2 = new MyClass();//Nesne Oluşturduk!!!
        // m2.a = 25;
        #endregion
        #region Property
        MyClass myClass = new();
        System.Console.WriteLine(myClass.Yasi);
        myClass.Yasi = 65;

        System.Console.WriteLine(myClass.Yasi);

        myClass.Yasi2 = 12;
        System.Console.WriteLine(myClass.Yasi2);
        #endregion
        #region Metot
        MyClass myClass1 = new();
        myClass1.X();
        #endregion
        #region Indexer
        MyClass myClass2 = new();
        myClass2[3] = 10;
        #endregion
        #endregion
    }
}
class MyClass
{
    int yasi;
    string b;

    #region Full Property
    //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır...
    //Property'ler temsil ettikleri field'ların isimlerinin başharfi büyük olacak şekilde isimlendirilir...
    public int Yasi
    {
        get
        {
            //Property üzerinden değer talep edildiğinde bu blok tetiklenir.
            //Yani değer buradan gönderilir.
            return yasi - 10;
        }
        set
        {
            yasi = value;
        }
    }
    #endregion
    #region Prop Property
    // public int Yasi
    // {
    //     get
    //     {
    //         return yasi;
    //     }
    //     set
    //     {
    //         yasi = value;
    //     }
    // }
    public int Yasi2 { get; set; }//Prop Property
    public int Yasi3 { get => yasi; set => yasi = value; } //Full Property
    public int Yasi4 { get; set; } = 15;//Çünkü Yasi4 property'si prop olduğundan dolayı arkada compiler tarafından bunun field'ı oluşturulacak haliyle oluşturulan field'ın değeri türüne göre default değer olacaktır. İşte sen oradaki default değere bu şekilde müdahale edebiliyorsun.
    #endregion
    #region Ref Readonly Returns
    string adi = "Musa UYUMAZ";
    public ref readonly string Adi => ref adi;
    #endregion
    #region Computed Property
    int s1 = 5;
    int s2 = 10;

    public int Topla
    {
        get
        {
            return s1 + s2;
        }
    }
    #endregion
    #region Metot
    public int X()
    {
        return 0;
    }
    #endregion
    #region Indexer 
    public int this[int a]
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    #endregion
}

class Banka
{
    int bakiye;
    public int Bakiye
    {
        get
        {
            if (bakiye > 0)
                return bakiye * 10 / 100;
            return 5;
        }
        set
        {
            if (value < 10)
                bakiye = value;
            else
                bakiye = value * 5 / 100;
        }
    }
}
