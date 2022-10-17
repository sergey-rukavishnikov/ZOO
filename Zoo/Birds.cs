namespace Zoo;

public class Birds
{
    public Birds(bool flying, string colour)
    {
        Flying = flying;
        Colour = colour;
    }

    public Birds()
    {
        Flying = true;
        Colour = "Black";
        Full = false;
    }

    public void Feed()
    {
        if (!Full)
        {
            Full = true;
            Console.WriteLine("Птица покормлена");
        }
        else
        {
            Console.WriteLine("Птица сыта");
        }
    }

    public void Speak()
    {
        Console.WriteLine("Вы поговорили с птицей");
    }
    private bool Full { get; set; } 
    public bool Flying { get; set; }
    public string Colour { get; set; }
}