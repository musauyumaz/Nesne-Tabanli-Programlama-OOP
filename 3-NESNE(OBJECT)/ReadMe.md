---
modified: 2023-04-20T06:44:52.389Z
title: "Nesne Tabanlı Programlama #6 - Nesne Kavramı Nedir? Nesne Nasıl
  Oluşturulur? | new Operatörü"
---

# Nesne Tabanlı Programlama #6 - Nesne Kavramı Nedir? Nesne Nasıl Oluşturulur? | new Operatörü
<img src="1.png" width="auto">

## Nesne Nedir? Ne Amaçla Kullanılır?
- Nesne dediğimiz yapılanma canlı bir organizma içerisinde birden fazla anlamlı birbirleriyle ilişkisel veriler tutan ve sadece bunları tutmakla yetinmeyen birazda böyle entellektüel bir alışkanlığını yanı olan bu veriler üzerinde işlemler yapıp sonuçlar üretebilen fonksiyonellikler barındıran bir yapılanma/organizmadır.

- Nesne dediin kavram bir veri bütünü. Mesela ben Musa olarak bir nesneyim. Adım Musa nesnemin bir parçası soyadım Uyumaz nesnemin bir parçası gözümün rengi nesnemin başka bir parçası. Benin ben yapan bütün değerler ile ben nesne olarak ortaya çıkarım.

- Bir olguya dair bütün alakadar değerler bir araya geldiğinde nesne ortaya çıkar. Haliyle o nesne o olguya dair verileri tutan verileri barındırabilen ve o veriler üzerinde işlem yapılmasını sağlayabilen bir organizma.

- Organizma diyince akla amip geldi. Amip diyebilirsin nihayetinde ilkel bir organizma üzerinde veriler tutuyorsun bu veriler üzerinde de işlem yapmanı sağlayan fonksiyonlar barındıran bir yapılanma. Ekosistemden bahsediyoruz bakın canlı üzerindeki veriler değişebiliyor o veriler üzerinde işlem yapan fonksiyonları var onlarla hareket edebiliyor vs. Ekosistemi olan canlı bir mekanizma.

- Nesne dediğimiz prosedürel programlamada bir olguya dair verileri temsil edebilmek için kullandığımız değişkenler diziler vs. yani bu olgular bir yerden sonra çoğaldığında oradaki kodun yönetimi ne kadar zorlaşıyorsa biz bu olguların bir tanesini `class`la modelliyoruz. Bu `class`lar neticesinde o olguya dair bütün alanları field dediğimiz yapıları bundan üretilen nesnede field'larımıza gerekli değerlerimizi koyuyoruz ve bu field'lar üstünde işlem yapmamızı sağlayan metotlar property'ler indexer dediğimiz yapılanmalar vs. bunları kullanarak ortaya bir organizma koyuyoruz. Nesne tabanlı programlamada işte temel esas teşkil eden yapılanma bu organizma yani nesnedir.

- Nesne dediğimiz yapılanma `class` yapılanmalarından üretilen verilerdir. Yani nesne de bir veridir.
    * Şimdi ben Musa olarak adım, soyadım, yaşım, boyumun uzunluğu vs. bunun gibi değerler bir veridir. Ama ben bir bütün olarakta tek başıma bir veriyim. Nihayetinde Ahmet'e, Mehmet'e nazaran Musa verisiyim. Musa'nın detayına inersen adına, soyadına, yaşına varabiliyorsun.

- Nesneler de bir veridir sadece daha üstün/kompleks veridir. Nesneler kompleks veri diye geçer. Çünkü ne `int`tir ne `string`tir ne de `char` çünkü bunların hepsini barındırabilen bir yapıdır.

- Nesne dediğiniz bir olgunun karşılığıdır.

<img src="2.png" width="auto">

- Oluşturduğum nesne kompleks mi kompleks içerisine `string`, `int`, `bool` değerler alarak meydana gelen bir bütün.

- Bu nesneyi bir araya getiren veriler bütünsel olarak birbirleriyle ilişkisel bir bütün oluşturacak verilerin meydana gelmesiyle oluşur.

- Nesne dediğin içinde lüzumsuz bir değere yer vermeyen yapılanmadır/bir değerdir. Haliyle bu değer kompleks bir değerdir/türdür.

- Nesneler complex değerlerdir.... Çünkü içerisinde birden fazla normal değer türlülere nazaran daha fazla bir yapılanma daha fazla bir değer taşıdıklarından dolayı. 

