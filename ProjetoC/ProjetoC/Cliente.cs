using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoC
{
    internal class Cliente
    {
        internal static object c;

        // string p;
        public Cliente(string p)
        {
            this.Nome = p;
        }
        public string Nome { get; set; }

    }

}
