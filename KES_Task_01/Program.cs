using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KES_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldCoins;
            int priceCrystals = 5;
            int buyCrystals;
            bool optionPurchase;

            Console.Write("Приветствую! Желаете приобрести кристаллы?\n");
        Link:
            Console.Write("Введите 'Да' или 'Нет'.\n");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Да":

                    Console.Write("\nСколько у вас золотых монет?\n");
                    goldCoins = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"\nЦена кристалла {priceCrystals} монет. Сколько вы хотите купить кристаллов?\n");
                    buyCrystals = Convert.ToInt32(Console.ReadLine());

                    optionPurchase = goldCoins >= priceCrystals * buyCrystals;
                    buyCrystals *= Convert.ToInt32(optionPurchase);
                    goldCoins -= priceCrystals * buyCrystals;

                    Console.WriteLine($"\nУ вас в сумке осталось {goldCoins} монет и появилось {buyCrystals} кристаллов.");

                    break;

                case "Нет":

                    Console.Write("\nЧтож, приходите в следующий раз. Всегда рад видеть!\n");
                    break;

                default:

                    Console.Write("\nНе понял. Повторите, пожалуйста.\n");
                    goto Link;
            }
        }
    }
}
