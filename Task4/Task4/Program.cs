using System;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 13;
            double a = 2 + Math.Sqrt(Math.Tan(3));
            double b = 7 + Math.Sqrt(Math.Tan(8));
            double c = 1 + Math.Sqrt(Math.Tan(4));
            double d = a * UmnozenieOne(x);
            double e = c * UmnozenieOne(x);
            double f = d * UmnozenieOne(x);
            double g = (d + e + f) / UmnozenieOne(x);

            Console.WriteLine(@" {d:##,##:##} ");
            Console.ReadKey();
        }

        static double UmnozenieOne(double x)
        {


            return x * 17 * 113;


        }

    }
}
