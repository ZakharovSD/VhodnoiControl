using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contr
    {
        public double zd1()
        {
            double a, b;
            Console.WriteLine("Введите число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            return Math.Log(a, b);
        }
        public bool zd3()
        {
            double a;
            Console.WriteLine("Введите число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Остаток при делении на 3 " + a % 3 + " остаток при делении на 4 " + a % 4);
            return (a % 3 == a % 4);
        }
        public void zd2()
        {
            double a, b, c, d;
            Console.WriteLine("Введите число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            d = Convert.ToDouble(Console.ReadLine());
            double per = Math.Abs(b - a) + Math.Abs(d - c)*2;
            double sq = Math.Abs(b - a) * Math.Abs(d - c);
            Console.WriteLine("Sq = " + sq + "Per = " + per);
        }
    }
}