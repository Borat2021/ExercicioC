using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titula { get; internal set; }

        internal void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao; 
            //throw new NotImplementedException();
        }
    }
}