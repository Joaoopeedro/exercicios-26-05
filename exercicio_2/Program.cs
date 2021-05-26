using System;
using exercicio_2.Classes;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual seu nome ??");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual seu ano de nascimento??");
            int DataDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua nascionalidade ??");
            string nascionalidade = Console.ReadLine();
            Console.WriteLine("Qual sua altura??");
            double altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu peso??");
            double peso = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual posição vc joga??");
            string posicao = Console.ReadLine();

            switch (posicao)
            {
                case "a":
                JogadorAtaque ja = new JogadorAtaque();
                ja.nome = nome;
                Console.WriteLine($"O nome do jogador é {ja.nome}");
                ja.DataDeNascimento = DataDeNascimento;
                Console.WriteLine($"A data de nascimento do jogador é {ja.DataDeNascimento}");
                ja.nascionalidade = nascionalidade;
                Console.WriteLine($"A nascionalidade do jogador é {ja.nascionalidade}");
                ja.altura = altura;
                Console.WriteLine($"A altura do jogador é de {ja.altura}");

                    break;


                default:
                    break;
            }
            



        }
    }
}
