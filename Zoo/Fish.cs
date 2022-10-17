namespace Zoo;

public class Fish
{
    public double Length;
    public bool Edible;

    public Fish(bool edible, double length)
    {
        Edible = edible;
        Length = length;
    }

    public Fish()
    {
        Edible = false;
        Length = 100;
    }

    public void Catch()
    {
        var random = new Random();
        int got = random.Next();
        Console.WriteLine(got % 2 == 0 ? "Вы поймали рыбу" : "Попытайтесь ещё раз!");
    }

    public void Eat()
    {
        if (Edible)
        {
            Console.WriteLine("Приятного аппетита");
        }
        else
        {
            Console.WriteLine("YOU\nDIED");
        }
    }
}