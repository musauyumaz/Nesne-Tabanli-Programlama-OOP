namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        #region this Keywordü

        #region 1. Sınıfın Nesnesini Temsil Eder
        MyClass m1 = new();
        MyClass m2 = new();

        m1.X();
        #endregion
        #region 2. Aynı İsimde Field İle Metot Parametrelerini Ayırmak için Kullanılır
        //`this` keywordü ilgili `class` yapılanmasının o anki nesnesine karşılık gelir.
        //`this` kullanmak zorunda değiliz.
        //
        #endregion
        #region 3. Bir Constructer'dan Başka Bir Constructer'ı Çağırmak İçin Kullanılır

        #endregion
        #endregion
    }
}
class MyClass
{
    int a;
    public void X(int a)
    {
        this.a;
    }
}
