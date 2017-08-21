using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfMaiorQue10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 10)
            {
                Console.Write("Seu número é maior que 10.");
            }
            Console.ReadLine();
        }
    }
}
