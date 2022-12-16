using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream Rfs, Wfs;
            Rfs = new FileStream("testinput.tat", FileMode.Open);
            Wfs = new FileStream("testoutput.txt", FileMode.Create);
            StreamReader Rdouble = new StreamReader(Rfs);
            StreamWriter Wdouble = new StreamWriter(Wfs); 
            string buff1 = Rdouble.ReadLine();
            String[] buff2 = buff1.Split(' ');
            double C = double.Parse(buff2[0]);
            int A = int.Parse(buff2[1]), B = int.Parse(buff2[2]);
            double result = 0;
            Wdouble.Write("("); 
            for(int i = A; i<=B; i++)
            { 
                result += (2 * i) / (2 + i);
                Wdouble.Write($"{result}");
                if (i != B) Wdouble.Write(" + ");
                else break;
            }
            result = result - (C * 2.5);
            Wdouble.Write($") - {C} * 2.5 = {result}");
            Wdouble.Close();
            Rdouble.Close();
            Console.Write("want show reault?(y/n) : ");
            char check = char.Parse(Console.ReadLine());
            if(check == 'y')//아마 한번 멈춰줘야 쓰기 파일을 제대로 불러내서 읽을수 있는 것 같다.(성공?)
            {
                FileStream Result;
                Result = new FileStream("testoutput.txt", FileMode.Open);
                StreamReader Re = new StreamReader(Result);
                string R = Re.ReadLine();
                Console.WriteLine(R);
                Re.Close();
                Result.Close();
            }
            else
            {
                Rfs.Close();
                Wfs.Close();
            }
        }
    }
}
