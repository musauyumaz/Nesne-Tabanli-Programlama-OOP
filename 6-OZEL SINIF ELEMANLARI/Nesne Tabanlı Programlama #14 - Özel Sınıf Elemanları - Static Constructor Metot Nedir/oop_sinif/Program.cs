namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        new MyClass();
        new MyClass();

        Database database1 = Database.GetInstance;
        Database database2 = Database.GetInstance;
        Database database3 = Database.GetInstance;

        database1.ConnectionString = "sfafasfasfsafasfaswf";

        System.Console.WriteLine(database1);
        System.Console.WriteLine(database2);
        System.Console.WriteLine(database3);
    }
}
class MyClass
{
    public MyClass()
    {
        //Bu sınıftan nesne üretilirken ilk tetiklenecek olan metottur.
        System.Console.WriteLine("MyClass constructor'ı tetiklenmiştir.");
    }
    static MyClass()
    {
        //Bu sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur.
        //Üretilen ilk nesnenin dışında bir daha tetiklenmez!
        System.Console.WriteLine("MyClass static constructor'ı tetiklenmiştir.");
        //Static constructor'ın tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static yapılanmanında tetiklenmesi static constructor'ın tetiklenmesini sağlayacaktır.
    }

}

#region Singleton Design Pattern
//Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design pattern.
class Database
{
    Database()
    {

    }
    public string ConnectionString { get; set; }

    static Database database;
    public static Database GetInstance
    {
        get
        {
            return database;
        }
    }

    static Database()
    {
        database = new Database();
    }
}
#endregion
