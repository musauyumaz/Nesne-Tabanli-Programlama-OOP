namespace oop_sinif;
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Musa",
            Age = 24
        };

        var (x, y) = person;//person'ı al x ve y değişkenlerine ayır
    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Deconstruct(out string name,out int age)
    {
        name = Name;
        age = Age;
    }
}