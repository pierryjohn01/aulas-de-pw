namespace exemploquizz
{
    internal class PONTOS
    {
        private static int certo = 0;
        private static int erro = 0;
        public int Certo
        {
            get {  return certo; }
            set { certo = value; }
        }
        public int Erro
        {
            get { return erro; }
            set { erro = value; }
        }
    }
}