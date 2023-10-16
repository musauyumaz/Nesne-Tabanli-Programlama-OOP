#region Interface Tanımlama ve İnşa Etme Kurallarını Toparlayalım

//IMyInterface asdasdasad = null;//MyInterface türünden bir referans noktası alabiliyorum. Referans türlü değişken olduğu için buna direkt null atayabiliyorum
////Oluşturmuş olduğumuz interface'ler direkt bize bir referans türlü değişken sağlıyorsa haliyle biz ileride bu referans türlü değişkenle nesnelerimizi refere edebiliriz. 


//interface IMyInterface { }//Interface yapılanması içerisinde imzaları barındıracağından dolayı haliyle scope'lardan oluşmaktadır. 


//interface IMyInterfaceNamespaceDisinda //Namespace dışında da ben interface'i tanımlayabilirim.
//{

//}

//namespace MyNamespace //MyNamespace içinde ben interface'i tanımlayabilirim.
//{
//    interface IMyInterfaceeNamespaceIcinde
//    {

//    }

//    class MyClass //MyClass içinde ben interface'i tanımlayabilirim.
//    {
//        interface IMyInterfaceClassIcinde //IMyInterfaceClassIcinde içinde ben interface'i tanımlayabilirim.
//        {
//            interface IMyInterfaceeInterfaceIcinde
//            {

//            }
//        }
//    }
//}
#endregion
#region Interface İçerisine İmzaların Oluşturulması
//interface IMyInterface // interface'lerde direkt implementasyon direkt kendi içlerindeki imzaları kullanılan class'lara uygulattırmak vardır. Dolayısıyla burada zaten zorakilik olacağından dolayı public gibi bir durumun olmasına gerek yoktur. private olsa ne olacak. Sen hem imzayı tanımlayacan hemde private diyip bu imzaya karşılık bir member oluşturmamı diyeceksin? E haliyle erişim belirleyicisi interface'lerde kullanılmaz.
//{
//    void X();// Interface'te kalıtımsal herhangi bir davranış olmayacağından dolayı abstract gibi bişeyle işaretleme durumu da söz konusu değildir. Yani interface salt olarak direkt içerisindeki imzları kendisini kullanan class'lara zoraki uygulattıracak bir yapıya fıtrata sahiptir. Abstract class'lar belki değildir. 
//    void Y(int a);
//    int Z { get; set; }
//}
//abstract class MyAbstractClass //Abstract class'larda temel gaye direkt implementasyon değildir. Bazen kalıtımsal davranışta sergileyebilir. 
//{
//    public abstract void X();//Bizler abstract class içerisinde bu abstract class'ı kullanan implemente eden class'lara zoraki olarak belirli imzaları uygulatmak istiyorsak abstract işaretli ve bir yandan da public ile işaretli member'ları/imzaları tanımlamak gerekir. 
//    //Bu imza neticesinde bu abstract class'ı implemente eden class'larda bu imzaya karşılık olan member zoraki oluştutturulacaktı.
//    public abstract void Y(int a);//Abstract class'larda public olmak zorundadır. Private dediğinizde zaten bir anlam ifade etmeyeceğinden dolayı hata verir. Ama buranın kuralı gereği public'in kullanılması zaten zorunludur. interface'de ona hiç gerek yoktur. Ayriyetten abstract class'larda tanımlanmış olan imzaların abstract ile işaretlenmesi gerekmektedir. Bunun implemente edilecek bir imza olduğu compiler tarafından anlaşılsın.
//    public abstract int Z { get; set; }

//    public bool D() //Abstract class'ta böyle bir fonksiyon olabilir ve bu fonksiyonu kalıtımsal olarak kendisini kullanan/kalıtım alan sınıfa aktarabilir. Bunun dışında ekstradan public abstract ile işaretli olan imzaları da bir yandan oraya da implemente ettirebilir.
//    {
//        return true;
//    }
//}
//// İki türlü bir davranış söz konusu abstract class'ta. Ama interface'te ikinci bir davranış yok. interface'te imzalar var. ve bu imzaların karşılıkları direkt kensini uygulayan sınıfa zoraki uygulattırılması var.
#endregion
#region Interface Kullanımı