- Nesneleri modellememizi sağlayan `class`lar ise Complex Type'lardır.

<img src="3.png" width="auto">

- Kavramsal olarak nesne içerisinde bir veya birden fazla değer barındırabilen anlamlı verileri bir bütün olarak barındıran organizmadır ve bu organizma entellektüel açıdan alışkanlığa sahip o verilerin üzerinde işlem yapan ve bu işlemler neticesinde değerler üretebilen canlı bir ekosisteme sahip yapılanmadır.

- Nesne tabanlı programlama da olguları modelleyip olguları tek bir değer olarak temsil edebilmekteyiz.

- Kimlikte Devlet bir tane nesne modeli oluşturuyor burada olgusal olarak birbirine yakın anlamlı ilişkisel verileri o nesne modelinin içerisine koyuyor ve buradan üretilen tüm nesneler ile tüm vatandaşlara karşılıyor. Oradaki nesne modeli esasında vatandaşı modelliyor. Bir vatandaşta olabilecek ortak bilgiler;
    * Adı
    * Soyadı
    * Seri Numarası
    * TC Kimlik Numarası vs.
- Adam gidip oraya şunu yazıyor mu tuttuğu takım. İyi de arkadaş bütün vatandaşlar bir takım tutmak zorunda değil. Anlamlı mı o veri oradaki bütüne anlam katıyor mu? Anlamını bozuyor o zaman onu çıkarmış adamlar bak.

- Nesne dediğiniz anlamlı verilerin bir araya gelip bir bütün oluşturduğu temel kopmleks bir değerdir. 

- Nesne neden kullanılır?
    * Kodu daha hızlı geliştirebilmek
    * Kodu daha sistematik hale getirebilmek
    * Kodu daha yönetilebilir kılmak için kullanılır.

- Prosedürel programlamada 10 tane öğrenciyi adıyla soyadıyla tutmaya çalış. Yapmaya çalıştığında gerçekten dersin ki of ya kodlama da ne kadar zormuş Halbuki kodlamanın zorluğu değil. O yaklaşıma göre bu şekilde olgusal modellemeleri yapmak neredeyse imkansız. Amma velakin sen bunu gelip nesnel yaklaşımda ele alırsan çok kolay bir şekilde bu işlemi gerçekleştirdiğini göreceksin. Onun için yapmış olduğumuz işlemleri daha hızlı daha sistematik daha yönetilebilir daha kullanılabilir hale getirmek için nesne yapılarını tercih etmekteyiz.

- Nesnenin fıtratı `class`tır. Nesne oluşturmak istiyorsan kesinlikle sadece `class`a ihtiyacın var. Programlamada nesne mi oluşturacaksın `class`tan başka şansın yok.`interface` denilen yapılanma var nesne oluşturmaz. `struct` denen bir yapılanma var. nesne oluşturduğunu zannedersin ama onda da nesne oluşturamazsın. `Record` dediğimiz yapılanma var o ayrı onda nesne oluşturacağız ama davranışımız değişecek. `Record`larda esasında `class` yapılanması. `abstract class` nesne oluşturamazsın. Haliyle senin nesne oluşturabilmek için yapman gereken kullanman gereken tek şey `class` normal yani. Uzaya füze de göndersen üzgünüm ki sadece `class`la nesne oluşturabiliyoruz.

## Bir Sınıftan Nesne Üretme/Türetme/Oluşturma
<img src="4.png" width="auto">

## new Operatörü İle Nesne Üretimi
- C#'ta nesne üretimi için `new` operatörü kullanılmaktadır.

- Semantik açıdan nesne oluşturabilmek için kullanmamız gereken bir operatör vardır. Compiler'a senin bildirmen lazım. Yani kardeşim şu `class` var ya şu `class`tan bana bir tane nesne oluştur demen gerekiyor. İşte bunun için kullanacağımız operatör `new` operatörüdür.

- `new Type()` => `new` operatörü ile nesne oluşturmak için direkt kodun içinde `new` yazıyorsun `new` yazdıktan sonra hangi sınıftan/türden bir nesne oluşturmak istiyorsan `new` yazdıktan sonra ilgili sınıfın ismini bildirmen yeterli olacaktır.
    * Burada dikkat etmen gereken şey sınıf ismini yazarken bir parantez açıp kapatırız. Bu da bir metot biz buna ileride constructor metot diyeceğiz. `new` operatörü ile herhangi bir türdeki sınıftan ya da herhangi bir sınıftan ya da herhangi bir türden nesne oluşturacaksan bu metodu çağırmak zorundasın.

