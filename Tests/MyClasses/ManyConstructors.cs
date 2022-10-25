namespace Tests.MyClasses;

public class ManyConstructors
{
    public int X { get; set; }
    public int Y { get; set; }

    public const int ConstInt = 1;

    public ManyConstructors(int x, int y, int z)
    {
        X = z;
        Y = z;
    }

    public ManyConstructors(int x, int y)
    {
        X = x;
        Y = y;
    }
}