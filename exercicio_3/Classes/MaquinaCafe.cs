using System;

namespace exercicio_3.Classes
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel = 100;
        public int acucar = 10;

        public void Fazercafe(int quantAcucar)
        {
            Console.WriteLine($"Aqui esta seu cafe com a quantidade de {quantAcucar}g de açucar! APROVEITE");
            AcucarDisponivel = AcucarDisponivel - quantAcucar;

        }
        public void Fazercafe()
        {
            Console.WriteLine("\nSeu café foi feito, sem açucar! APROVEITE!");
        }
    }
}