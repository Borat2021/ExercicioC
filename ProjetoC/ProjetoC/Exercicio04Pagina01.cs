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
            // O Formulario Exercicio04Pagina01 começa com o objeto label4 visivel 
            label4.Visible = false;

        }
        //Inicia o metodo btnImposto_Click
        private void btnImposto_Click(object sender, EventArgs e)
        { //Declara a variavel double iniciando ele com 1000
            double valorDaNotaFiscal = 1000;
            //Declara a variavel double como taxa
            double taxa;

            //Se o valor da nota fiscal for menor ou igual a 999
            if (valorDaNotaFiscal >= 999)
            {
                //Faça taxa recebe o valor da nota multiplicado por 2 e dividido por 100
                taxa = (valorDaNotaFiscal * 2) / 100;
                // converte a objeto TxtTaxa em um texto string
                TxtTaxa.Text = Convert.ToString(taxa);
                // Uma caixa de mensagem Valor da Nota Fiscal + o valor da taxa
                MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);
            }
            //senão se o valor da nota fiscal for menor ou igual a 2999
            else if (valorDaNotaFiscal >= 2999)
            {
                //Faça taxa recebe o valor da nota multiplicado por 2.5 e dividido por 100
                taxa = (valorDaNotaFiscal * 2.5) / 100;
                // converte a objeto TxtTaxa em um texto string
                TxtTaxa.Text = Convert.ToString(taxa);
                // Uma caixa de mensagem Valor da Nota Fiscal + o valor da taxa
                MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);
            }
            //senão se o valor da nota fiscal for menor ou igual a 6999
            else if (valorDaNotaFiscal >= 6999)
            {
                //Faça taxa recebe o valor da nota multiplicado por 2.8 e dividido por 100
                taxa = (valorDaNotaFiscal * 2.8) / 100;
                // converte a objeto TxtTaxa em um texto string
                TxtTaxa.Text = Convert.ToString(taxa);
                // Uma caixa de mensagem Valor da Nota Fiscal + o valor da taxa
                MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);
            }
            //senão
            else
                //Faça taxa recebe o valor da nota multiplicado por 3 e dividido por 100
                taxa = (valorDaNotaFiscal * 3) / 100;
            // converte a objeto TxtTaxa em um texto string
            TxtTaxa.Text = Convert.ToString(taxa);
            // Uma caixa de mensagem Valor da Nota Fiscal + o valor da taxa
            MessageBox.Show("Valor da Nota Fiscal é de " + valorDaNotaFiscal + " e o valor da taxa é de " + taxa);


        }
        //Inicia o metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        {
            //Ao clicar no button1_Click o objeto label3 fica invisivel
            label3.Visible = false;
            //Ao clicar no button1_Click o objeto label4 fica visivel
            label4.Visible = true;
        }
        //Inicia o metodo button2_Click
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha o formulario Exercicio04Pagina01.cs
            this.Close();
        }
    }
}


