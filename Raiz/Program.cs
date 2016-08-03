using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiz
{
    class Program
    {
        public static int numeroEscolhido;
        static void Main(string[] args)
        {
        
          numeroEscolhido = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroEscolhido; i +=2)
                {
                    numeroEscolhido -= i;
                }

            if (numeroEscolhido <= 0)
                {
                    Console.WriteLine("É raiz perfeita!");
                   //Console.WriteLine(numeroEscolhido);
                    Console.ReadKey();
                }
            else
                {
                    Console.WriteLine("A raiz não é perfeita!");
                    Console.ReadKey();
                }
        }
    }
}
