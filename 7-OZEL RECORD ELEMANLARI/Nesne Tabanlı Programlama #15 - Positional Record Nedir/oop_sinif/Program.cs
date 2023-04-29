namespace oop_sinif;

class Program
{
    static void Main(string[] args)
    {
        MyRecord m = new MyRecord();
        var (n, s) = m;
    }
}

record MyRecord(string Name, string Surname)//Bu semantik arka planda name ve surname isminde property'ler tanımlayacaktır. Bu property'lerin özellikleri de `init` olacaktır.
{ 
    public MyRecord() : this("sdasfasfasf","sasafasfsafd")
    {
        
    }
    public MyRecord(string name) : this()
    {
        
    }
    // public string Name => name;
    // public string Surname => surname;
    public int Test { get; init; }
}
