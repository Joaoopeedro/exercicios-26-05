using System;
using exercicio_3.Classes;

namespace exercicio_3
{
    class Program : MaquinaCafe
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            // bool incorreta = false;
            do
            {
                Console.WriteLine($@"
            
Olá seja bem vindo ao painel da nova Super Cafeteira Tabajaras Plus++ 
A quantidade de açucar disponivel na maquina esta em {m.AcucarDisponivel}

1- Fazer café com açucar
2- Fazer café sem açucar
");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        m.Fazercafe(1);

                        break;
                    case 2:
                        m.Fazercafe("sem açucar");

                        break;
                    default:
                        Console.WriteLine("Opção invalida!!!");
                        break;
                }


            } while (m.AcucarDisponivel > 0);


            int opcao2;
            do
            {



                Console.WriteLine($@"
             
A quantidade de açucar disponivel na maquina esta em {m.AcucarDisponivel}
No Momento a maquina esta sem açucar, so conseguira fazer cafe sem açucar!!!

1- Fazer café sem açucar
2- sair do sistema
");
                opcao2 = int.Parse(Console.ReadLine());
                switch (opcao2)
                {
                    case 1:
                        m.Fazercafe("sem açucar");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Obridado por usar nosso sistema ! até mais !");
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!!");
                        break;
                }
                
            } while (opcao2 !=2 );


        }
    }
}

