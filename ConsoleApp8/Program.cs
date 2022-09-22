

namespace ConsoleApp8;

internal class aboba
{


    public static void Main(string[] args)
    {

        Cat aboba = new Cat();
        Cat chikibombony = new Cat();
        Cat lololowka = new Cat();
        Cat liciy = new Cat();
        Cat shaturnaya = new Cat();
        aboba.name = "Абоба";
        chikibombony.name = "Чикибомбони";
        lololowka.name = "Лололовка";
        liciy.name = "Лысый";
        shaturnaya.name = "Шатурная";
        while (true)
        {



            

            Console.WriteLine("Выберете пункт меню:");
            Console.WriteLine("1.Показать всех кошечек которые у вас есть");
            Console.WriteLine("2.Покормить кошечек");
            Console.WriteLine("3.Повести кошечек в туалет");
            {


                char ch = char.Parse(Console.ReadLine() ?? string.Empty);
                {


                    switch (ch)
                    {
                        case '1':
                        {
                            aboba.Print();
                            chikibombony.Print();
                            lololowka.Print();
                            liciy.Print();
                            shaturnaya.Print();


                            break;
                        }
                        case '2':
                        {
                            aboba.Eat();
                            chikibombony.Eat();
                            lololowka.Eat();
                            liciy.Eat();
                            shaturnaya.Eat();

                            break;
                        }
                        case '3':
                        {
                          aboba.pee();
                          chikibombony.pee();
                          lololowka.pee();
                          liciy.Eat();
                          shaturnaya.pee();

                            break;
                        }
                    }
                }
            }
        }
    }
}
            
            
            