using System;

namespace KES_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое слово: ");
            string message = Console.ReadLine();

            while (!message.Contains("exit"))
            {
                if (message != "exit")
                {
                    Console.WriteLine("Повторите операцию или введите 'exit' для выхода");
                    message = Console.ReadLine();
                }
            }
        }
    }
}