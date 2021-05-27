using System;

namespace exercicio_2.Classes
{
    public class JogadorDefesa : Jogador
    {
        public void Defesa(){
            
            this.idade =  DateTime.Now.Year - this.DataDeNascimento;
            Console.WriteLine($"\nVocê tem a idade de {this.idade} anos");
            Console.WriteLine($"Geralmente os jogadores que jogam na posição DEFESA se aposentam com 40 anos ");

            if (idade > 40)
            {
                Console.WriteLine($"Voce ja pode se aposentar !!");
                
            }else
            {
                Console.WriteLine($"Falta {40 - idade} anos pra você se aposentar");
                
            }

        }
    }
}