using System.Configuration;
using System.Data.SqlClient;
namespace ConsoleApp8;





public class Cat
{
    public  string Name { get; set; }
    private static int Ves { get; set; }
    private static int ID { get; set; }

    public int hp = 100;
    public static int Kishka;
    public const int eyes = 2;
    public const int min_ves = 20;
    public const int max_ves = 150;
    public int summ_eda;
    public static string Status = "live";

    public Cat(string name, int ves)
    {
        Name = name;
        Ves = ves;
        ID++;
        if (Status == "died")
        {
            ID -= 1;
        }
    }

    public static Cat Create(string name, int ves) => new Cat(name, ves);

    public void Print()
    {
        Console.WriteLine($"Кличка:{Name},Вес:{Ves},Здоровье:{hp}:Статус:{Status}");
    }

    public void Eat()
    {
        if (Kishka <= 5 && Status == "live")
        {
            summ_eda += 20;
            Kishka += 1;
            Ves += 20;
            Console.WriteLine($"Вы покормили {Name}, его вес теперь {Ves}");
            Console.WriteLine($"сумма всего съеденного корма {summ_eda}");
        }
        else if (Kishka == 6)
        {
            Console.WriteLine("Котику очень плохо перестаньте его кормить");

        }

        if (Kishka == 7)
        {
            kal();
        }

        if (Status == "died")
        {
            Console.WriteLine("Вы не можете выполнить этого действия так как ваши котики мертвы");
        }
    } 
    public void pee()
    {
        if (Kishka >= 2)
        {
            Kishka += 1;
            Ves -= 10;
            Console.WriteLine($"Котик {Name} cходил в туалет,его вес {Ves}");
        }
        else
        {
            Console.WriteLine("Ещё не время отправлять кошек в туалет");
        }

    }

    public void kal()
    {
        if (Kishka > 5)
        {
            Status = "died";
            Console.WriteLine($"Состояние котика {Name} Сейчас {Status}");
        }
        else
        {
            Status = "live";
            Console.WriteLine($"Состояние котика {Name} Сейчас {Status}");

        }
    }

    public static void GetCount()
    {
        Console.WriteLine(ID);
    }

    
   

    public void Save()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Console.WriteLine(connectionString);
        var connection = new SqlConnection(connectionString);
        connection.Open();
        SqlCommand command;
        string abobka = "INSERT INTO cats(id, name, ves) VALUES(@id, @name, @ves)";
        using (command = new SqlCommand(abobka,connection ))
        {
            SqlParameter nameParam = new SqlParameter("@id", ID);
            SqlParameter nameParam2 = new SqlParameter("@name", Name);
            SqlParameter nameParam3 = new SqlParameter("@ves", Ves);
            command.Parameters.Add(nameParam);
            command.Parameters.Add(nameParam2);
            command.Parameters.Add(nameParam3);
            command.ExecuteReader();
        }
    }
}