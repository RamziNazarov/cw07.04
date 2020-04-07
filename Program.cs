using System;

namespace cw07._04
{
    class Program
    {
        static void Par (int x,params int[] array)
        {
            for(int i = 0; i < array.Length; i ++)
            {
                array[i] = array[i] + x;
                System.Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,6,7,8,9,0,2,4,123};
            Par(1,2,4,5,67,8,9,9,4);
            System.Console.WriteLine("------------");
            Par(10,arr);
            System.Console.WriteLine("-------");
            Sum(1,2);
            Sum("1","2");
            // Sum(Console.ReadLine(),Console.ReadLine());
            Sum(2.3m,123.5m);
            int x = 10;
            System.Console.WriteLine(x);
            Summa(ref x,5);
            System.Console.WriteLine(x);
            Summa(ref x,2);
            System.Console.WriteLine(x);
            int c = 0;
            Summa1(out c);
            System.Console.WriteLine(c);
            Summmm(y:12,q:123,x:123);
            Console.ReadKey();
        }
        static void Summmm (int x, int y, int q)
        {

        }
        static int Summa1 (out int x)
        {
            x = 10;
            return 1;
        }
        static int Summa (ref int x, int y)
        {
            int c = 0;
            x= x -y;
            c = x + y;
            return c;
        }

        static decimal Sum(decimal x, decimal y)
        {
            System.Console.WriteLine(x+y);
            return x+y;
        }
        static void Sum (int x, int y)
        {
            System.Console.WriteLine(x+y);
        }
        static void Sum (string x,string y)
        {
            System.Console.WriteLine(int.Parse(x) + int.Parse(y));
        }
    }
}
