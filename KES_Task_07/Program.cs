using System;

namespace KES_Task_07
{
    class Program
    {
        private static void Shuffle(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var rndInd = rnd.Next(0, arr.Length);
                var rndInd2 = rnd.Next(0, arr.Length);
                var temp = arr[rndInd];
                arr[rndInd] = arr[rndInd2];
                arr[rndInd2] = temp;
            }
        }

        private static void Main(string[] args)
        {
            var mass1 = new[] { 1, 22, 3, 4, 5, 9, 8, 24, 38, 1, 54, 63, 2 };
            int[] mass2 = mass1;
            Console.WriteLine("Первый массив:");
            Console.WriteLine(string.Join(" ", mass1));
            Shuffle(mass2);
            Console.WriteLine("Второй массив:");
            Console.WriteLine(string.Join(" ", mass2));
            Console.ReadKey();
        }
    }
}
