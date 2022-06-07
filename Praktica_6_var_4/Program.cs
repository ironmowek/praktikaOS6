using System;
using System.IO;

namespace OS_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск корневого процессса:");
            var q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                File.WriteAllText($" Физическая страница №{i}", "");

            }
            for (int i = 0; i < 3; i++)
            {
                File.WriteAllText($" Виртуальная страница №{i}", "");

            }
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    var g = new Random().Next(q + 2);
                    string name = $" Физическая страница №{g}";
                    if (g < q)
                    {
                        for (int k = 0; k < 3000; k++)
                        {
                            File.AppendAllText(name, "Заполнитель");
                        }
                    }
                    if (g >= q)
                    {
                        for (int k = 0; k < 3000; k++)
                        {
                            File.AppendAllText($" Виртуальная страница №{g - q + 1}", "Заполнитель");
                        }
                    }
                }
            }
        }
    }
}