using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite o " + i + 1 + " número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números nas posições pares (índices 0, 2, 4...): ");
            for (int i = 0; i < 15; i += 2)
            {
                Console.WriteLine("Posição " + [i] + " : " vetor[i]);
            }
        }
    }
}
