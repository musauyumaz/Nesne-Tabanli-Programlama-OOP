---
modified: 2023-05-12T06:39:56.396Z
title: "Nesne Tabanlı Programlama #20 - Polimorfizm Nedir? Derinlemesine
  İnceleme - 1. Bölüm"
---

***
# Nesne Tabanlı Programlama #20 - Polimorfizm Nedir? Derinlemesine İnceleme - 1. Bölüm
- Bir nesnenin birden fazla türle/referansla işaretlenebilme mevzusu.

<img src="1.png" width="auto">

## Polimorfizm Nedir?
- Polimorfizm esasında kalıtım gibi bir biyolojik terimdir.

- Polimorfizm biyolojide iki veya daha fazla farklı fenotipin aynı tür popülasyonunda bulunmasıdır.

- Nesne tabanlı programlama dediğimiz yapılanma özünde diğer disiplenlerden özellikle biyoloji'den terminolojik açıdan beslenen ve oradan mantıksal belirli aktarımlarda/davranışlarda bulunan yani biyolojiyi baz biyolojik mantığı baz alan bir yaklaşımdır.

- Polimorfizm'de bir biyolojik terimdir özünde.

- Polimorfizm yazılımda iki veya daha fazla farklı nesnenin aynı tür `class`lardan/referanslardan referans almasıdır/işaretlenebilmesidir.

- Çok biçimlilik demek bir olguyu br nesneyi birden fazla tarifle/formla tarif edebilmektir. Ben Musa'yım bir yandan insanım bende bile çok biçimlilik var.

- Mümkün mertebe olabilecek/olmuş olan hani doğrulanabilir bir biçimlilik söz konusu olması gerekiyor. Çok biçimliliğin olabilmesi için o forma uygun fıtratına uygun bir form yakıştırmanız gerekiyor.

<img src="2.png" width="auto">

- OOP'de ise polimorfizm'e:
  * İki ya da daha fazla nesnenin aynı tür sınıf tarafından karşılanabilmesidir/referans edilebilmesidir.
- diyebiliriz.

- Bir başka deyişle:
  * Bir nesne birden fazla farklı türdeki referans tarafından işaretlenebilmesi polimorfizm'dir.

- Yazılımsal açıdan elimde bir fare nesnesi olsun bu fare nesnesi bir yandan da ürün sınıfından kalıtım alıyorsa eğer yani elimde bir fare `class`ı var bu fare `class`ı ürün sınıfından da kalıtım alıyorsa eğer bu fare bir yandan da üründür. Farenin fare olması bu 1. biçimi. Bir yandan da ürün olmasından dolayı yani bu fare nesnesi hem fare referansı tarafından hem de ürün referansı tarafından referans edilebilmesi durumu ki edilebilir buna biz polimorfizm diyoruz.

- Bir nesne kalıtımsal açıdan ataları neyse atalarının referansıyla işaretlenebilir.

<img src="3.png" width="auto">

- Polimorfizm bir nesnenin kalıtımsal olarak ilişkisi olan diğer nesnelerin referanslarıyla işaretlenebilmesini sağlar.

<img src="4.png" width="auto">
<img src="5.png" width="auto">

- Polimorfizm, OOP tasarımlarında geliştirilen koda daha manevrasal bir şekilde nitelik kazandıran ve yaklaşım sergilememizi sağlayan bir özelliktir.

- Polimorfizm, programlamada ki temel prensip olan 'Sol/Sağ Prensibi'ni; aşıp eldeki nesnenin birden fazla referansla işaretlenebilmesini sağlar.

- Elinde bir nesnem var bu nesneyi biz sadece o nesnenin türünden herhangi bir referansla işaretleyebiliyorduk.

- Polimorfizmin dışında elindeki herhangi bir nesneyi sadece o nesnenin referansıyla işaretleyebiliyorsun. Amma velakin polimorfizm sayesinde elindeki bir nesneyi o nesnenin türünün dışındaki referanslarla da işaretleyebilirsin. İşte bu nesneye farklı türlerdeki referanslarla işaretleyebilme niteliğini kazandıran yapılanmaya biz polimorfizm diyoruz.

