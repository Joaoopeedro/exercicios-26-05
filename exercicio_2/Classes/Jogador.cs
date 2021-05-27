using System;

namespace exercicio_2.Classes
{
    public class Jogador
    {
        public int idade;

        public string nascionalidade;
        public string nome;
        public int DataDeNascimento;
        public double altura;
        public double peso;

        public void MostrarDados(string nome, int DataDeNascimento, string nascionalidade, double altura, double peso){
            Console.WriteLine($"\nO nome do jogador é {nome}");
            Console.WriteLine($"O ano de nascimento do jogador é {DataDeNascimento}");
            Console.WriteLine($"A nascionalidade do jogador é {nascionalidade}");
            Console.WriteLine($"A altura do jogador é de {altura} m");
            Console.WriteLine($"O peso do jogador(a) é de {peso} KG");
        }


    }
}