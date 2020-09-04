using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 8;
            //double[] y = new double[N] { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017 };
            double[] y = new double[N] { 8.5, 8.8, 9, 9.2, 9.6, 10, 10.3, 10.7 };
            double S1y = 0, S2x = 0, S3pairs = 0, S4squares = 0, S5squares = 0 ;
            for (int x = 0; x < N; ++x)
            {
                S1y += y[x];
                S2x += x;
                S3pairs += y[x] * x;
                S4squares += y[x] * y[x];
                S5squares += Math.Pow(x, 2);
            }
            double a = (N * S3pairs - S2x * S1y) / (N * S5squares - Math.Pow(S2x, 2) );
            double b = (S1y - a * S2x) / N;
            double p = (N*S3pairs-S2x*S1y)/ Math.Sqrt((N*S5squares- Math.Pow(S2x, 2))*(N*S4squares- Math.Pow(S1y, 2)));
            double R = Math.Pow(p, 2); ;
            Console.WriteLine("линейная апроксимация \nF=" + a + "*x+" + b + "\n R="+R);
            Console.ReadLine();
        }
    }
}