- Bir nesnenin birden fazla referansla işaretlenmesi o nesnenin birden fazla türün davranışını sergilemesini/gösterebilmesini sağlar.

<img src="6.png" width="auto">

- Bir nesneyi/objeyi birden fazla farklı türle işaretleyebiliyorsanız eğer o nesnenin o türlerin davranışını sergileyebilmesini sağlıyorsunuz.

<img src="7.png" width="auto">
<img src="8.png" width="auto">

## Polimorfizm Felsefesi - 1
<img src="9.png" width="auto">

- Bir şeyi sen başka birşeyle tarif edebiliyorsan bu çok biçimliliktir.

<img src="10.png" width="auto">

- Yani bir olguyu çoklu(poli) form(morfizmos) olarak tarif edebilmektir.

- Bir şey/olgu/yapı/nesne/varlık birden fazla form olarak tarif edilebiliyorsa bu çok biçimliliktir.

<img src="11.png" width="auto">
<img src="12.png" width="auto">

- Buradan da şunu anlıyoruz ki, yazılımsal açıdan çok biçimliliğin söz konusu olabilmesi için teknik olarak 'Kalıtım' olması gerekmektedir...

- Bir nesnenin farklı bir `class` referansıyla işaretlenebilmesi için o `class`tan türüyor olması gerekir. Aksi taktirde polimorfizm kuralları geçerli olmayacaktır.

- Bir nesnenin polimorfizm kuralları çerçevesinde olabilmesi için yani başka nesnelerle polimorfizm çok bir şekilde biçimlendirilebilmesi form olarak tarif edilebilmesi için o sınıflarla kalıtımsal ilişkiye girmesi gerekecektir.

<img src="13.png" width="auto">

## Polimorfizm Felsefesi - 2
<img src="14.png" width="auto">
<img src="15.png" width="auto">
<img src="16.png" width="auto">
<img src="17.png" width="auto">
<img src="18.png" width="auto">

## Polimorfizm Felsefesi - 3
<img src="19.png" width="auto">
<img src="20.png" width="auto">

## Peki Programlamada Polimorfizm Neden Nerede Kullanılmaktadır?
- Programlama da polimorfizm esasında taa en temelden beri kullanılmaktadır.

- Misal olarak;
  * Elimizdeki herhangi bir `byte` türündeki veriyi ister `byte` istersekte `byte`tan büyük olan herhangi bir türde tutmak çok biçimliliktir.

- Ya da `object` türünün herhangi bir türdeki değeri alabilmesi yahut bir başka deyişle `object` türüne herhangi bir türdeki veriyi atayabilmek polimorfizm'dir.

- Bütün sınıflar `object`ten türediğinden dolayı doğal olarak zaten bir polimorfizm söz konusu olacaktır.

- Bütün sınıflar `object`ten türüyorsa eğer `object` bize bu sınıfları referans edebilme niteliği kazandırıyor yani bir polimorfizm var.

- `object` referansıyla işaretleyebilmemizin altında yatan sebep kalıtımın bize getirmiş olduğu polimorfizm özelliğidir.

<img src="21.png" width="auto">

- `interface` `abstract class`lar da kullanırız. İleride design patternların %99'u polimorfizm üzerine kuruludur.

<img src="22.png" width="auto">

- Normal şartlarda bir nesne kendi sınıfının referansı dışında başka bir sınıfın referansıyla İŞARETLENEMEZ!

- Bir nesnenin başka bir nesne ile işaretlenebilmesi/referans edilebilmesi için kesinlikle arada kalıtımsal bir ilişki olması gerekmektedir.

- Yani bir başka deyişle, Nesne Tabanlı Programlama'da Polimorfizm uygulamak istiyorsanız türler arasında kalıtım uygulanmış olmalıdır.

- Ya da bam başka bir deyişle; Nesne Tabanlı Programlama'da Polimorfizm aralarında kalıtımsal ilişki olan sınıflarda uygulanabilir. Aksisi mümkün değildir!

<img src="23.png" width="auto">

