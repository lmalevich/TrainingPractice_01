using System;

namespace KES_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string heroName;
            Random rnd = new Random();
            int bossHp = rnd.Next(100, 200);
            int heroHp = rnd.Next(100, 200);
            bool die = true;
            int Vaddivazi;

            Console.WriteLine("Приветствую!");
            Console.Write("Вы стали Теневым Магом! Введите Ваше имя: ");
            heroName = Console.ReadLine();
            Console.WriteLine($"Итак, {heroName}, Ваша цель - уничтожить Того, Чье Имя Нельзя Называть. В Вашем арсенале есть несколько заклинаний.");
            Console.WriteLine("Вот полный список заклинаний: ");
            Console.WriteLine("[1] Ваддивази — заставляет лететь предмет в противника.\nОтнимает HP в зависимости от выбранного Вами предмета.");
            Console.WriteLine("[2] Эверте Статум — отбрасывает так, что жертва переворачивается в воздухе.\nОтнимает у противника 20HP.");
            Console.WriteLine("[3] Сектумсемпра — нанесение глубоких резаных ран.\nОтнимает у противника 30HP.");
            Console.WriteLine("[4] Летучемышиный сглаз — облепляет лицо жертвы летучими мышами.\nОтнимает у противника 20HP.");
            Console.WriteLine("[5] Адское пламя — почти неуправляемый поток огня. Опасен и для нападающего.\nБудьте ОЧЕНЬ осторожны с этим " +
                "заклинанием. Конечно, оно наносит большой урон противнику, но и Вы можете пострадать.\nОтнимает у противника 40HP, у Вас 15HP.\n");

            Console.WriteLine($"ХП Босса - {bossHp}");
            Console.WriteLine($"ХП Героя - {heroHp}");

            while (die)
            {
            Link:
                Console.Write("\nВы атакуете. Введите номер заклинания, которое Вы хотите использовать: ");
                string spell = Console.ReadLine();
                switch (spell)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали заклинание Ваддивази. Выберите предмет, который хотите бросить в противника: ");
                        Console.WriteLine("[1] Камень");
                        Console.WriteLine("[2] Кресло");
                        Console.WriteLine("[3] Носок");
                        Console.Write("Выберите предмет, который хотите бросить в противника: ");

                        Vaddivazi = Convert.ToInt32(Console.ReadLine());
                        if (Vaddivazi == 1)
                        {
                            Console.WriteLine("Вы выбрали камень. Он отправляется в противника и отнимает у него 10HP.");
                            bossHp -= 10;
                        }
                        if (Vaddivazi == 2)
                        {
                            Console.WriteLine("Вы выбрали кресло. Оно отправляется в противника и отнимает у него 20HP.");
                            bossHp -= 20;
                        }
                        if (Vaddivazi == 3)
                        {
                            Console.WriteLine("Что? Серьезно? Ладно, Вы выбрали носок. Он отправляется в противника и отнимает у него... Ох... 2HP.");
                            bossHp -= 2;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Вы выбрали заклинание Эверте Статум. Оно отняло у противника 20HP.");
                        bossHp -= 20;
                        break;

                    case "3":
                        Console.WriteLine("Вы выбрали заклинание Сектумсемпра. Оно отняло у противника 30HP.");
                        bossHp -= 30;
                        break;

                    case "4":
                        Console.WriteLine("Вы выбрали заклинание Летучемышиный сглаз. Оно отняло у противника 20HP.");
                        bossHp -= 20;
                        break;

                    case "5":
                        Console.WriteLine("Вы выбрали заклинание Адское пламя. Оно отняло у противника 40HP и у Вас 15HP.");
                        bossHp -= 40;
                        heroHp -= 15;
                        break;

                    default:
                        Console.WriteLine("Такого заклинания нет. Попробуйте еще раз.");
                        goto Link;
                }

                if (bossHp <= 0)
                    die = false;

                int attack = rnd.Next(15, 40);
                string[] bossAttack = new string[5] 
                    { 
                        $"Фурункулюс! В миг на Вашем теле появились десятки нарывов. Ваше HP уменьшилость на {attack}.",
                        $"Коньюктивитус! Оно на время ослепило вас и отняло {attack}HP.",
                        $"Жалящее заклинание! На Вас налетел рой толи пчел, толи ос, не было времени разбираться!!! Ваше HP уменьшилость на {attack}.",
                        $"Эверте Статум! Оно отбросило Вас так, что Вы несколько раз перевернулись в воздухе. Заклинание отняло у Вас {attack}HP.",
                        $"Конфринго! Срочно прячьтесь! Это заклинание вызывает пожар и взрыв. Ваше HP уменьшилость на {attack}."
                    };

                Console.Write("\nБосс выбирает заклинание ");
                Console.WriteLine(bossAttack[new Random().Next(0, bossAttack.Length)]);
                
                heroHp -= attack;

                Console.WriteLine($"\nХП Босса - {bossHp}");
                Console.WriteLine($"ХП Героя - {heroHp}");

                if (heroHp <= 0)
                    die = false;
            }

            if (heroHp <= 0)
                Console.WriteLine($"\nК сожалению, {heroName}, Вы проиграли. Ну, ничего страшного, набирайтесь сил и возвращайтесь к нам!");
            if (bossHp <= 0)
                Console.WriteLine($"\nУра!!! {heroName}, Вы выиграли! Поздравляю и жду Вас снова!");
        }
    }
}