////class MyClass : MyAbstractClass
////{
////    public override int Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

////    public override void X()//Abstract class'tan implementasyon yaptığımızda override keywordü eşliğinde implementasyon sağlanır.
////    {
////        throw new NotImplementedException();
////    }

////    public override void Y(int a)
////    {
////        throw new NotImplementedException();
////    }
////}

//class MyClass : IMyInterface
//{
//    public int Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public void X()//interface'in içerisindeki imzalara karşılık member'lar direkt sade bir şekilde oluşturulur. Yani herhangi bir override falan yok.
//    {
//        throw new NotImplementedException();
//    }

//    public void Y(int a)
//    {
//        throw new NotImplementedException();
//    }
//}

//interface IMyInterface
//{
//    void X();
//    void Y(int a);
//    int Z { get; set; }
//}

//abstract class MyAbstractClass
//{
//    public abstract void X();
//    public abstract void Y(int a);
//    public abstract int Z { get; set; }

//    public bool D()
//    {
//        return true;
//    }
//}
#endregion
#region Interface Implementation Yöntemleri
//class MyClass : IMyInterface
//{
//    public void X() {  } 
//    public void Y(int a) { }
//    public int Z { get; set; }
//}
//interface IMyInterface
//{
//    void X();
//    void Y(int a);
//    int Z { get; set; }
//}
#endregion
#region Interface'ler de Çoklu Kalıtım Durumu

//MyClass myClass = new MyClass();
//IA ia = new MyClass();
//IB ib = new MyClass();
//IC ic = new MyClass();

//class MyClass : IA, IB, IC //Ne kadar interface varsa tüm interface'lerin implement edilmesi gerekiyor. Çünkü olaya bakarsanız eğer bu class bir tane sözleşmeyle taahhüd anlaşmasına girmiyor birden fazlasıyla giriyor. Dolayısyla her birinin implementasyonu gerçekleştirilmeli yani her bir sözleşmenin gereği yerine getirilmeli. Hem IC'yi hem IB'yi hem de IA'yı uygulamalısın. Bunların içinde birini uygulamazsan/implemente etmezsen o zaman bir anlam ifade etmeyecek compiler derlemeyecektir.
//    //Bu tarz bir tanımlama ancak interfacelerde mümkündür. Eğer ki bunların en az iki tanesi class olsaydı compiler açısından bu tanımlama mümkün olmayacaktı.
//{
//    public void A()
//    {
//        throw new NotImplementedException();
//    }

//    public void B()
//    {
//        throw new NotImplementedException();
//    }

//    public void C()
//    {
//        throw new NotImplementedException();
//    }
//}
//interface IA
//{
//    void A();
//}
//interface IB
//{
//    void B();
//}
//interface IC
//{
//    void C();
//}

#endregion
#region Interface'in Interface'den Türemesi
//class MyClass : IC
//{
//    public void A()
//    {
//        throw new NotImplementedException();
//    }

//    public void B()
//    {
//        throw new NotImplementedException();
//    }

//    public void C()
//    {
//        throw new NotImplementedException();
//    }

//    public void D()
//    {
//        throw new NotImplementedException();
//    }

//    public void W()
//    {
//        throw new NotImplementedException();
//    }
//}
//interface IA
//{
//    void A();
//}
//interface IB : IA
//{
//    void B();
//}
//interface IC : IB, ID, IW
//{
//    void C();
//}
//interface ID
//{
//    void D();
//}
//interface IW
//{
//    void W();
//}
#endregion
#region Bir Class'a Inheritance İle Birlikte Implementation Nasıl Uygulanır
class MyClass : ExampleClass, IA, IB, IC
{
    public void A()
    {
        throw new NotImplementedException();
    }

    public void B()
    {
        throw new NotImplementedException();
    }

    public void C()
    {
        throw new NotImplementedException();
    }

    public void D()
    {
        throw new NotImplementedException();
    }

    public void W()
    {
        throw new NotImplementedException();
    }
}

class ExampleClass
{
    
}
interface IA
{
    void A();
}
interface IB : IA
{
    void B();
}
interface IC : IB, ID, IW
{
    void C();
}
interface ID
{
    void D();
}
interface IW
{
    void W();
}

#endregion