using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoC
{
    internal class Conta
    {
        // numero, titular e saldo são atributos do objeto
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }
        

        internal void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
            //throw new NotImplementedException();

        }
        internal bool Saca(double valorDigitado)
        {
            if (this.Saldo >= valorDigitado)
            {
                this.Saldo -= valorDigitado;
                return true;
            }if (this.Saldo < valorDigitado)
            {   

            }
            return false;
        }
        public void Transfere(double valor, Conta destino)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
            }
        }

    }
}

 
 
    

    
 
    

        
    
    


