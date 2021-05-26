using System;

namespace exercicio__1.Classes
{
    public class Elevador : ElevadorServico
    {
        private  int AndarAtual;

        private int NumAndares ;

        public int Capacidade{get; set;} 

        public int NumPessoas{get; set;}

        public void inicializada(){

            Console.WriteLine($"\nQuantos andares tem o predio?");
            NumAndares = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nLembre-se que o predio tem {NumAndares} andares e você sempre começara do Terreo!");
            Console.WriteLine("\nQual a capacidade maxima dos elevadores ??");
            Capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nA capacidade dos elevadores sao de {Capacidade} KG");
            
        }

        public void Subir()
        {
            int andar;
            do
            {
                Console.WriteLine("Qual andar você deseja ir ??");
                andar = int.Parse(Console.ReadLine());
                if (andar <= NumAndares && andar > AndarAtual)
                {         
                    Console.WriteLine($"O elevador esta subindo para o { andar}° andar ");
                    AndarAtual = andar;
                    
                }
                else
                {
                    Console.WriteLine($"\nNumero de andar não existe!");
                }
            } while (andar > AndarAtual );
        }
        public void Descer()
        { 
            int andar;
           do
            {
                Console.WriteLine("Qual andar você deseja ir ??");
                andar = int.Parse(Console.ReadLine());
                if (andar >= 0 && andar < AndarAtual)
                {
                    
                    Console.WriteLine($"O elevador esta descendo para o { andar}° andar ");
                    AndarAtual =  andar;

                }
                else
                {
                    Console.WriteLine($"Numero de andar não existe!");

                }
            } while (andar > AndarAtual );


        }

        public void Sair(){
            Console.WriteLine("Tem muita pessoa no elevador, pra segurança de vocês reduza o numero de pessoas!");
        }
        public void Entrar(){
            Console.WriteLine("Adcione mais uma pessoa! O limite Maximo é de 6 Pessoas");

        }
    }
}