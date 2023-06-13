using System.Runtime.CompilerServices;

namespace Wishlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            ListaDeProdutos lista = new ListaDeProdutos();
            bool exec = true;
            while (exec)
            {
                
                Console.Clear();
                Console.WriteLine("Wishlist Personalizada:");
                Console.WriteLine();
                Console.WriteLine("[1] - Novo produto na lista");
                Console.WriteLine("[2] - Exibir lista");
                Console.WriteLine("[3] - Finalizar programa");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                char opc = char.Parse(Console.ReadLine());
                if (opc == '1')
                {
                    bool exec1 = true;
                    while (exec1)
                    {
                        Produto produto = controller.MenuCadastrarProduto();
                        if (produto != null)
                        {
                            lista.AdicionarProduto(produto);
                            exec1 = controller.CadastrarOutroProduto();
                        }
                    }
                }
                else if (opc == '2')
                {
                    controller.MenuExibirLista(lista.Produtos);
                }
                else if (opc == '3')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA!");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                }
            }   
        }
    }
}