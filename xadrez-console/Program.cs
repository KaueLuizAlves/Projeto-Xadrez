using System;
using System.Xml;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
               
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }


             
=======

                Tela.imprimirTabuleiro(partida.tab);
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7
=======

                Tela.imprimirTabuleiro(partida.tab);
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7
=======

                Tela.imprimirTabuleiro(partida.tab);
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}