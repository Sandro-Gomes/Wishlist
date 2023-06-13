using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wishlist
{
    internal class Controller
    {
        public Controller() { }

        public Produto MenuCadastrarProduto()
        {
            bool exec = true;
            while (exec)
            {
                Console.Clear();
                Console.WriteLine("(=====||Cadastro de Item||=====) ");
                Console.WriteLine();
                Console.Write("Digite a Descrição do item: ");
                string descricao = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("(=====||Cadastro de Item||=====) ");
                Console.WriteLine();
                Console.Write("Digite o valor MÍNIMO que deseja gastar: ");
                double valorMin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                double valorMax = 0; //Verificação de contradição (valorMin >= valorMax)
                while (valorMax == 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Digite o valor MÁXIMO que deseja gastar: ");
                    valorMax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (valorMax < valorMin)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Valor máximo deve ser maior ou igual ao valor mínimo!");
                        Console.WriteLine("Aperte qualquer tecla para corrigir o valor");
                        Console.ReadLine();
                        valorMax = 0;
                    }
                }
                Console.Clear();

                Produto produto = new Produto(descricao, valorMin, valorMax);

                Console.Clear();
                Console.WriteLine("(=====||Cadastro de Item||=====) ");
                Console.WriteLine();
                Console.WriteLine("Produto: " + produto);
                Console.WriteLine();
                Console.Write("Deseja alterar? (s/n): ");
                char opc = char.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opc == 'n' || opc == 'N')
                {
                    Console.Clear() ;
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    exec = false;
                    return produto;
                }
                else if (opc == 's' || opc == 'S')
                {                   
                }
                else
                {
                    Console.WriteLine("Opção inválida digitada...");
                    Console.WriteLine();
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    exec = false;
                    return produto;

                }
            }
            return null;

        }

        public Produto MenuAlterarProduto(Produto produto)
        {
            Console.Clear();
            Console.WriteLine("(=====||Alteração de Produto||=====) ");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO ATUAL: " + produto.Descricao);
            Console.WriteLine();
            Console.Write("Digite a nova descrição do item: ");
            string descricao = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("(=====||Alteração de Produto||=====) ");
            Console.WriteLine();
            Console.WriteLine("VALOR MINIMO ATUAL: " + produto.ValorMin.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Alterar Valor Mínimo? (s/n): ");
            char opc = char.Parse(Console.ReadLine());

            double valorMin = 0;
            if (opc == 's' || opc == 'S')
            {
                Console.Write("Digite o novo valor MÍNIMO: ");
                valorMin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                valorMin = produto.ValorMin;
            }
            Console.WriteLine();
            Console.WriteLine("VALOR MAXIMO ATUAL: " + produto.ValorMax.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Alterar Valor Máximo? (s/n): ");
            opc = char.Parse(Console.ReadLine());
            double valorMax = 0;
            if (opc == 's' || opc == 'S')
            {
                Console.Write("Digite o novo valor MÁXIMO: ");
                valorMax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                valorMax = produto.ValorMax;
            }
            Console.Clear();

            produto = new Produto(descricao, valorMin, valorMax);

            Console.Clear();
            Console.WriteLine("(=====||Alteração de Produto||=====) ");
            Console.WriteLine();
            Console.WriteLine(produto);
            Console.WriteLine();
            Console.WriteLine("Produto cadastrado com sucesso!");
            return produto;
        }
        public void MenuExibirLista(List<Produto> lista)
        {
            bool exec = true;
            while (exec)
            {
                Console.Clear();
                Console.WriteLine("(=====|| Exibição da WishList ||=====)");
                Console.WriteLine();
                int i = 0;
                foreach (Produto produtos in lista)
                {
                    i++;
                    Console.Write(i + " - ");
                    Console.WriteLine(produtos);
                }
                Console.WriteLine();
                Console.Write("Deseja alterar um produto? (s/n) ");
                char opc = char.Parse(Console.ReadLine());
                if (opc == 's' || opc == 'S')
                {
                    Console.WriteLine();
                    Console.Write("Escolha o código do produto que deseja alterar: ");
                    int indice = int.Parse(Console.ReadLine());
                    Produto produto = lista[i - 1];
                    produto = MenuAlterarProduto(produto);
                    lista[i - 1] = produto;
                }
                else
                {
                    exec = false;
                }
            }
        }

        public bool CadastrarOutroProduto()
        {
            Console.WriteLine();
            Console.Write("Deseja adicionar um novo produto? (s/n) ");
            char opc = char.Parse(Console.ReadLine());
            Console.WriteLine();
            if (opc == 's' || opc == 'S')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Retornando ao Menu Inicial");
                Console.ReadLine();
                return false;
            }

        }
    }

}


