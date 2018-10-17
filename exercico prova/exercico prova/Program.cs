using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_prova
{
    class Program
    {
        
        static int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        static int Maior2(int a, int b)
        {
            return (a > b) ? a : b;
        }



        static bool Par(int numero)
        {
            
            int resto = numero % 2;
            if (resto == 0)
                return true;
            else
                return false;
        }

        static string Par2(int numero)
        {
            
            int resto = numero % 2;
            if (resto == 0)
                return "par";
            else
                return "impar";

        }


        static void Main(string[] args)
        {
            Console.WriteLine(Maior(1, 2));
            Console.WriteLine(Maior2(3, 4));
            Console.ReadKey();

        }


    }
}
