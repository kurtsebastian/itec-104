using System;
namespace ACTS4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            int k, u = 0, r = 0, t;

            Console.Write("== ARRAY PROGRAM ==");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write
                ("ENTER NUMBER 5 :");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();


            for (k = 0; k < a.Length; k++)
            {
                Console.Write("ENTER ELEMENT [0] ", t);
                a[k] = Convert.ToInt32(Console.ReadLine());
            }
            for (k = 0; k < b.Length; k++)
            {
                if (a[k] % 2 == 0)
                {
                    b[u] = a[k];
                    u++;
                }
                else
                {
                    c[r] = a[k];
                    r++;
                }
            }
            Console.WriteLine();
            Console.Write("ODD NUMBERS :");
            for (k = 0; k < r; k++)
            {
                Console.Write("{0}", c[k]);
            }
            Console.WriteLine();
            Console.Write("EVEN NUMBERS :");
            for (k = 0; k < u; k++)
            {
                Console.Write("{0}", b[k]);

            }
            Console.Write("\n\n");



        }
    }
}
