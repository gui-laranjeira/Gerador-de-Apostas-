
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gerador_de_apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("**Bem vindo ao gerador de apostas!** \n\nQual é o último número que você pode jogar nesta loteria?");
            string respostaRange = Console.ReadLine();
            bool convert1 = int.TryParse(respostaRange, out int range);      //a range de números que pode jogar (1 até 60, por exemplo)

            Console.WriteLine("\nQual a quantidade de números que você irá jogar?");
            string respostaQuantidade = Console.ReadLine();
            bool convert2 = int.TryParse(respostaQuantidade, out int quantidade);    //a quantidade de números que pretende jogar para concorrer (geralmente 6)

            Console.WriteLine("\nQuantas vezes você irá jogar?");
            string respostaRepeat = Console.ReadLine();
            bool convert3 = int.TryParse(respostaRepeat, out int repeat); //quantas apostas quer gerar
            
            
            
            List<int> numeros = new List<int>(); //lista que vai armazenar temporariamente os números gerados para printar no console


            if (convert1 && convert2 && convert3) //checa se todas as informações inseridas pelo usuário são válidas (são convertíveis a int)
            {
                for(int r = 0; r < repeat; r++) //vai loopar o código até ter a quantidade de apostas que o usuário quer gerar
                {
                                        
                    Random rnd = new Random(); //um objeto da classe Random pra randomizar numeros

                    
                    while (numeros.Count < quantidade)   //vai loopar a geração até termos a quantidade de numeros que o usuário precisa
                    {
                        int numeroGerado = rnd.Next(1, range++); //variável temporária para armazenar o número gerado


                        if (!numeros.Contains(numeroGerado)) //vai checar se o número gerado já existe na Lista
                        {
                            numeros.Add((numeroGerado)); //caso não exista vai adicionar na lista
                        }
                    }           
                   
                    foreach (int i in numeros)
                    {
                        Console.Write(i + " "); //vai printar todos os números gerados para aquela aposta, armazenados temporariamente na lista
                    }


                    numeros.Clear();   //vai limpar a lista e voltar o código lá pra cima, gerando outra aposta caso o usuário insira mais de uma
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira números válidos!");
            }        
        }       
    }
}
