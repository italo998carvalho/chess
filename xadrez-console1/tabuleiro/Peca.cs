﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }//construtor

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }//incrementarQteMovimentos

        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }//decrementarQteMovimentos

        public bool existemMovimentosPosssiveis()
        {
            bool[,] mat = movimentosPossiveis();

            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(mat[i, j])
                    {
                        return true;
                    }
                }
            }//for
            return false;
        }//existemMovimentosPossiveis

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }//podeMoverPara

        public abstract bool[,] movimentosPossiveis();

    }
}
