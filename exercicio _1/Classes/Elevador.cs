using System;

namespace exercicio__1.Classes
{
    public class Elevador
    {
        private int AndarAtual = 0;

        private int NumAndares = 6;

        private int Capacidade = 300;

        public int NumPessoas;

        public void Subir()
        {
            int andar;
            do
            {


                Console.WriteLine("Qual andar você deseja ir ??");
                andar = int.Parse(Console.ReadLine());
                if (andar > 0 && andar <= 6)
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
                if (andar > 0 && andar <= 6)
                {
                    
                    Console.WriteLine($"O elevador esta subindo para o { andar}° andar ");
                    AndarAtual =  andar;

                }
                else
                {
                    Console.WriteLine($"Numero de andar não existe!");

                }
            } while (andar <0 );


        }
    }
}