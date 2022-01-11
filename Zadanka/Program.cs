using System;

namespace Zadanka
{
    class Program
    {

       static public bool EvenNumber(int x)
        {
            bool even = true;
            bool old1 = true;
            bool old2 = false;
            for (int i = 0; i <= x; i++)
            {
               
                even = old1;
                old1 = old2;
                old2 = even;
            }


            return even;
        }

        static void Main(string[] args)
        {
            bool cos = EvenNumber(2);
            bool cos1 = EvenNumber(3);
            Console.WriteLine(cos);
            Console.WriteLine(cos1);
        }
    }
}
