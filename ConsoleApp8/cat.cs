
namespace ConsoleApp8;

public class Cat
{
    public string name;
    public int ves = 20;
    public int hp = 100;
    public int kishka;
    public const int eyes = 2;
    public const int min_ves = 20;
    public const int max_ves = 150;
    public int summ_eda;
    
    public void Print()
    {
        Console.WriteLine($"Кличка:{name},Вес:{ves},Здоровье:{hp}");
    }
    public void Eat()
    {
        if (kishka != 5) 
        {
            summ_eda += 20;
            kishka+=1;
            ves += 20;
            Console.WriteLine($"Вы покормили {name}, его вес теперь {ves}");
            Console.WriteLine($"сумма всего съеденного корма {summ_eda}");
        }
        else
        {
            Console.WriteLine($"Вы перекормили {name}, он бахнул");
        }

    }
    public void pee()
    {
        if (kishka >= 2)
        {
            kishka=0;
            ves -= 10;
            Console.WriteLine($"Котик {name} cходил в туалет,его вес {ves}");
        }
        else
        {
                Console.WriteLine("Ещё не время отправлять кошек в туалет");
        }
    }
}