- `new` operatörünü compiler gördüğünde aha bir tane nesne oluşturacam diyor. Neyi oluşturacağını da yanındaki bildiriden anlıyor.

- Biz oluşturduğumuz nesneler HEAP'e koyulduğu zaman nesnelere biz direkt erişemiyorduk çünkü developer olarak bizim HEAP'e erişme yetkimiz yok. Haliyle biz elimizdeki nesneleri yani HEAP'te oluşturmuş olduğumuz o organizmaları o verileri erişip üzerinde işlem yapıp değerlerimiz üzerinde çalışmalar sergilemek istiyorsak bizim bu nesneyi STACK'teki bir referansla işaretlememiz gerekir ve bu nesneyi işaretlerken referansın türüde bu nesneden olmalı.

- Eğer değer türlü değişkenlerde çalışıyorsanız `=` operatörü ile değer türlü değişkenlerde assign görevi görüyor. Yok eğer referans türlülerde çalışıyorsanız referans etme görevi görüyor.

- Assign => Bellekte tahsisi yapılmış İçi boş alana bir değer eklemek

- Değer türlü değişkenler bellekte alan tahsisi yaparlar. Assign operatörünün önündeki değer, bu değer türlü değişkenlerin tahsisini yaptığı ve henüz içi boş olan alana atanır. Böylece değer türlü değişkenlerde (Assign) olayı gerçekleşir.

- Assign'ın yukarıda yaptığım tanımını göz önünde bulundurarak referans türlü değişkenlere bakacak olursak onlarda assign olmadığını görürüz. Çünkü referans türlü değişkenlerde alan tahsisi diye bir olay yoktur ki tahsisi yapılmış içi boş alana değer atama işlemi diğer bir adıyla assign işlemi gerçekleşsin; zira referans türlü değişkenlerde bizim yaptığımız şey referans noktası ile nesnenin arasında bir bağlantı kurmaktır.

- Değer türlü değişkenlerde iki unsur vardır;
    1. Değişken  
    2. Değer.
- Referans türlü değişkenlerde de iki unsur vardır; 
    1. Referans noktası 
    2. Nesne.

- Değer türlü değişkenlerin iki unsuru arasındaki alaka: Birinin tahsis ettiği alanı diğerinin doldurmasıdır. Bu doldurtma işlemi assign'dır.

- Referans türlü değişkenlerin iki unsuru arasındaki alaka ise: Yalnızca, birinden diğerine vasıl olabilmemiz için biri ile diğerinin arasında bağlantı kurmaktır. Bağlantı kurmak ise assign değildir.

- Bir nesneyi illaki bir referansla işaretmelek zorunda değiliz. Nesneyi oluşturup HEAP'e koyup bir daha kullanmamak üzere orada bırakabilirsin.

```C#
new MyClass();
new Random();
        
new MyClass();
new MyClass();
new MyClass();
new MyClass();
class MyClass
{
    public int A { get; set; }
    public void X()
    {

    }
}
```

<img src="5.png" width="auto">

## Target-Typed New Expressions (C# 9.0)
- [C# 9.0 – Target-Typed New Expressions](https://www.gencayyildiz.com/blog/c-9-0-target-typed-new-expressions/)

- Nesne oluşum sürecinde, oluşturulacak olan nesne eğer ki direkt bir referansa atılıyorsa eğer burada hangi nesnenin oluşturulduğu referans sayesinde bilinebilmektedir. 

- Bu özellikle birlikte oluşturulacak nesnenin türü referanstan bilinebilmektedir.

- Generic yapılanmalarda uzun uzun referanslar tanımlıyoruz. `List` koleksiyonları uzun uzun tanımlıyoruz. İşte böyle durumlarda karşı taraftaki tanımlama sürecini inanılmaz derecede kısaltan bir özelliktir.

<img src="6.png" width="auto">

## C# Examples
```C#
namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        new MyClass();

        new Random();

        new MyClass();
        new MyClass();
        new MyClass();
        new MyClass();

        MyClass m = new();
    }
}
class MyClass
{
    public int A { get; set; }
    public void X()
    {

    }
}
```
