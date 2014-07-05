using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задача_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double a, S, P, L, S_kr;
            
            Console.Write("Введите а=");
            a = Convert.ToDouble(Console.ReadLine());
            double r = a / 2;
            double d = a*Math.Sqrt(2);
          
            S = a * a;
            P = 4 * a;
            S_kr = Math.PI * r * r;
            L = Math.PI * d;

            Console.WriteLine("Площадь квадрата ={0}", S);
            Console.WriteLine("Периметр квадрата ={0}", P);
            Console.WriteLine("Площадь круга ={0}", S_kr);
            Console.WriteLine("Длина окружности ={0}", L);
            Console.ReadKey();
        }
        
    }
}
