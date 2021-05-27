using System;
using exercicio__1.Classes;
using System.Threading;

namespace exercicio__1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevadorServico es = new ElevadorServico();
            Elevador e = new Elevador();
            ElevadorSocial eo = new ElevadorSocial();
            int andar;
            int elevador;
            int andar2;
           



            Console.WriteLine("Olá seje bem vindo");
            e.inicializada();

            do
            {


                Console.WriteLine($@"
QUAL ELEVADOR VOCÊ DESEJA UTILIZAR??

1- ELEVADOR DE SERVIÇO
2- ELEVADOR SOCIAL
3- SAIR DO SISTEMA
");
                elevador = int.Parse(Console.ReadLine());

                if (elevador == 1)
                {
                    Console.WriteLine("\nVOCÊ ESTA USANDO O ELEVADOR DE SERVIÇO");

                    es.AlterarCaixa();
                    Console.WriteLine("");
                    do
                    {


                        Console.WriteLine($@"
OQUE VOCÊ DESEJA FAZER??

1- SUBIR
2- DESCER 
0- SAIR
");
                        andar = int.Parse(Console.ReadLine());

                        if (andar == 1)
                        {
                            e.Subir();
                        }
                        else if (andar == 2)
                        {
                            e.Descer();
                            // Console.WriteLine("Este é o primeiro andar você nao consgue descer mais que isso!!");
                        }
                        else
                        {
                            Console.WriteLine("Você saiu do elevador!");
                        }
                    } while (andar != 0);

                }
                else if (elevador == 2)
                {
                    Console.WriteLine("\nVOCÊ ESTA USANDO O ELEVADOR SOCIAL");

                    eo.NumPessoas();
                    do
                    {


                        Console.WriteLine($@"
OQUE VOCÊ DESEJA FAZER??

1- SUBIR
2- DESCER 
0- SAIR
");
                        andar2 = int.Parse(Console.ReadLine());

                        if (andar2 == 1)
                        {
                            e.Subir();
                            Console.WriteLine($@"
Alguem deseja sair??

1- sim
2- não");
                            int sairPessoa = int.Parse(Console.ReadLine());
                            if (sairPessoa == 1)
                            {
                                Console.WriteLine("Quantas pessoas vao sair ??");
                                int pessoas = int.Parse(Console.ReadLine());
                                if (pessoas > 0)
                                {
                                    Console.WriteLine($"O numero de pessoas que tem no elevadodor é de {eo.NumPessoas2 - pessoas} pessoas");
                                    eo.NumPessoas2 = eo.NumPessoas2 - pessoas;
                                    Console.WriteLine($@"
Alguem deseja entrar? 

1- sim
2- nao
");
                                    int entrarPessoa = int.Parse(Console.ReadLine());
                                    if (entrarPessoa == 1)
                                    {
                                        Console.WriteLine("Quantas pessoas vao entrar ??");
                                        int pessoa2 = int.Parse(Console.ReadLine());
                                        if (pessoa2 > 0)
                                        {
                                            Console.WriteLine($"O numero de pessoas que tem no elevadodor é de {eo.NumPessoas2 + pessoa2} pessoas");
                                            eo.NumPessoas2 = eo.NumPessoas2 + pessoa2;
                                            
                                        }
                                    }
                                    else if (entrarPessoa == 2)
                                    {
                                        Console.WriteLine("ok");
                                    }
                                }
                            }
                            else if (sairPessoa == 2)
                            {
                                Console.WriteLine("ok");
                            }
                        }
                        else if (andar2 == 2)
                        {
                            e.Descer();
                            Console.WriteLine($@"
Alguem deseja sair??

1- sim
2- não");
                            int sairPessoa = int.Parse(Console.ReadLine());
                            if (sairPessoa == 1)
                            {
                                Console.WriteLine("Quantas pessoas vao sair ??");
                                int pessoas = int.Parse(Console.ReadLine());
                                if (pessoas > 0)
                                {
                                    Console.WriteLine($"O numero de pessoas que tem no elevadodor é de {eo.NumPessoas2 - pessoas} pessoas");
                                    eo.NumPessoas2 = eo.NumPessoas2 - pessoas;
                                    Console.WriteLine($@"
Alguem deseja entrar? 

1- sim
2- nao
");
                                    int entrarPessoa = int.Parse(Console.ReadLine());
                                    if (entrarPessoa == 1)
                                    {
                                        Console.WriteLine("Quantas pessoas vao entrar ??");
                                        int pessoa2 = int.Parse(Console.ReadLine());
                                        if (pessoa2 > 0)
                                        {
                                            Console.WriteLine($"O numero de pessoas que tem no elevadodor é de {eo.NumPessoas2 + pessoa2} pessoas");
                                            eo.NumPessoas2 = eo.NumPessoas2 + pessoa2;
                                        }
                                    }
                                }
                            }
                            else if (sairPessoa == 2)
                            {
                                Console.WriteLine("ok");
                            }
                        }
                        else if (andar2 == 0)
                        {
                            Console.WriteLine("Você saiu do elevador!");
                        }

                    } while (andar2 != 0 );
                }
                else if (elevador == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Obrigado por utilizar nosso elevadores!!!");
                }
                else
                {
                    Console.WriteLine("\nOPÇÃO INVALIDA");
                }
            } while (elevador == 1 || elevador == 2 || elevador != 3);


        }
    }
}
