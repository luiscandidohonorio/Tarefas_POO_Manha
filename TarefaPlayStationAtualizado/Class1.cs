using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPlayStationAtualizado
public class Produto
{
	public string Nome;
	public double Preco;
	public int Quantidade;
	public double ValorTotalEmEstoque()
	{
		returnPreco* Quantidade;
	}
	public void AdicionarProduto(intquantidade)
	{
		Quantidade += quantidade;
	}
	public void RemoverProdutos(intquantidade)
	{
		Quantidade = Quantidade - quantidade;
	}
	public override string ToString()
	{
		return Nome
		+ ", R$ "
		+ Preco.ToString("F2", CultureInfo.InvariantCulture)
		+ ", "
		+ Quantidade
		+ " unidades, Total: R$ "
		+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
	}
}
	