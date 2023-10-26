#region Explicity Implements & Name Hiding
//class MatematikIslemleri : IMatematikIslemleri //Biz bir interface'i sınıfa uygularken implement interface sekmesi üzerinden uygulama işlemini gerçekleştiriyorduk.
//{
//    public int Bol(int s1, int s2)
//    {
//        throw new NotImplementedException();
//    }

//    public int Carp(int s1, int s2)
//    {
//        throw new NotImplementedException();
//    }

//    public int Cikar(int s1, int s2)
//    {
//        throw new NotImplementedException();
//    }

//    public int Topla(int s1, int s2)
//    {
//        throw new NotImplementedException();
//    }

//    public void X() 
//    {

//    }
//    public int Z { get; set; }
//}

//interface IMatematikIslemleri //interface der ki sen söz verdiğin şeyleri gerçekleştir fazlasında zaten sıkıntı yok. Fazla mal göz çıkartmaz diyor. Ama en az bunları gerçekleştireceksin uygulanan sınıfta. ve bunu gerçekleştirirkende sana verdiğim imzalara uygun bir şekilde gerçekleştireceksin.
//    //Gerçekleştireceksinden kasıt bu imzalara karşılık gövdeleri oluşturacaksın yani bu imzalara karşılık member'ları bu sınıfa ekleyeceksin.
//{
//    int Topla(int s1, int s2);
//    int Cikar(int s1, int s2);
//    int Bol(int s1, int s2);
//    int Carp(int s1, int s2);
//}
//class MyClass : IA, IB //MyClass IA ve IB'yi bu şekilde implement ettiğinde her ikisinde de birebir aynı imza olacağından dolayı bu implementasyon neticesinde bir name hiding durumu söz konusu olacaktır.
//{
//    public int X()// Bu X() fonksiyonu IA'dan mı geldi IB'den mi geldi. Bilemediğinizden dolayı burada bir name hiding söz konusudur. İşte biz bu duruma karşılık yani name hiding durumunu fark ettiğimiz bu tarz bir davranışa karşılık bu X() fonksiyonunun hangisinden geldiğini ayırt etmek istiyorsak burada Explicity Implement davranışını sergilememiz gerekecektir. 
//    {
//        throw new NotImplementedException();
//    }
//}
//class MyClass : IA, IB //MyClass IA ve IB'yi bu şekilde implement ettiğinde her ikisinde de birebir aynı imza olacağından dolayı bu implementasyon neticesinde bir name hiding durumu söz konusu olacaktır.
//{
//    public int X()// Bu X() fonksiyonu IA'dan mı geldi IB'den mi geldi. Bilemediğinizden dolayı burada bir name hiding söz konusudur. İşte biz bu duruma karşılık yani name hiding durumunu fark ettiğimiz bu tarz bir davranışa karşılık bu X() fonksiyonunun hangisinden geldiğini ayırt etmek istiyorsak burada Explicity Implement davranışını sergilememiz gerekecektir. 
//    {
//        throw new NotImplementedException();
//    }
//}


//MyClass m = new();
//IA a = m;//Eğer ben IA üzerinden gelen X() fonksiyonunu tetiklemek istiyorsam bu şekilde IA referansına karşılık nesneyi işaretlemem gerekecek.
//a.X();// Bu referans üzerinden X'i tetiklemem yeterli olacak. Bu referans IA referansından implemente edilen member'ı tetikleyecektir.

//IB b = m;
//b.X(); //Bu referans IB referansından implemente edilen member'ı tetikleyecektir.

//class MyClass : IA, IB
//{
//    int IA.X()//Explicity Implement davranışını sergiliyorsak burada implement edilen member'lar private olmak zorunda. Bu member'lar nereden geliyorsa geldiği yeri belirtmek zorundayız (IA.X() gibi)
//    //Explicity implement davranışı neticesinde member'lara erişim göstermek istiyorsak o zaman member'ına uygun interface'i tercih etmemiz gerekecek.
//    {
//        Console.WriteLine("A - X");
//        return 0;
//    }

//    int IB.X()
//    {
//        Console.WriteLine("B - X");
//        return 1;
//    }
//}
//interface IA 
//{
//    int X();
//}
//interface IB
//{
//    int X();
//}
#endregion
#region Default Implementation
class MyClass : IA
{
    public void X()
    {
        Console.WriteLine("X");
    }
    public void Y()
    {
        Console.WriteLine("Y");
    }
}
interface IA
{
    void X();
    void Y()
    {
        Console.WriteLine("Default Imp Y");
    }
}
//Normal şartlarda imzalarımızdan herhangi biri ya da imzalarımızın hiçbirinde default implementation yoksa ya da bir başka deyişle default implementation'ı olmayan imzalar söz konusuysa bunları zaten seve seve bizim implement etmemiz gerekiyor. Herhangi birini implement etmediğim taktirde compiler zaten bana hata verecektir.
//Y'nin default implementation'ı olmadığı durumda compiler hata veriyordu amma velakin Y default implementation'ı varsa hata ortadan kalkıyor. Yani sen IA'daki Y imzasına karşılık herhangi bir tanımda implementasyonda bulunmuyorsan burada default implementation devreye giriyor. Yok eğer ben bir yandan da default implementation'a rağmen implementasyonda bulunacağım diyorsan bunuda yapabilirsin.
//Eğer bu şekilde Y'yi tanımlıyorsanız default implementation'da tanımlamış olduğunuz gövdeyi ezmiş olursunuz. Yani artık buradaki operasyon geçerli olacaktır.
#endregion