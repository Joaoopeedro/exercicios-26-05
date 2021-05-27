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
                        int quantidade;
                        do
                        {


                            Console.WriteLine($@"
DESEJA INFORMAR A QUANTIDADE DE AÇUCAR?

1- SIM
2- NÂO
");
                            quantidade = int.Parse(Console.ReadLine());
                            int quantAcucar;

                            switch (quantidade)
                            {
                                case 1:
                                    Console.WriteLine("Quanto de açucar você deseja colocar??");
                                    quantAcucar = int.Parse(Console.ReadLine());
                                    if (quantAcucar < m.AcucarDisponivel)
                                    {

                                        m.Fazercafe(quantAcucar);
                                    }
                                    else if (quantAcucar > m.AcucarDisponivel)
                                    {
                                        Console.WriteLine("Quantidade de açucar indisponivel");
                                    }
                                    else if (quantAcucar == m.AcucarDisponivel)
                                    {
                                        Console.WriteLine($"Aqui esta seu cafe com a quantidade de {quantAcucar}g de açucar! APROVEITE");
                                        Console.WriteLine("A Quantidade de açucar disponivel esta 0");
                                    }
                                    else if (m.AcucarDisponivel <= 0)
                                    {
                                        Console.WriteLine($"O açucar Disponivel da maquina acabou!! ");
                                    }
                                    break;
                                case 2:
                                    if (m.acucar < m.AcucarDisponivel)
                                    {
                                        Console.WriteLine($"Aqui esta seu cafe com a quantidade de {m.acucar}g de açucar que vem como padrao! APROVEITE!");
                                        m.AcucarDisponivel = m.AcucarDisponivel - m.acucar;
                                    }else
                                    {
                                        Console.WriteLine($"O açucar esta acabando e esta menos doque vem de padrão, se quiser mais açucar tem ao lado da maquina!! ");
                                        Console.WriteLine($"Aqui esta seu cafe com a quantidade de {m.AcucarDisponivel}g de açucar ! APROVEITE!");
                                        m.AcucarDisponivel = m.AcucarDisponivel - m.AcucarDisponivel;
                                        
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Opção invalida!!");

                                    break;
                            }
                        } while (quantidade != 1 && quantidade != 2);


                        break;
                    case 2:
                        m.Fazercafe();

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
             
A quantidade de açucar disponivel na maquina esta em 0
No Momento a maquina esta sem açucar, so conseguira fazer cafe sem açucar!!!

1- Fazer café sem açucar
2- sair do sistema
");
                opcao2 = int.Parse(Console.ReadLine());
                switch (opcao2)
                {
                    case 1:
                        m.Fazercafe();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Obridado por usar nosso sistema ! até mais !");
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!!");
                        break;
                }

            } while (opcao2 != 2);


        }
    }
}

