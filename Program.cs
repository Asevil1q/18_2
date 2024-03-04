using System;
using System.Runtime.CompilerServices;
internal class Program  // 18_2
{
    public struct Rab
    {
        public string fam;
        public int zp;
        public int staz;
        public string dolz;
    }
    private static void Main(string[] args)
    {

        /*11 Среди РАБотников данного предприятия найти тех,
        чья заработная плата за месяц ниже средней по предприятию с указанием их 
        фамилии, 
        зарплаты, 
        стажа работы 
        должности. 
        */
        Console.Write($"Сколько РАБотников? ");
        int N = int.Parse(Console.ReadLine());
        Rab[] rab = new Rab[N];
        int i;
        for (i = 0; i < N; i++)
        {
            rab[i] = new Rab();
            Console.WriteLine($"Введите информацию о {i + 1} РАБотнике: ");
            Console.Write("Фамилия: ");
            rab[i].fam = Console.ReadLine();
            Console.Write("Зарплата: ");
            rab[i].zp = int.Parse(Console.ReadLine());
            Console.Write("Стаж: ");
            rab[i].staz = int.Parse(Console.ReadLine());
            Console.Write("Должность(1, 2, 3): ");
            rab[i].dolz = Console.ReadLine();
            Console.WriteLine("___________");
        }
        Console.WriteLine("N\tФамилия\tЗарплата\tСтаж\tДолжность");
        for (i = 0; i < N; i++)
        {
            Console.WriteLine($"{i + 1}\t{rab[i].fam}\t{rab[i].zp}\t\t{rab[i].staz}\t{rab[i].dolz}");
        }
        Console.WriteLine("___________");
        double sr, s = 0;
        for (i = 0; i < N; i++)
        {
            s += rab[i].zp;
        }
        sr = s / (N * 1.0);
        Console.WriteLine($"Средняя зарплата по предприятию = {sr}");
        Console.WriteLine("___________");
        Console.WriteLine("РАБотники, у которых заработная плата ниже средней по предприятию: ");
        Console.WriteLine("___________");
        Console.WriteLine("Фамилия\tЗарплата\tСтаж\tДолжность");
        for (i = 0; i < N; i++)
        {
            if (rab[i].zp < sr)
            {
                Console.WriteLine($"{rab[i].fam}\t{rab[i].zp}\t\t{rab[i].staz}\t{rab[i].dolz}");
            }
        }
    }
}