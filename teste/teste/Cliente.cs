using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public class Cliente
    { 
        public string Nome { get; set; }


        public Cliente(string nome)
        {

            this.Nome = nome;
        }
    }       
}

