using System;
using System.Collections.Generic;



namespace ISORENA_ACT6_PT2_ITEC104
{
    internal class Program
    {

        
        public static void Main(string[] args) 
        {
            Console.WriteLine("===HashSet1===");
            Hash(out HashSet<int> Hashset1); 

            Console.WriteLine("\n===HashSet2===");
            Hash(out HashSet<int> Hashset2); 

           
            Console.WriteLine($"\nUNION: {string.Join(" ", Hashset1.Union(Hashset2).ToArray())}");

            Console.WriteLine($"\nINTERSECTION: {string.Join(" ", Hashset1.Intersect(Hashset2).ToArray())}");

            Console.WriteLine($"\nSET DIFFERENCE: {string.Join(" ", Hashset1.Except(Hashset2).ToArray())}"); 

            Console.ReadLine();
        }

   
        public static void Hash(out HashSet<int> HashSets)
        {
            HashSets = new HashSet<int>(); 
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Element {i + 0} : "); 
               
                HashSets.Add(int.Parse(Console.ReadLine()));
      
            }
        }
    }
}
