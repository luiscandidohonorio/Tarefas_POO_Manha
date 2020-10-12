using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPOO_12102020
{
 class Program {
        static void Main(string[] args) {     
        //Criando a variável de entrada
        int n = int.Parse(Console.ReadLine());
        //Criando vetor com o número da variável de entrada 
        double[] vect= new double[n];
        //Utilização do comando for para percorrer o vetor
        for (int i  = 0; i < n; i++) 
            {
            //Entrada dos elementos no vetor pelo usuário
            vect[ i ] = double.Parse(Console.ReadLine()), CultureInfo.InvariantCulture); 
            }
    //Variável soma       
    double sum = 0.0;
    //Utilização do for para percorrer o vetor
    for (int i = 0; i < n; i ++) {
        //Somatoriados elementos inseridos 
        sum += vect[ i ];    
        }

        }
}
