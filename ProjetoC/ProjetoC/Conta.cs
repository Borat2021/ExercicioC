using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoC
{
    internal class Conta
    {
        // numero, titular e saldo são atributos do objeto
        public int numero;
        public string titular="";
        public double saldo = 0;
        public int idade;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public bool Saca(double valor)
        {
            if (this.saldo > 1 && this.saldo >= valor)
            {
                if (this.idade < 18)
                {
                    if (valor <= 200)
                    {
                        this.saldo -= valor;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    this.saldo -= valor;
                    return true;
                }
            }
            return true;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                destino.saldo += valor;
            }
        }

    }
}

 
 
    

    
 
    

        
    
    


