using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoC
{
    public partial class Exercicio04Pagina01 : Form
    {
        public Exercicio04Pagina01()
        {
            InitializeComponent();
            label4.Visible = false;

        }

        private void btnImposto_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 1000;
            double taxa;


            if (valorDaNotaFiscal >= 999)
            {
                taxa = (valorDaNotaFiscal * 2) / 100;
                //textBoxValorDaNotaFiscal.Text = Convert.ToString(valorDaNotaFiscal);
                TxtTaxa.Text = Convert.ToString(taxa);
                MessageBox.Show("Valor da Nota Fiscal é de "+valorDaNotaFiscal+" e o valor da taxa é de " + taxa);
            }
            else if (valorDaNotaFiscal >= 2999)
            {
               // textBoxValorDaNotaFiscal.Text = Convert.ToString(valorDaNotaFiscal);
                taxa = (valorDaNotaFiscal * 2.5) / 100;
                TxtTaxa.Text = Convert.ToString(taxa);
                MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);
            }
            else if (valorDaNotaFiscal >= 6999)
            {
                //textBoxValorDaNotaFiscal.Text = Convert.ToString(valorDaNotaFiscal);
                taxa = (valorDaNotaFiscal * 2.8) / 100;
                TxtTaxa.Text = Convert.ToString(taxa);
                MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);
            }
            else
                //textBoxValorDaNotaFiscal.Text = Convert.ToString(valorDaNotaFiscal);
                taxa = (valorDaNotaFiscal * 3) / 100;
                TxtTaxa.Text = Convert.ToString(taxa);
                MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible=false;
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}


