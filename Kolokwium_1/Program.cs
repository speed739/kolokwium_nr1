using System;

namespace Kolokwium_1
{
                               //Gr C
     class Pole
        {

        public double a, b, h;
        public Pole(double a,double b,double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            
        }
        public double Pol( Pole x)
        {
            return ((x.a + x.b) / 2) * x.h;
        }
        

    }
    class Program
    {
          public int[][] Date(int[,] a)
        {
            int[][] y = new int[a.GetLength(0)][];
            int licznik = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != 0)
                    {
                        licznik++;

                    }

                }
                y[i] = new int[licznik];
                licznik = 0;
            }

            return y;
        }

        static void Main(string[] args)
        {

            Pole x = new Pole(4, 6, 2);
            Console.WriteLine("pole trapezu = "+ x.Pol(x));

            int[,] a = new int[2,2];
            
            Console.Read();
            
        }
    }
}
