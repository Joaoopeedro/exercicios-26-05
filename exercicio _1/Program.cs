using System;
using exercicio__1.Classes;

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
                    e.inicializada();
                    es.AlterarCaixa();
                    Console.WriteLine("");
                    do
                    {


                        Console.WriteLine($@"
OQUE VOCÊ DESEJA FAZER??

1- SUBIR
2- DESCER 
");
                        andar = int.Parse(Console.ReadLine());

                        if (andar == 1)
                        {
                            e.Descer();
                        }
                        else
                        {
                            e.Descer();
                            // Console.WriteLine("Este é o primeiro andar você nao consgue descer mais que isso!!");
                        }
                    } while (andar != 2);

                }
                if (elevador == 2)
                {
                    Console.WriteLine("\nVOCÊ ESTA USANDO O ELEVADOR SOCIAL");
                    e.inicializada();
                    eo.NumPessoas();
                    do
                    {


                        Console.WriteLine($@"
OQUE VOCÊ DESEJA FAZER??

1- SUBIR
2- DESCER 
");
                        andar2 = int.Parse(Console.ReadLine());

                        if (andar2 == 1)
                        {
                            e.Subir();
                        }
                        else if(andar2 == 2)
                        {
                            e.Descer();
                        }

                    } while (andar2 == 3);
                }
                if (elevador == 3)
                {
                    Console.WriteLine("Obrigado por utilizar nosso elevadores!!!");
                }
                else
                {
                    Console.WriteLine("\nOPÇÃO INVALIDA");
                }
            } while (elevador != 1 && elevador != 2 && elevador != 3);


        }
    }
}
