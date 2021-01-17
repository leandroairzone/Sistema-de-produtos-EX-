using System;

namespace Sistema_de_Produtos_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis 
            int escolha; 
            int contador = 0;
            int i = 0;
            string resposta;
            string [] nomes = new string [10];
            float [] preco = new float [10];
           

            //Inicio do Programa 
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----Sistema de Produtos------");
            Console.WriteLine("------------------------------");


            do
            {
                MostrarMenu();

                switch (escolha)
                {
                    case 1:
                    CadastrarProduto();
                        break;
                        
                    case 2:
                    listarProdutos();
                        break;

                    case 3:
                    Console.WriteLine("Finalizando...........");
                        break;

                    default:
                    Console.WriteLine("Opção Inválida");
                        break;
                }
                
            } while (escolha != 3);
            //Fim do Programa 


            //Função Mostrar Menu
            
            int MostrarMenu (){
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1 - Cadastrar Produtos");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                escolha = int.Parse(Console.ReadLine());

                return escolha; 
            }

             
            //Função Cadastrar Produto
            void CadastrarProduto(){
                Console.WriteLine("Cadastrar Produto");
                do{

                if(contador < 10){
                Console.WriteLine($"Digite o nome do {contador+1}º Produto: ");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine($"Digite o preço do {contador+1}º Produto");
                preco[contador] = int.Parse(Console.ReadLine());

                contador++;
                }else{
                    Console.WriteLine("Você atingiu o limite de 10 produtos cadastrados");
                }
                Console.WriteLine("Você gostaria de cadastrar um novo Produto? S/N");
                resposta = Console.ReadLine();
                }while(resposta.ToUpper() == "s");
                Console.Clear();
            }

            //Função Listar Produtos

            void listarProdutos(){
                for (i = 0; i < contador; i++)
                {
                    Console.WriteLine($"Nome do Produto: {nomes[i]}, Preço do Produto: {preco[i]}");
                    Promocao();
                }
            }
            
            //Função Validar Promoção 
            bool Promocao(){

                if(preco[i] > 10){
                    Console.WriteLine("Produto em promoção");
                    return true;
                }else{
                    Console.WriteLine("Nenhuma promoção disponível no momento");
                    return false;
                }
            }
        }
    }
}
