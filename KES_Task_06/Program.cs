using System;

namespace KES_Task_06
{
    class Program
    {
        static void search(string[] addNames, string[] addProfessions, string[] secondNames)
        {
            bool prov = false;
            string secondName;
            Console.Write("Введите фамилию для поиска: ");
            secondName = Console.ReadLine();
            while (prov == false)
            {
                for (int i = 1; i < secondNames.Length; i++)
                {
                    if (secondName == secondNames[i])
                    {
                        Console.Write(addNames[i]);
                        Console.Write(" - ");
                        Console.WriteLine(addProfessions[i]);
                    }
                    prov = true;
                }
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();

        }
        static void removeAt(ref string[] removedName, ref string[] removedProf, int index)
        {
            string[] newRemovedName = new string[removedName.Length - 1];
            string[] newRemovedProf = new string[removedProf.Length - 1];
            for (int i = 0; i < index; i++)
                newRemovedName[i] = removedName[i];
            for (int i = index + 1; i < removedName.Length; i++)
                newRemovedName[i - 1] = removedName[i];
            for (int i = 0; i < index; i++)
                newRemovedProf[i] = removedProf[i];
            for (int i = index + 1; i < removedName.Length; i++)
                newRemovedProf[i - 1] = removedProf[i];
            removedName = newRemovedName;
            removedProf = newRemovedProf;

        }
        static void resizePlus(ref string[] resizeName, ref string[] resizeProf, ref string[] resizeSecondNames, int newSize)
        {
            string[] newSizeName = new string[newSize];
            string[] newSizeProf = new string[newSize];
            string[] newSizeSecondNames = new string[newSize];
            for (int i = 0; i < resizeName.Length; i++)
            {
                newSizeName[i] = resizeName[i];
                newSizeProf[i] = resizeProf[i];
                newSizeSecondNames[i] = resizeSecondNames[i];
            }
            resizeName = newSizeName;
            resizeProf = newSizeProf;
            resizeSecondNames = newSizeSecondNames;
        }
        private static void addName(string[] names, string[] professions, string[] secondNames, int i, int j, int size)
        {
            string a, b, c;
            Console.WriteLine("Добавить досье: ");
            Console.WriteLine();
            Console.Write("Введите фамилию: ");
            a = Console.ReadLine();
            secondNames[i] = a;
            Console.Write("Введите имя: ");
            b = Console.ReadLine();
            Console.Write("Введите отчество: ");
            c = Console.ReadLine();
            names[i] = a + " " + b + " " + c;
            Console.Write("Введите должность: ");
            professions[j] = Console.ReadLine();
            Console.WriteLine("Успех!");
        }
        private static void Main(string[] args)
        {
            int menu = 0, i = 0, j = 0, countProf = 1, size = 1, number;
            string[] addNames = new string[size];
            string[] addProfessions = new string[size];
            string[] addSecondName = new string[size];
            while (menu != 5)
            {
                countProf = 1;
                Console.WriteLine("Отдел кадров");
                Console.WriteLine("1 - Добавить досье");
                Console.WriteLine("2 - Вывести все досье");
                Console.WriteLine("3 - Удалить досье");
                Console.WriteLine("4 - Поиск по фамилии");
                Console.WriteLine("5 - Выход из программы");
                Console.WriteLine();
                Console.Write("Введите нужный Вам пункт: ");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    size += 1;
                    i++;
                    j++;
                    resizePlus(ref addNames, ref addProfessions, ref addSecondName, size);
                    addName(addNames, addProfessions, addSecondName, i, j, size);
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (menu == 2)
                {
                    for (int countNames = 1; countNames < addNames.Length; countNames++)
                    {
                        Console.Write($"{countNames}. ");
                        Console.Write(addNames[countNames]);
                        Console.Write(" - ");
                        Console.WriteLine(addProfessions[countProf]);
                        countProf++;
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (menu == 3)
                {
                    Console.WriteLine("Введите номер удаляемого досье");
                    number = Convert.ToInt32(Console.ReadLine());
                    removeAt(ref addNames, ref addProfessions, number);
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (menu == 4)
                {
                    search(addNames, addProfessions, addSecondName);
                }
            }
        }
    }
}
