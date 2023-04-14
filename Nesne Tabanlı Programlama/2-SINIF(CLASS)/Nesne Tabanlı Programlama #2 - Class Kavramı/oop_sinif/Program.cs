class MyClass2
{

}
namespace oop_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sınıf Nedir? Neden Sınıf Yapısı Kullanılır?

            #endregion
            #region Sınıf İle Nesne Arasındaki İlişki Nedir?

            #endregion
            #region Sınıf Nasıl ve Nerede Oluşturulur?
            #region Namespace İçerisinde

            #endregion
            #region Namespace Dışarısında

            #endregion
            #region Class İçerisinde

            #endregion

            //Bir `class` tanımlasında tanımlanan yerde(`namespace`/dışı, `class`) aynı isimde birden fazla `class` tanımlanamaz!
            #endregion
            #region Sınıf İle Nesne Modeli Tasarlama
                
            #endregion
            #region Sınıf Modelinden Referans Noktası Oluşturma
            //Bir `class` tanımlandığında o `class` adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak `class` adını kullanmamız yeterlidir.
            OrnekModel w;
            #endregion

        }
    }
    class OrnekModel
    {
        int a;
        int b;

        public void X()
        {
            System.Console.WriteLine(a + " " + b);
        }
        public int Y()
        {
            return a * b;
        }
    }
    class MyClass
    {
        class MyClass3
        {

        }
    }
}

