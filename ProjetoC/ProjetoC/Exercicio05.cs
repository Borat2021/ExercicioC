using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoC
{
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
            Exc0501B1.Visible = false;
            Exc0501B2.Visible = false;
            Exc0501B3.Visible = false;
            Exc0501B4.Visible = false;
            label6.Visible = false;

        }
        int NotaFinalDoJogador = 0;

        private void Exc0501A2_Click(object sender, EventArgs e)
        {
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;

            Exc0501B2.Visible = true;
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0501B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0501A1_Click(object sender, EventArgs e)
        {
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;

            Exc0501B1.Visible = true;
            Exc0501B1.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0501A3_Click(object sender, EventArgs e)
        {
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;

            Exc0501B3.Visible = true;
            Exc0501B3.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0501A4_Click(object sender, EventArgs e)
        {
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;

            Exc0501B4.Visible = true;
            Exc0501B4.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            int mais = 1;
            while (mais <= 1000)
            {
                soma = soma + mais;
                mais++;
            }
            MessageBox.Show("A soma dos números de 1 a 100 é igual a= " + soma);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linha5 = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    linha5 += ", " + i;
                    label6.Text = Convert.ToString("Números Divisíveis por 3:\n" +
                       "" + linha5);
                    label6.Visible = true;
                    label6.ForeColor = Color.Red;
                    button2.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var numeroInicial = 1;
            var numeroFinal = 100;
            var soma = 0;

            for (int numeroAtual = numeroInicial; numeroAtual <= numeroFinal; numeroAtual++)
            {
                var ehMultiploDeTres = numeroAtual % 3 == 0;
                if (ehMultiploDeTres)
                    continue;

                soma += numeroAtual;
            }
            MessageBox.Show(string.Concat("O resultado é ", soma), "Resultado");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string linha3 = "";
            string linha4 = "";

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    linha3 += " - " + i;
                }
                else if (i % 4 == 0)
                {
                    linha4 += " - " + i;
                }
            }
            MessageBox.Show("Por 3: " + linha3 + "\n Por 4: " + linha4 + ".", "OS NÚMEROS DIVISÍVEIS POR 3 E POR 4 DE 1 A 30 SÃO",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("O fatorial de " + n + " é : " + fatorial + ".", "O NÚMERO FATORIAL DE 1 A 10 NA SEQUÊNCIA É:",
                MessageBoxButtons.OK);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0, b = 1;
            int i = 100;
            int fibo = 0;
            for (int j = 1; b < 100; j++)
            {
                fibo = a;
                a = b;
                b = fibo + b;
                MessageBox.Show("A série de Fibonacci é a seguinte: " + b);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exercicio05Pagina01 NovaJanela = new Exercicio05Pagina01();
            NovaJanela.Show();
            {
                this.Close();
            }
        }
    }
}

