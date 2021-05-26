using System;

namespace exercicio__1.Classes
{
    public class Elevador : ElevadorServico
    {
        private int AndarAtual = 0;

        private int NumAndares = 6;

        public int Capacidade = 300;

        public int NumPessoas;

        public void inicializada(){
            Console.WriteLine($"\nLembre-se que o predio tem 6 andares e você sempre começara do Terreo!");
            Console.WriteLine($"\nA capacidade dos elevadores sao de {Capacidade} KG");
            
        }

        public void Subir()
        {
            int andar;
            do
            {


                Console.WriteLine("Qual andar você deseja ir ??");
                andar = int.Parse(Console.ReadLine());
                if (andar >= 0 && andar <= 6)
                {
                    
                    Console.WriteLine($"O elevador esta subindo para o { andar}° andar ");
                    AndarAtual = andar;

                }
                else
                {
                    Console.WriteLine($"Numero de andar não existe!");

                }
            } while (andar >6 );
        }
        public void Descer()
        { 
            int andar;
           do
            {
                Console.WriteLine("Qual andar você deseja ir ??");
                andar = int.Parse(Console.ReadLine());
                if (andar >= 0 && andar <= 6)
                {
                    
                    Console.WriteLine($"O elevador esta descendo para o { andar}° andar ");
                    AndarAtual =  andar;

                }
                else
                {
                    Console.WriteLine($"Numero de andar não existe!");

                }
            } while (andar <0 );


        }

        public void Sair(){
            Console.WriteLine("Tem muita pessoa no elevador, pra segurança de vocês reduza o numero de pessoas!");
        }
        public void Entrar(){
            Console.WriteLine("Adcione mais uma pessoa! O limite Maximo é de 6 Pessoas");

        }
    }
}