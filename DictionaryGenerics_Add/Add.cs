﻿namespace ConsoleApplication1
{
    class UserInfo
    {
        // Метод, реализующий словарь
        public static Dictionary<int, string> MyDic(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Console.WriteLine("Введите имя сотрудника: \n");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.Write("Name{0} --> ", j);
                s = Console.ReadLine();
                dic.Add(j, s);
                Console.Clear();
            }
            return dic;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Сколько сотрудников добавить? ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Dictionary<int, string> dic = UserInfo.MyDic(i);

                // Получить коллекцию ключей
                ICollection<int> keys = dic.Keys;

                Console.WriteLine("База данных содержит: ");
                foreach (int j in keys)
                    Console.WriteLine("ID -> {0}  Name -> {1}", j, dic[j]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод");
            }

            Console.ReadLine();
        }
    }
}