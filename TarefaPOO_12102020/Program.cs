using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPOO_12102020
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior = double.MinValue, menor = double.MaxValue;
            double mediaHomens = 0.0f, mediaMulheres = 0.0f;
            int contadorH = 0, contadorF = 0;
            int pessoasLength = 50;
            for (int i = 0; i < pessoasLength; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite o sexo da pessoa {0}:\n1 - Homem\n2 - Mulher", i + 1);
                int s = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a  altura da pessoa:");
                double altura = double.Parse(Console.ReadLine());
                if (altura > maior)
                {
                    maior = altura; // se for maior que a altura, pegue-a
                }
                if (altura < menor)
                {
                    menor = altura; // o mesmo para a menor
                }
                if (s == 1)
                {
                    // é homem
                    mediaHomens += altura;
                    contadorH++;
                }
                else
                {
                    // é mulher
                    mediaMulheres += altura;
                    contadorF++;
                }
            }
            // depois de ler as 50 pessoas...
            // calcular a média:
            mediaHomens /= contadorH;
            mediaMulheres /= contadorF; // divide por 50

            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("Maior altura: {0}", maior);
            Console.WriteLine("Menor altura: {0}", menor);
            Console.WriteLine("Média da altura masculina: {0}", mediaHomens);
            Console.WriteLine("Média da altura feminina: {0}", mediaMulheres);
            Console.ReadKey();
        }
    }
}
