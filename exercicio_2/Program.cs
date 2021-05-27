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

            string posicao;
            do
            {


                Console.WriteLine($@"
QUAL POSIÇÃO VOCEÊ JOGA??

a- ATACANTE
d- DEFESA
m- MEIO CAMPO
");
                posicao = Console.ReadLine().ToLower();

                switch (posicao)
                {
                    case "a":
                        JogadorAtaque ja = new JogadorAtaque();
                        ja.nome = nome;
                        Console.WriteLine($"\nO nome do jogador é {ja.nome}");
                        ja.DataDeNascimento = DataDeNascimento;
                        Console.WriteLine($"O ano de nascimento do jogador é {ja.DataDeNascimento}");
                        ja.nascionalidade = nascionalidade;
                        Console.WriteLine($"A nascionalidade do jogador é {ja.nascionalidade}");
                        ja.altura = altura;
                        Console.WriteLine($"A altura do jogador é de {ja.altura} m");
                        ja.peso = peso;
                        Console.WriteLine($"O peso do jogador(a) é de {ja.peso} KG");
                        ja.Atacante();

                        break;
                    case "d":
                        JogadorDefesa jd = new JogadorDefesa();
                        jd.nome = nome;
                        Console.WriteLine($"\nO nome do jogador é {jd.nome}");
                        jd.DataDeNascimento = DataDeNascimento;
                        Console.WriteLine($"O ano de nascimento do jogador é {jd.DataDeNascimento}");
                        jd.nascionalidade = nascionalidade;
                        Console.WriteLine($"A nascionalidade do jogador é {jd.nascionalidade}");
                        jd.altura = altura;
                        Console.WriteLine($"A altura do jogador é de {jd.altura} m");
                        jd.peso = peso;
                        Console.WriteLine($"O peso do jogador(a) é de {jd.peso} KG");
                        jd.Defesa();
                        break;
                    case "m":
                        JogadorMeioCampo jm = new JogadorMeioCampo();
                        jm.nome = nome;
                        Console.WriteLine($"\nO nome do jogador é {jm.nome}");
                        jm.DataDeNascimento = DataDeNascimento;
                        Console.WriteLine($"O ano de nascimento do jogador é {jm.DataDeNascimento}");
                        jm.nascionalidade = nascionalidade;
                        Console.WriteLine($"A nascionalidade do jogador é {jm.nascionalidade}");
                        jm.altura = altura;
                        Console.WriteLine($"A altura do jogador é de {jm.altura} m");
                        jm.peso = peso;
                        Console.WriteLine($"O peso do jogador(a) é de {jm.peso} KG");
                        jm.MeioCampo();
                        break;
                    default:
                        Console.WriteLine("\nOpção invalida");
                        break;

                }
            } while (posicao != "a" && posicao != "d" && posicao != "m");




        }
    }
}
