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
            int size;
            Console.Write("Введите размерность массива: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] mass1 = new int[size]; 
            
            Random rand = new Random();
            for (int y = 0; y < size; y++)
            {
                mass1[y] = rand.Next(1, 21);
            }

            int[] mass2 = mass1;

            Console.WriteLine("Изначальный массив:");
            Console.WriteLine(string.Join(" ", mass1));
            Shuffle(mass2);
            Console.WriteLine("Обработанный массив:");
            Console.WriteLine(string.Join(" ", mass2));
            Console.ReadKey();
        }
    }
}
