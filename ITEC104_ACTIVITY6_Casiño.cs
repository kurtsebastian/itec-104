using System;
using System.Collections.Generic;

class hash
{

    // Main Method
    static public void Main()
    {

        HashSet<int> hashset1 = new HashSet<int>();

        Console.WriteLine("====HashSet 1====");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Element " + i + ": ");
            hashset1.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        HashSet<int> hashset2 = new HashSet<int>();
        Console.WriteLine();

        Console.WriteLine("====HashSet 2====");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Element " + i + ": ");
            hashset2.Add(Convert.ToInt32(Console.ReadLine()));
        }


        Console.WriteLine();
        Console.WriteLine();
       

        HashSet<int> union = new HashSet<int>(hashset1);
        union.UnionWith(hashset2);

        Console.Write("UNION: ");
        foreach (int i in union)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();



        HashSet<int> intersect = new HashSet<int>(hashset1);
        intersect.IntersectWith(hashset2);
       

        Console.Write("INTERSECTION: ");
        foreach (int i in intersect)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();


        HashSet<int> except = new HashSet<int>(hashset1);
        except.ExceptWith(hashset2);
        

        Console.Write("SET DIFFERENCE: ");
        foreach (int i in except)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

    }

  
    
