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
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoC
{
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();

            Exc0401A2.Visible = false; Exc0401B2.Visible = false; Exc0401C2.Visible = false; Exc0401D2.Visible = false; Exc0401E2.Visible = false;
            Exc0402A2.Visible = false; Exc0402B2.Visible = false; Exc0402C2.Visible = false; Exc0402D2.Visible = false; Exc0402E2.Visible = false;




        }
        int NotaFinalDoJogador = 0;

        private void Exc0401A1_Click(object sender, EventArgs e)
        {
            Exc0401A2.Visible = true;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible = false;
            Exc0401E1.Visible = false;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0401A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0401B1_Click(object sender, EventArgs e)
        {
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401B2.Visible = true;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible = false;
            Exc0401E1.Visible = false;

            Exc0401B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0401C1_Click(object sender, EventArgs e)
        {
            Exc0401C1.Visible = false;
            Exc0401C2.Visible = true;
            Exc0401D1.Visible = false;
            Exc0401E1.Visible = false;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;

            Exc0401C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0401D1_Click(object sender, EventArgs e)
        {
            Exc0401D1.Visible = false;
            Exc0401D2.Visible = true;
            Exc0401E1.Visible = false;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible = false;

            Exc0401D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0401E1_Click(object sender, EventArgs e)
        {
            Exc0401E1.Visible = false;
            Exc0401E2.Visible = true;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible = false;

            Exc0401E2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0402A1_Click(object sender, EventArgs e)
        {
            Exc0402A2.Visible = true;
            Exc0402A1.Visible = false;
            Exc0402B1.Visible = false;
            Exc0402C1.Visible = false;
            Exc0402D1.Visible = false;
            Exc0402E1.Visible = false;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0402A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0402B1_Click(object sender, EventArgs e)
        {
            Exc0402A1.Visible = false;
            Exc0402B1.Visible = false;
            Exc0402B2.Visible = true;
            Exc0402C1.Visible = false;
            Exc0402D1.Visible = false;
            Exc0402E1.Visible = false;

            Exc0402B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0402C1_Click(object sender, EventArgs e)
        {
            Exc0402C1.Visible = false;
            Exc0402C2.Visible = true;
            Exc0402D1.Visible = false;
            Exc0402E1.Visible = false;
            Exc0402A1.Visible = false;
            Exc0402B1.Visible = false;

            Exc0402C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0402D1_Click(object sender, EventArgs e)
        {
            Exc0402D1.Visible = false;
            Exc0402D2.Visible = true;
            Exc0402E1.Visible = false;
            Exc0402A1.Visible = false;
            Exc0402B1.Visible = false;
            Exc0402C1.Visible = false;

            Exc0402D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0402E1_Click(object sender, EventArgs e)
        {
            Exc0402E1.Visible = false;
            Exc0402E2.Visible = true;
            Exc0402A1.Visible = false;
            Exc0402B1.Visible = false;
            Exc0402C1.Visible = false;
            Exc0402D1.Visible = false;

            Exc0401E2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int Idade = 0;

            Idade = Convert.ToInt32(textBoxIdade.Text);

            if (checkBoxBrasileiro.Checked && Idade >= 16)
            {
                MessageBox.Show("pode votar é Brasileiro e tem " + Idade + " anos");
            }
            else if (checkBoxBrasileiro.Checked == false)
            {
                MessageBox.Show("Voce não pode votar porque não é Brasileiro");
            }
            else
            {
                MessageBox.Show("Voce não pode votar porque é menor de 16 anos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio04Pagina01 NovaJanela = new Exercicio04Pagina01();
            NovaJanela.Show();
            {
                this.Close();
            }

        }

    }
}

