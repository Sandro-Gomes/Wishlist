using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wishlist
{
    internal class ListaDeProdutos
    {
        public List<Produto> Produtos { get; private set; } 
        public ListaDeProdutos()
        {
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(new Produto(produto.Descricao, produto.ValorMin, produto.ValorMax));
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }
        public void AlterarProduto(Produto produto)
        {
            
        }
    }
}
