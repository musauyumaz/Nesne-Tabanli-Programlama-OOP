***
# Nesne Tabanlı Programlama #16 - Inheritance(Kalıtım) Nedir? 1. Bölüm
<img src="1.png">

## Bir Programcı Açısından Kalıtım Nedir?
- Yazılımda bir kavramı öğreneceksen öğrenmen gerektiği için öğreniyorsun. Artistlik olsun diye bir kavram öğrenilmiyor yazılımda.

- Kalıtım dediğimiz kavram küçüklüğümüzden beri bildiğimiz biyolojik bir terim.  

- OOP dediğimiz yaklaşım gerçek hayattan modellenerek yazılıma uygulanmış bir yaklaşımdır.

- Kalıtımı adamlar demişler ki ulan biz OOP diye bir yaklaşım geliştiriyoruz bunu daha iyi nasıl yapabiliriz demişler biyolojide ki kalıtım mantığını alıp buraya uyarlamışlar. 
 
- Yine günlük hayattan bilimden sanattan herhangi bir yerden bir konuyu alıp uyarlamışlar.

## Şahsi Tezim :) - OOP ile istihbarat teşkilatı kurulabilir.
- Kalıtım OOP'nin ennnn önemli özelliğidir.
 
- Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir.

- Bir programcı açısından bu özellik;
  * Aynı aile grubundan gelen nesnelerin ya da yatayda eşit seviyede olan tüm olguların benzer özelliklerini tekrar tekrar herbirinde tanımlamaktansabir üst sınıfta tanımlanmasını ve her bir sınıfın bu özellikleri üst sınıftan kalıtımsal olarak almasını sağlamaktadır.
  
  * Böylece hem kod maliyeti düşmekte, hem de mimarisel tasarım açısından avantaj sağlanmaktadır.

- Nesne tabanlı programlamayı bilen bir kişi güzel bir istihbarat teşkilatı kurulabilir.

- Nesne tabanlı programlama bir tek yazılımı programlama değil günlük hayatı ya da bir teşkilatı programlama üzerine de size mantık kazandıracaktır.

- Kalıtım deniyorsa eğer bir nesne başka bir nesneye genetik bir miras bırakıyor. Bir özellik aktarıyor.

- OOP'de nesnelerimizin bazı özelliklerini başka nesnelere kalıtımsal olarak aktarabiliyoruz. Bu aktarma işlemine biz kalıtım diyoruz. Elinde bir nesne var bu nesnenin belirli özelliklerini memberlarını(field, metot, property) bunlardan belirlediklerini başka bir nesneye aktarmayı sen kalıtım olarak sağlıyorsun. 

- Aynı aile grubundan gelen nesnelerin ortak özellikleri olabilir. İşte bu ortak özelliklerin her birisine kodlama esnasında gidip tek tek aynı işi yapmaktansa ortak olan özellikleri sen bir üst sınıfa tanımla bu üst sınıftan bunlara kalıtımsal olarak al.

- Kalıtım kod maliyetini düşürmektedir.

- Sen aynı olguya dir olan nesnelerinin içindeki tekrar eden birbirleriyle birebir aynı olan alanları/memberları/propertyleri/özellikleri her neyse bunları her bir yer için tekrar tekrar tanımlamaktansa sen gidip bir tane `class`ta tanımlayıp o `class`ta bir üst `class` olacak onların hepsini temsil edebilen üst sınıf olacak. Bu sınıftan bunlara mirasla/kalıtımla aktarıyorsan eğer kod maliyetini düşürmüş oluyorsun. Hem de mimarisel tasarım açısından da avantaj sağlamış oluyorsun.

- İleride design pattern'lardan bahsedeceğiz. Birçok design pattern OOP'deki kalıtım üzerine kurulu.

<img src="2.png">

## Her Sınıfı Kalıtımsal Operasyona Tabi Tutmalı mıyım? Sorunsalı...
- Sen bütün sınıflarını kalıtımsal operasyonlarda kullanmak zorunda değilsin. Kullanabileceklerin varsa da bunları kalıtımda kullanacaksın. Yani elindeki bütün sınıfları bir şeyden kalıt diye bir prensip yok. Kalıtım denilen olay lazımsa kullanılır. Herşeyi de kalıtacağım diye bir derdin olmasın.

- Dolayısıyla kullanacağın yer var kullanmayacağın yer var.

## Kara Tahtada Anlatım
- Bizim işimiz bir yerden sonra varolan birşeyi tekrar tekrar yazmak değil biz durmadan stratejik bir yapılanmaya kayacağız. Yani senin yazacağın kodlar lazım olduğu noktada kullanılabilir olmalı. Eğer kullanamıyorsan tekrardan lazım olduğu noktada tekrardan yazıyorsan orada bir problem vardır.

