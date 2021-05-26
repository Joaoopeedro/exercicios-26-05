using System;

namespace exercicio__1.Classes
{
    public class ElevadorServico
    {
        public int QuanatidadeCaixa;
        public int AlterarCaixa()
        {
            int quantidade;
            do
            {


                Console.WriteLine("Quantas caixas ira no elevador??");
                quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nO numero de caixas é de {quantidade} caixas ");
                if (quantidade > 4)
                {
                    Console.WriteLine("Você devera reduzir o numero de carga  , ULTRAPASSOU A CAPACIDADE !!");

                }
                return quantidade;
            } while (quantidade > 4);
        }
    }
}