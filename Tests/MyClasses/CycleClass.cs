namespace Tests.MyClasses;

public class CycleClass
{
    public int X { get; set; }
    public CycleClass Cycle { get; set; }

    public CycleClass(int x, CycleClass cycle)
    {
        X = x;
        Cycle = cycle;
    }
}