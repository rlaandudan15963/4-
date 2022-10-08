using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream Rfs, Wfs;
            Rfs = new FileStream("testinput.txt", FileMode.Open);
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
            FileStream R_Wfs = new FileStream("testoutput.txt", FileMode.Open);
            StreamReader R_result = new StreamReader(R_Wfs);
            Console.WriteLine(R_result);
            Rdouble.Close();
        }
    }
}
