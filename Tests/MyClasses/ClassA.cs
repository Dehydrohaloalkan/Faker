namespace Tests.MyClasses;

public class ClassA
{
    public int Number;
    public string Text;
    public bool Check { get; set; }
    public static int Static { get; set; }

    public ClassA(int number, string text)
    {
        Number = number;
        Text = text;
    }
}