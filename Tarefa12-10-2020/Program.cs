using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa12_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Produto p = new Produto(“PS5”, 6000.00, 10);
                p.nome = “XBOX X”;
                p.SetNome(“XBOX X”);
                p.SetPreco (5000.00); Não consigo inserir tais informações para segurança
                p._preco = 5000.00;
                Console.WriteLine(p.GetNome());
                Console.WriteLine(p.GetPreco());
            
        }
    }
   

