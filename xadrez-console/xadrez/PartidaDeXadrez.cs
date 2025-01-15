using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set;}
        private int turno;
        private Cor jogadorAtual;
<<<<<<< HEAD
<<<<<<< HEAD
        public bool terminada { get; private set;}
=======
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7
=======
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
<<<<<<< HEAD
<<<<<<< HEAD
            terminada = false;
=======
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7
=======
>>>>>>> 4ede6bc9154137a02efad80f90400f8a86e276b7
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);



        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());

        }


    }
}
