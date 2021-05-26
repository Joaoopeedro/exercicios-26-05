using System;
namespace exercicio_2.Classes
{
    public class JogadorAtaque : Jogador
    {
        public void Atacante(){
            
            this.idade =  DateTime.Now.Year - this.DataDeNascimento;
            Console.WriteLine($"\nVocê tem a idade de {this.idade} anos");
            Console.WriteLine($"Geralmente os jogadores que jogam na posição ATACANTE se aposentam com 35 anos ");

            if (idade > 35)
            {
                Console.WriteLine($"Voce ja pode se aposentar !!");
                
            }else
            {
                Console.WriteLine($"Falta {35 - idade} anos pra você se aposentar");
                
            }

        }
    }
}