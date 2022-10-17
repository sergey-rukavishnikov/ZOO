namespace Zoo;

public class Animals
{
    public Animals(bool bites, string family)
    {
        Bites = bites;
        Family = family;
    }

    public Animals()
    {
        Bites = false;
        Family = "Feline";
    }

    public void Pet()
    {
        if (Bites)
        {
            Console.WriteLine("Вы получили 15 урона");
        }
        else
        {
            Console.WriteLine("Вы погладили кошку");
        }
    }

    public void Tame()
    {
        Random random = new Random(5);
        if (random.Next() == 1)
        {
            Console.WriteLine("Поздравляем! Теперь у вас есть друг");
        }
        else
        {
            Console.WriteLine("Опять неудача");
        }
    }

    public bool Bites { get; set; }
    public string Family { get; set; }
    
}