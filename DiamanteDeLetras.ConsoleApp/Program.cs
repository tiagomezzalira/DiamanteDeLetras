using System;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int quantEspacoEsquerda, quantEspacoMeio, linhadomeio = 0;
            Console.WriteLine("Digite a letra de A a Z");
            letra= Convert.ToChar(Console.ReadLine());
            quantEspacoMeio = 0;
           
            char [] vetoralfabeto = alfabeto.ToCharArray();

            for (int i = 0; i < vetoralfabeto.Length ; i++) 
                {
                if (vetoralfabeto[i] == letra) 
                {
                    linhadomeio = i;
                }
            }
            quantEspacoEsquerda = linhadomeio;
            for (int i = 0; i <= linhadomeio; i++) 
            {
                for (int j = 0;j<quantEspacoEsquerda;j++)
                {
                    Console.Write(" ");
                }
                Console.Write(vetoralfabeto [i]);
                for (int k = 0;k < quantEspacoMeio ;k++)
                {
                    Console.Write(" ");
                }
                if (i !=0)
                {
                    Console.Write(vetoralfabeto[i] );
                }
                Console.WriteLine ();

                quantEspacoEsquerda = quantEspacoEsquerda - 1;
                if (i == 0) {
                    quantEspacoMeio = 1;
                }
                else if (i !=0 && i!=linhadomeio)
                {
                    quantEspacoMeio = quantEspacoMeio + 2;
                }
            }
            quantEspacoEsquerda = 0;
            for (int i = 1; i <= linhadomeio; i++)
            {
                quantEspacoEsquerda = quantEspacoEsquerda +1 ;
                if (i == linhadomeio)
                {
                    quantEspacoMeio = 1;
                }
                else if (i != 0)
                {
                    quantEspacoMeio = quantEspacoMeio - 2;
                }
                for (int j = 0; j < quantEspacoEsquerda; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(vetoralfabeto[i]);
                for (int k = 0; k < quantEspacoMeio; k++)
                {
                    Console.Write(" ");
                }
                if (i != linhadomeio)
                {
                    Console.Write(vetoralfabeto[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
