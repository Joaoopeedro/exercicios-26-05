using System;

namespace exercicio__1.Classes
{
    public class ElevadorSocial : Elevador
    {
        public int NumPessoas()
        {
            int numeroPe;
            string adcionar;
            do
            {


                Elevador e = new Elevador();
                Console.WriteLine("Quantas pessoas tem no elevador??");
                numeroPe = int.Parse(Console.ReadLine());
                if (numeroPe > 6)
                {
                    e.Sair();
                    
                }
                if (numeroPe < 6)
                {
                    Console.WriteLine("Esta sobrando espaço, deseja adcionar mais alguma pessoa?(s/n)");
                    adcionar = Console.ReadLine().ToLower();
                    if (adcionar == "s")
                    {
                       e.Entrar(); 
                    }

                }
            } while (numeroPe > 6 );

            return numeroPe;
            
        }


    }
}