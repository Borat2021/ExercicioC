using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta Wender = new Conta();
            Wender.Titular.nome = "Wênder";
            Wender.Numero = 2;
            Wender.Saldo = 2000.0;
MessageBox.Show("Saldo Inicial de " + Wender.Saldo + ", conta nº: " + Wender.Numero);
            
            Conta Samuel = new Conta();
            Samuel.Titular.nome ="Samuel";
            Samuel.Numero = 3;
            Samuel.Saldo = 5000.0;
MessageBox.Show("Saldo Inicial de " + Samuel.Saldo + ", conta nº: " + Samuel.Numero);

            {   Wender.Saldo -= 200.0;
                Samuel.Saldo += 200.0;
            MessageBox.Show(" Foi (RETIRADO) da conta nº: " + Wender.Numero + ",\n pertence ao cliente " + Wender.Titular + "\nFicando com Saldo final de " + Wender.Saldo );
            MessageBox.Show(" Foi (DEPOSITADO) na conta nº: " + Samuel.Numero + ",\n pertence ao cliente " + Samuel.Titular + "\nFicando com Saldo final de " + Samuel.Saldo );
                
            }

        }


    }
}
