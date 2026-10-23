using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];
            double[] precos = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nome do produto " + i + 1 ": ");
                nomes[i] = Console.ReadLine();
                Console.Write("Preço do produto " + i + 1 ": ");
                precos[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite um valor máximo para pesquisa: ");
            double limite = double.Parse(Console.ReadLine());

            Console.WriteLine("Produtos com preço até R$ " + limite ":");
            for (int i = 0; i < 10; i++)
            {
                if (precos[i] <= limite)

                    Console.WriteLine("-" nomes[i] ": R$" precos[i]);
            }
        }
    }
}
