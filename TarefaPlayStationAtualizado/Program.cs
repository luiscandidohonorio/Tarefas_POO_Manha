using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPlayStationAtualizado
public class Program
{
	static void Main(string[] arg)
	{
		Produto p = new Produto();
		Console.WriteLine("Entre com os dados do produto;");
		Console.Write("Nome: ");
		p.Nome = Console.ReadLine();
		Console.Write("Preço: ");
		p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		Console.Write("Quantidade no estoque: ");
		p.Quantidade = int.Parse(Console.ReadLine());
		Console.WriteLine("Dados do produto: " + p);
		Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
		int qte = int.Parse(Console.ReadLine());
		p.AdicionarProdutos(qte);
		Console.WriteLine("Dados do atualizados: " + p);
		Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
		qte = int.Parse(Console.ReadLine());
		p.RemoverProdutos(qte);
		Console.WriteLine("Dados do atualizados: " + p);
	}
