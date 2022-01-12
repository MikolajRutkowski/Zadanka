using System;
using System.Numerics;
namespace Zadanka
{
    class Program
    {

       static public bool EvenNumber(int x)// is it a Even Number ? Done 
        {
            x =  Math.Abs(x);
            bool even = false;
            
            for (int i = 0; i <= x; i++)
            {

                even = !even;
                
            }


            return even;
        }

        static public bool FirstNumber(int x) // is it a First Number ? // Done but not soo quick
        {
            
            if(x < 2) { return false; }

            for (int i = 2; i < x; i++)
            {
                if(x % i == 0) { return false; }
                
            }

            return true;
        }

        static public string Anagram(string x ) // make string from last to first //done
        {
            char[] tab = x.ToCharArray();
            char[] bat = x.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                tab[i] = bat[x.Length - i - 1];
            }
            string respon = new string(tab);
            return respon;
        }

        static void AllStringFromString(string x)
        {
            Console.WriteLine(x);
            for (int i = 0; i < x.Length; i++)
            {
                char[] n = x.ToCharArray(i,x.Length  -i);
                string res = new string(n);
                Console.WriteLine(res);
                char[] m =  x.ToCharArray(0, x.Length - 1 - i);
                string res2 = new string(m);
                Console.WriteLine(res2);
            }
            
        } //done

        static void Main(string[] args)
        {
            AllStringFromString("Witaj swiecie");
        }
    }
}