- Bir nesneyi başka bir türden referansla işaretleyemezsin. İşte böyle bir durumun gerçekleşmesi için polimorfizmin olması gerekmektedir. Polimorfizm'in olabilmesi içinde bu `class`lar arasında kalıtımsal ilişkinin olması lazım. Buradaki referans mantığı ise şöyledir;
  * Ben Cumhurbaşkanını referans edemem ama Cumhurbaşkanı beni referans edebilir. Çünkü o benden daha üstte daha atalarda/büyüğümüz öyle düşün. Bu durumda referans eden referans ettiği nesnenin atası olmalıdır.

```C#
MyClass2 m = new MyClass();

public class MyClass : MyClass2
{
    
}
public class MyClass2 
{
    
}
```

## Polimorfizm Kalıtım İlişkisi
- Bir nesneyi kendi türünün dışındaki bir tür ile/referansla işaretleyebilmek için kesinlikle ilgili nesne, o türden türemiş olması gerekmektedir.

- Bir nesne ancak ve ancak kendisinden olan bir türle referans edilebilir/işaretlenebilir. Artık tanımı genişletiyoruz ya da atalarından olan bir referansla da işaretlenebilir.

- <img src="24.png" width="auto">
- <img src="25.png" width="auto">
- <img src="26.png" width="auto">

## Pratik Örnek
- Bir `class` sade ve sadece tek bir `class`tan türeyebilir. Yatay düzlemde türeme yoktur. Dikey türeme yapabilirsiniz.

- Birden fazla türle farklı bir türdeki nesneyi referans etmeye çok biçimlilik/polimorfizm diyoruz.

```C#
A a = new B();
B b = new B();
C c = new B();

class A : C
{

}


class B : A
{

}
class C 
{

}

```

## Teorik Örnek
<img src="27.png" width="auto">

```C#
Erkek e = new Erkek();
Insan i = new Erkek();
Kadın k = new Kadın();
Insan i2 = new Kadın();

class Insan
{

}
class Erkek : Insan
{

}
class Kadın : Insan
{

}
```

## Peki, Polimorfizm Bir Nesne Yönetiminde Neye Yarar?
- Daha önceden de söylediğimiz gibi, Bir nesnenin birden fazla referansla işaretlenmesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar.

- Referansın sana erişebileceğin sınırları/davranışları getiriyor. Sınırlandırarak filtreleyerek getiriyor.

- Bu şekilde bir eleme/filtreleme sadece davranışları sergileyebilme getiren bu polimorfizm yapılanması elbetteki bir işe/naneye yaramaktadır. İşte bu naneler bize ileride sağlam tasarımlar ortaya koymamızı sağlayacak.

- Polimorfizm bir nesnenin kendi türünün dışında bir veya birden fazla türle işaretlenebilmesidir/referans edilebilmesidir. Ve bunun bize getirmiş olduğu farklı davranışları sergileyebilme niteliğidir.

<img src="28.png" width="auto">
<img src="29.png" width="auto">
<img src="30.png" width="auto">

```C#
C c = new C();
B b = new C();
A a = new C();

class A
{
    public void X() { }
}


class B : A
{
    public void Y() { }
}
class C : B
{
    public void Z() { }
}
```

## C# Examples
```C#
namespace polimorfizm;
class Program
{
    static void Main(string[] args)
    {
        MyClass2 m = new MyClass();

        // A a = new B();
        // B b = new B();
        // C c = new B();

        Erkek e = new Erkek();
        Insan i = new Erkek();

        Kadın k = new Kadın();
        Insan i2 = new Kadın();


        C c = new C();
        B b = new C();
        A a = new C();
        
        


    }
}
#region Örnek 1
public class MyClass : MyClass2
{

}
public class MyClass2
{

}
#endregion

#region Örnek 2
// class A : C
// {

// }


// class B : A
// {

// }
// class C
// {

// }
#endregion

#region Örnek 3
class Insan
{

}
class Erkek : Insan
{

}
class Kadın : Insan
{

}
#endregion

#region Örnek 4
class A
{
    public void X() { }
}


class B : A
{
    public void Y() { }
}
class C : B
{
    public void Z() { }
}
#endregion
```
