using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produto
{
    //Declaração de variavéis
    private string_nome;
    private double_preco;
    private int_quantidade;
    //Construtor padrão
    public Produto ( ){
                    }
    //Construtor personalizado
    public Produto (stringnome, doublepreco, int quantidade){_
        nome = nome;
        _preco= preco;
        _quantidade = quantidade;
}
   //Utilização do GET e SET
    public stringGetNome() {
    return_nome;
}
   //Critérios de entrada de dados
    public voidSetNome(stringnome) {
    if(nome != null&& nome.Lenght> 1) {
        _nome = nome;
    }
}
    /* Retorno dos valores Preço do produto e Quantidade do produto sem interferência do usuário */
    public double GetPreco()
    {
        return _preco;
    }
    public double GetQuantidade()
    {
        return _preco;
    }