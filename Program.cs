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
                Console.WriteLine("Menu simples:");
                Console.WriteLine();
                Console.WriteLine("[1] - Novo produto na lista");
                Console.WriteLine("[2] - Exibir lista");
                Console.WriteLine("[3] - Finalizar programa");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                char opc = char.Parse(Console.ReadLine());
                if (opc == '1')
                {
                    Produto produto = controller.MenuCadastrarProduto();
                    if (produto != null)
                    {
                        lista.AdicionarProduto(produto);
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
                    Console.ReadLine();
                }
            }
            
        }
        static void MenuCadastar()
        {
            Console.WriteLine();
        }


    }
}