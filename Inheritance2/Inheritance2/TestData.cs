using ClassLibrary;

namespace Inheritance2;

public class TestData
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} {Age}";
    }

    public override int GetHashCode()
    {
        return this.Name.Count() + this.Age;
    }

    public override bool Equals(object? obj)
    {
        return this.Name == ((TestData)obj).Name && this.Age == ((TestData)obj).Age;
    }
}
