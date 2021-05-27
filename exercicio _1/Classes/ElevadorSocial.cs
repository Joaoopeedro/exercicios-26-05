using System;

namespace exercicio__1.Classes
{
    public class ElevadorSocial : Elevador
    {
        public int NumPessoas()
        {
            string adcionar ="s";
            do
            {
                Console.WriteLine("Quantas pessoas tem no elevador??");
                this.NumPessoas2 = int.Parse(Console.ReadLine());
                if (this.NumPessoas2 > 8)
                {
                    this.Sair();

                }
                if (this.NumPessoas2 < 7)
                {
                    Console.WriteLine("Esta sobrando espaço, deseja adcionar mais alguma pessoa?(s/n)");
                    adcionar = Console.ReadLine().ToLower();
                    if (adcionar == "s")
                    {
                        this.Entrar();
                    }
                    else
                    {
                        Console.WriteLine("ok");
                        adcionar = "n";
                    }
                }
            } while (adcionar == "s") ;
            return this.NumPessoas2;
        }

    
    }
}

