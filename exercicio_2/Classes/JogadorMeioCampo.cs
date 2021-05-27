using System;

namespace exercicio_2.Classes
{
    public class JogadorMeioCampo : Jogador
    {
       public void MeioCampo(){
            
            this.idade =  DateTime.Now.Year - this.DataDeNascimento;
            Console.WriteLine($"\nVocê tem a idade de {this.idade} anos");
            Console.WriteLine($"Geralmente os jogadores que jogam na posição MEIO CAMPO se aposentam com 38 anos ");

            if (idade > 38)
            {
                Console.WriteLine($"Voce ja pode se aposentar !!");
                
            }else
            {
                Console.WriteLine($"Falta {38 - idade} anos pra você se aposentar");
                
            }

        } 
    }
}