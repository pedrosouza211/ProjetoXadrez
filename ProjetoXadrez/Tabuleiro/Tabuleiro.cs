   namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas  { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro (int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
       public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca peca1, Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new TabuleiroException("J� existe uma pe�a nesta posi��o!");
            }
            pecas[pos.linha, pos.coluna] = peca1;
            peca1.posicao = pos;

        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos)== null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;

        }
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna > colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao (Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posi��o Invalida");
            }
        }
    }
}