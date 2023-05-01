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