- Olgusal olarak aynı kategoriye girebilecek nesnelerde tekrar eden memberları diyeceksin ki tekrar etmemesi lazım bunları bir üst sınıfa almam gerekiyor. Kalıtımsal strateji uygulamam gerekiyor diyeceksin.

- Nesne tabanlı programlamada benzer/aynı olgudaki nesnelerin aynı olan memberları/özellikleri/içerikleri eğer ki her sınıf içinde tekrar tekrar tanımlanırsa bu aykırı bir durumdur. Yani biz bunu istemeyiz.

- Aynı olguda olan sınıfların tekrar eden memberları bir başka sınıfta toplansın ve oradan ilgili sınıflara kalıtımsal olarak aktarılsın.

- Bir sınıf başka bir sınıftan kalıtım alırsa/türetilirse/miras alırsa kalıtım aldığı sınıftaki tümmmmm memberları(erişimine izin verilen/miras olarak aktarılmasına izin verilen memberlar) miras/kalıtımsal/genetik olarak aktarılacaktır...

- Her sınıf tabikide diğerinde olmayan kendine has özellikler barındırabilir. İşte diğerinde olmayan genellenemeyen özellikler sınıfların kendilerinde tanımlanacaktır.

- Genellenemeyen, diğerlinde olmayan ve sadece o sınıfa ait olan özellikler direkt ilgili sınıfta tanımlanmalıdır.

- Genellenemeyen her cümlesiyle devam edilemeyen özellikler üst sınıfa yani bu kalıtım veren sınıfa koyulmaz.

<img src="3.png">

## Kalıtımın Kullanılmadığı Durumu İnceleyelim
- Elimde 3 tane sınıf var 3'üde aynı içeriğe sahip ya ben amele miyim yazılımcı mı? Yazdığım kod ne kadar kaliteli diye kendine sormalısın!

- Benim bir cümle kurma tarzım var birde o cümleyi üslubuyla tadında kurma şansım var. Hani kısacık bir cümleyle derdimi anlatıp çözüm getirmek varken uzun uzun derdimi anlatıp daha sonradan da o derdi daha da komplike hale getirebilecek halde çözmeye çalışmak ne kadar mantıklı?

- Sen de şüpheleneceksin kodlarına baktın sınıfların aynı olgularsa yani bütün nesneler aynı olguda olduğu sürece aynı olguda olan sınıfların tasarımına baktığında tekrar eden yapılanmalar varsa diyeceksin ki burada bir yanlışlık olabilir ben burada hepsinde tekrar eden yapılanmaları bir farklı sınıfa alıp oradan kalıtım alabilirim diyeceksin.

<img src="4.png">
<img src="5.png">

## Kalıtımın Kullanıldığı Durumu İnceleyelim
- Kalıtım lalettayin bir şekilde tasarlanmamalıdır. Ortak olguda olan nesneleri temsil edecek olan bir üst ve daha evrensel nitelikte olgu olmalıdır. Opel, Mercedes ve Fiat ortak olgudur. Yani üçüde bir arabadır. Haliyle bunların daha evrensel üst niteliği Araba olarak nitelendirilebilir.

- Kalıtım operasyonunda, kalıtım veren sınıfın erişilebilen tüm memberları kalıtım alan sınıfa kalıtsal olarak aktarılacaktır.

- Kalıtım veren sınıf neyi kalıtım vereceğini içindeki memberların erişim belirleyicisi dediğimiz keywordler sayesinde belirleyecek.

- Hem yönetilebilirliği arttı hem de kod maliyetini düşürmüş olduk.

- Polimorfizm'de kalıtımın sonucudur. Dolayısıyla kalıtım mihenk taşıdır.

<img src="6.png">
<img src="7.png">

- OOP'de kalıtım özünde nesnelerin birbirlerinden türemesini sağlayan bir özelliktir.

- Bu özellik yanında da birçok özellik ve stratejik yapılanma getirmektedir.
  * Virtual
  * Polimorfizm
  * Abstraction 

- Bu eğitim sürecinde OOP'de ki kalıtımı ve kalıtımın getirisi olan tüm stratejik yapılanmaları tam teferruatlı ele alacağız!

<img src="8.png">
<img src="9.png">

## C# Programlama Dilinde Hangi Yapılar Kalıtım Alabilirler?
- C# programlama dilinde kalıtım sınıflara özel bir niteliktir.

- Yani bir sınıf sade ve sadece bir sınıftan kalıtım alabilir.

