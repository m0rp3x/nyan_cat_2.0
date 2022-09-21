

namespace ConsoleApp7;



public class cat
{
    public string name;
    public int ves;
    public int hp = 100;
    public int kishka = 0;



    public void Print()
    {
        Console.WriteLine($"Кличка:{name},Вес:{ves},Здоровье:{hp}");
    }

    public void eat()
    {
        if (kishka < 5) 
        {
            Console.WriteLine($"Вы покормили {name}, его вес теперь {ves}");
            kishka += 1;
        }
        else
        {
            Console.WriteLine($"Вы перекормили {name}, она умерла");

        }
    }

    public void pee()
    {
        
    }
}

