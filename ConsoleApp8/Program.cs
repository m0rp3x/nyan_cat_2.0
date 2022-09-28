using System.Data.SqlClient;
using System;
using System.Data;
using System.Configuration;

namespace ConsoleApp8;


internal class aboba
{


    public static void Main(string[] args)
    {
        
        
        Console.WriteLine("Добро пожаловать в nyan_cat_wars, в этой игре вы сможете играть за котиков,они едят,спят,скребут стены и прочее ");
        Console.Write("Введите имя первого котика:");
        Cat aboba = Cat.Create($"{Console.ReadLine()}", 100);
        Console.Write("Введите имя Второго котика:");
        Cat chikibombony = Cat.Create($"{Console.ReadLine().ToString()}", 100);
        Console.Write("Введите имя Третьего котика:");
        Cat lololowka = Cat.Create($"{Console.ReadLine().ToString()}", 100);
        Console.Write("Введите имя Четвертого котика:");
        Cat liciy = Cat.Create($"{Console.ReadLine().ToString()}", 100);
        Console.Write("Введите имя Пятого котика:");
        Cat shaturnaya = Cat.Create($"{Console.ReadLine().ToString()}", 100);
        
        while (true)
        {
            Console.WriteLine("Выберете пункт меню:");
            Console.WriteLine("1.Показать всех кошечек которые у вас есть");
            Console.WriteLine("2.Покормить кошечек");
            Console.WriteLine("3.Повести кошечек в туалет");
            Console.WriteLine("4.Число ваших кошек");
            Console.WriteLine("5.Посмотреть статусы ваших котяток");
            Console.WriteLine("6.Сохранить прогресс");
            
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
                        case '4':
                        {
                            Cat.GetCount();

                            break;
                        }
                        case '5':
                        {
                            Cat.kal();
                            break;
                        }
                        case '6':
                        {
                            aboba.Save();
                            chikibombony.Save();
                            lololowka.Save();
                            liciy.Save();
                            shaturnaya.Save();
                            break;
                        }
                    }
                }
            }
        }
    }
}