- Evet, record'lar da kalıtım alabilmekte. Lakin sadece kendi aralarında. Kalıtım alabildikleri tek istisnai sınıf ise ileride göreceğimiz Object sınıfıdır.

- Ayrıca sonraki derslerimizde göreceğimiz abstract class, interface ve struct gibi yapılarında kendilerine göre kalıtımsal operasyonları mevcuttur. Bu yapılardaki kalıtımsal detaylar ilgili derslerde ele alınacaktır.

- Her yapılanmaya kalıtım uygulanmaz.

- `abstract class`tan ve `interface`den kalıtım almayız. Çünkü burada yapılan fiiliyat başkadır. Orada yapılanm işlem operasyon olarak aynı operatörle yapılır ama operasyon/işlem farklıdır. İmplementasyon mantığı farklı bir mantıktır.

- Bir `record`a her ne kadar fıtrat olarak `class`ta olsa gidip bir `class` üzerinden kalıtım veremiyorsun. Aynı şekilde bir `class`a `record` üzerinden de kalıtım veremiyorsun.

<img src="10.png">

## C#'ta Kalıtım Nasıl Alınır? : Operatörü
- C#'ta iki sınıf arasında kalıtımsal ilişki kurabilmek için `:` operatörü kullanılmaktadır.

- Hatta bilsekte bilmesekte kalıtımsal tüm ilişkiler `:` operatörü tarafından yapılmaktadır.

- Bir sınıf başka bir sınıftan kalıtım aldığında erişime açık/kalıtıma müsait olan bütün memberlar sınıfa aktarılacaktır. Şöyle bişey beklemeyelim :) Hocam ben bu kodu yazdım ama memberlar gelmedi arkadaş öyle kodun içerisinde selena gibi gelmesini bekleme tabiki de! Bu yapmış olduğun işlem neticesinde artık bu sınıftan bir nesne oluşturduğunda direkt ilgili aktarılan miras alınan memberlara erişebileceksin. Yani bunların direkt burada fiziksel olarak görünmesini bekleme. Bu compiler seviyesinde yani arkada dijital seviyede oluyor öyle düşün.

<img src="11.png">
<img src="12.png">

- Kalıtım operatörünün `:` solunda bir sınıf sağında ise başka bir sınıf vardır.

- `... : ...` `:` operatörü sağdaki sınıftaki tüm erişilebilir memberları, soldaki sınıfa kalıtımsal olarak aktarmaktadır.

- `:` Bu operatörü kalıtımsal operasyon olarak kullanmak istiyorsanız bir tek `class`ın modeli üzerinde kullanabilirsiniz. `class`ın tanımlanma süreci dışında başka yerde kullanamazsınız.

- Eriim belirleyicileri bir yandan da kalıtımsal durumlarda memberların davranışlarını sergilememizi sağlar.
 
<img src="13.png">

- Kalıtım, operasyonel olarak gerçekleştirildikten sonra compiler seviyesinde member aktarımı sağlanır!

<img src="14.png">
<img src="15.png">

## Pratik Yapalım
- Eğer kalıtım yoksa aynı olgudaki sınıflar tekrar ederler ve bizde burada kalıtım ihtiyacı olduğunu anlarız.

```C#
#Kalıtımdan Önce
class Muhasebeci
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}

class Yazilimci
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}

class Mudur
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}

#Kalıtımdan Sonra
class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}

class Muhasebeci : Personel
{
    public bool Musavir { get; set; }
}

class Yazilimci : Personel { }

class Mudur : Personel { }
```

## C# Examples
```C#
namespace oop_sinif;

class Program
{
    static void Main(string[] args)
    {
        Muhasebeci muhasebeci = new Muhasebeci();
        Mudur mudur = new Mudur();
        Yazilimci yazilimci = new Yazilimci();
    }
}

#region Kalıtımdan Önce
// class Muhasebeci
// {
//     public string Adi { get; set; }
//     public string Soyadi { get; set; }
//     public bool MedeniHal { get; set; }
// }

// class Yazilimci
// {
//     public string Adi { get; set; }
//     public string Soyadi { get; set; }
//     public bool MedeniHal { get; set; }
// }

// class Mudur
// {
//     public string Adi { get; set; }
//     public string Soyadi { get; set; }
//     public bool MedeniHal { get; set; }
// }
#endregion
#region Kalıtımdan Sonra
class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}

class Muhasebeci : Personel
{
    public bool Musavir { get; set; }
}

class Yazilimci : Personel 
{ 
    public string[] KullandigiDiller { get; set; }
}

class Mudur : Personel { }
#endregion
```