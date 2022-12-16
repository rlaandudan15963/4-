using System;

namespace ConsoleApp2
{
    internal class Program
    {
        class Add_Sub
        {
            int num;
            public Add_Sub(int num = 0)
            {
                this.num = num;
            }
            public void Add(int b)
            {
                int a = num;
                num += b;
                Console.WriteLine($"{a} + {b} = {num}");
            }
            public void Sub(int b)
            {
                int a = num;
                num -= b;
                Console.WriteLine($"{a} - {b} = {num}");
            }
            public void Mut(int b)
            {
                int a = num;
                num *= b;
                Console.WriteLine($"{a} * {b} = {num}");
            }
            public void Clear()
            {
                num = 0;
            }
        }
        static void Main(string[] args)
        {
            Add_Sub A = new Add_Sub();
            int check = 0, num;
            while(check != 5)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Add(1), Sub(2), clear(3), eixt(4)");
                Console.Write("=>");
                check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1: 
                        Console.WriteLine("------------------------------------");
                        Console.Write("Write Added num => ");
                        num = int.Parse(Console.ReadLine());
                        A.Add(num);
                        break;
                    case 2:
                        Console.WriteLine("------------------------------------");
                        Console.Write("Write Subed num => ");
                        num = int.Parse(Console.ReadLine());
                        A.Sub(num);
                        break;
                    case 3:
                        Console.WriteLine("------------------------------------");
                        A.Clear();
                        Console.WriteLine("Clear Complete");
                        break;
                    case 4:
                        Console.WriteLine("exit program");
                        break;
                }
            }
        }
    }
}
