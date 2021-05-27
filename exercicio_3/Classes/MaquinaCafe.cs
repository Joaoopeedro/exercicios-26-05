using System;

namespace exercicio_3.Classes
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel = 100;
        public int acucar = 10;

        public void Fazercafe(int AcucarPadrao)
        {
            int quantidade;
            do
            {


                Console.WriteLine($@"
DESEJA INFORMAR A QUANTIDADE DE AÇUCAR?

1- SIM
2- NÂO
");
                quantidade = int.Parse(Console.ReadLine());
                int quantAcucar;

                switch (quantidade)
                {
                    case 1:
                        Console.WriteLine("Quanto de açucar você deseja colocar??");
                        quantAcucar = int.Parse(Console.ReadLine());
                        if (quantAcucar < AcucarDisponivel)
                        {

                            Console.WriteLine($"Aqui esta seu cafe com a quantidade de {quantAcucar}g de açucar! APROVEITE");
                            AcucarDisponivel = AcucarDisponivel - quantAcucar;
                        }
                        else if (quantAcucar > AcucarDisponivel)
                        {
                            Console.WriteLine("Quantidade de açucar indisponivel");
                        }
                        else if (quantAcucar == AcucarDisponivel )
                        {
                            Console.WriteLine($"Aqui esta seu cafe com a quantidade de {quantAcucar}g de açucar! APROVEITE");
                            Console.WriteLine("A Quantidade de açucar disponivel esta 0");
                            AcucarDisponivel = 0;
                            
                        }
                        else if (AcucarDisponivel <= 0)
                        {
                            Console.WriteLine($"O açucar Disponivel da maquina acabou!! ");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Aqui esta seu cafe com a quantidade de {acucar}g de açucar que vem como padrao! APROVEITE!");
                        AcucarDisponivel = AcucarDisponivel - acucar;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!!");

                        break;
                }
            } while (quantidade != 1 && quantidade != 2);

        }
        public void Fazercafe(string SemAcucar){
            Console.WriteLine("\nSeu café foi feito, sem açucar! APROVEITE!");
        }
    }
}