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
                        ja.DataDeNascimento = DataDeNascimento;
                        ja.nascionalidade = nascionalidade;
                        ja.altura = altura;
                        ja.peso = peso;
                        ja.MostrarDados(ja.nome, ja.DataDeNascimento, ja.nascionalidade, ja.altura, ja.peso);
                        ja.Atacante();

                        break;
                    case "d":
                        JogadorDefesa jd = new JogadorDefesa();
                        jd.nome = nome;
                        jd.DataDeNascimento = DataDeNascimento;
                        jd.nascionalidade = nascionalidade;
                        jd.altura = altura;
                        jd.peso = peso;
                        jd.MostrarDados(jd.nome, jd.DataDeNascimento, jd.nascionalidade, jd.altura, jd.peso);
                        jd.Defesa();
                        break;
                    case "m":
                        JogadorMeioCampo jm = new JogadorMeioCampo();
                        jm.nome = nome;
                        jm.DataDeNascimento = DataDeNascimento;
                        jm.nascionalidade = nascionalidade;
                        jm.altura = altura;
                        jm.peso = peso;
                        jm.MostrarDados(jm.nome, jm.DataDeNascimento, jm.nascionalidade, jm.altura, jm.peso);
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
