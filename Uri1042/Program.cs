using System;

namespace Uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor  =0, meio=0 , maior=0 ;

            string[] vet = Console.ReadLine().Split(' ');


            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            if(a < b && a < c)
            {
                menor = a;
                if (b < c )
                {
                    meio = b;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = b;
                }
            }

            if(b>a && b > c)
            {
                maior = b;
                if (c > a)
                {
                    meio = c;
                    menor = a;
                }
                else
                {
                    meio = a;
                    menor = c;
                }
            }

            if(c>a && c > b)
            {
                maior = c;
                if (a < b)
                {
                    meio = b;
                    menor = a;
                }
                else
                {
                    meio = a;
                    menor = b;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);

            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);





        }
    }
}
