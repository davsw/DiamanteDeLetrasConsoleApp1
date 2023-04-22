using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char letraInformada = 'Z';

            char letra = 'A';

            int espacoBranco = letraInformada - letra;

            int quantidadeLinhas = letraInformada - letra;

            int espacosEntreLetras = -1;

            // parte superior

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacoBranco; i++)
                    Console.Write(" ");

                Console.Write(letra);

                for (int i = 0; i < espacosEntreLetras; i++)
                    Console.Write(" ");

                if (letra != 'A')
                    Console.Write(letra);

                letra++;
                espacoBranco--;
                espacosEntreLetras += 2;

                Console.WriteLine();
            }

            // parte do meio
            Console.Write(letraInformada);

            for (int i = 0; i < espacosEntreLetras; i++)
                Console.Write(" ");

            Console.Write(letraInformada);

            letra--;
            espacoBranco++;
            espacosEntreLetras -= 2;
            Console.WriteLine();

            // parte inferior

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacoBranco; i++)
                    Console.Write(" ");

                Console.Write(letra);

                for (int i = 0; i < espacosEntreLetras; i++)
                    Console.Write(" ");

                if (letra != 'A')
                    Console.Write(letra);

                letra--;
                espacoBranco++;
                espacosEntreLetras -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
