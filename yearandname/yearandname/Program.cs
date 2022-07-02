using System;

namespace yearandname
{
    class yearandname
    {
        static void Main()
        {
            string name, ageuser, yes;
            int yearnow = 2022, year, age, born;
            Console.Title = "Знакомство";
            Console.WriteLine("Как  зовут тебя дружочек? =)");
            name=Console.ReadLine();
            string txt = "Ну привет, милаха, " + name + "!";
            Console.Title = "Вот и славненько!";
            Console.WriteLine("Хочешь я угодаю сколько тебе лет? Назови свой год рождения?!");
            ageuser = Console.ReadLine();
            bool result = Int32.TryParse(ageuser, out age);
            if (result)
            {
                born = yearnow - age;
                Console.Title = "Результат мега вычислений";
                Console.WriteLine("Получаеться тебе, "+name+" "+born+" годиков =) Угадал?");
                yes = Console.ReadLine();
                Console.Title = "Все это не важно";
                Console.WriteLine("А он такой: "+yes+", а она такая: бла бла бла, Давай досвиданья...)");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Такие класные как я предпочитают цифры! Давай прощаться зая!!!");
            }
        }
    }
}
