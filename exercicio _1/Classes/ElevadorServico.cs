using System;

namespace exercicio__1.Classes
{
    public class ElevadorServico
    {
        public int QuanatidadeCaixa ;
        public int AlterarCaixa(){
            Console.WriteLine("Quantas caixas ira ir no elevador");
            int quantidade = int.Parse(Console.ReadLine());
            return quantidade;
        }
    }
}