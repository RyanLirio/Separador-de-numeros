using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vetor
{
    public class ParAndImpar
    {
        static public void OsDois()
        {
            Console.WriteLine("Este programa separa numeros em duas listas,\nelas armazenam 10 numeros cada, sendo uma par e uma impar,\nescreva aqui alguns numeros para testar\n(Aperte qualquer tecla para começar a digitar)");
            
            //Limpa o primeiro texto ao clicar em qualquer caracter
            if(Console.ReadKey().Key != null)
            {
                Console.Clear();
            }
           
            int[] impar = new int[1000000];
            int[] par = new int[1000000];
            int indicePar = 0;
            int indiceImpar = 0;

            string input = Console.ReadLine();
                
            // Valida se o input é um número inteiro
            int valor;
            if (!int.TryParse(input, out valor))
            {
                Program.Main();
            }

            //executa o loop principal que não termina enquanto não for presionada a tecla Esc
            do{
            //Lê os valores digitados pelo usuário
            valor = int.Parse(Console.ReadLine());
            //Armazena os numeros pares
            if(valor % 2 == 0)
            {
                par[indicePar] = valor;
                indicePar++;
            }else //Armazena os numeros impares
            {
                impar[indiceImpar] = valor;
                indiceImpar++;
            }
            }while(Console.ReadKey(true).Key != ConsoleKey.Escape); //Condição para sair do loop
            //Percorre o array par
            for(int i = 0; i < indicePar && i < 10; i++)
            {
                Console.WriteLine($"O numero par {par[i]} foi digitado");
            }

            Console.WriteLine("");

            //Percorre o array impar
            for(int i = 0; i < indiceImpar && i < 10; i++)
            {
                Console.WriteLine($"O numero impar {impar[i]} foi digitado ");
            }
        }
    }
}