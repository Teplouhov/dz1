using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dz2
{
    class Program
    {
        static bool comp(int [] a,int[] b) 
        {
            int cheker = 0;
            if (a.Length != b.Length) { return false; }
            if (a.Length==0||b.Length==0) { return false; }
            if (a.Sum()==0||b.Sum()==0) { return false; }
            
            for (int i = 0; i < a.Length; i++) 
            {
                for (int j = 0; j < b.Length; j++) 
                {
                    if (b[j] == a[i] * a[i])
                    {
                        cheker++;
                        b[j] = -1;
                    }
                    
                }
            }

            if (cheker == a.Length) { return true; }

            return false;
        }
        static void Main(string[] args)
        {
            int []a1={121, 144, 19, 161, 19, 144, 19, 11};
            int []b1 ={121, 14641, 20736, 361, 25921, 361, 20736, 361} ;

            int[] a2 = {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b2 = {132, 14641, 20736, 361, 25921, 361, 20736, 361};

            int[] a3 = {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b3 = { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };

            int[] a4 = new int[8];
            int[] b4 = new int[8];

            int[] a5 = {};
            int[] b5 = {};
           
            Console.WriteLine(comp(a1, b1));
            Console.WriteLine(comp(a2, b2));
            Console.WriteLine(comp(a3, b3));
            Console.WriteLine(comp(a4, b4));
            Console.WriteLine(comp(a5, b5));
        }
    }
}
