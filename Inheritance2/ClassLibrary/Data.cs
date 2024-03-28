namespace ClassLibrary;

public class Data
{
    public int publicA = 1;
    protected int protectedA = 2;
    private int privateA = 3;
    internal int internalA = 4;
    protected internal int protectedInternal = 5;
    private protected int privateProtected = 6;


    public void Foo()
    {
        //protectedA
    }
}
public class Data2 : Data
{
    public void Test()
    {
        //this.protectedA
    }
}
