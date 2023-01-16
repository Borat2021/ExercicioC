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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
            Exc0601A2.Visible = false;
            Exc0601B2.Visible = false;
            Exc0601C2.Visible = false;
            Exc0601D2.Visible = false;

            Exc0602A2.Visible = false;
            Exc0602B2.Visible = false;
            Exc0602C2.Visible = false;

            Exc0603A2.Visible = false;
            Exc0603B2.Visible = false;
            Exc0603C2.Visible = false;
            Exc0603D2.Visible = false;

            btnTransferir.Visible = false;   
            Exc0608A2.Visible = false;
            Exc0608B2.Visible = false;
            Exc0608C2.Visible = false;
            Exc0608D2.Visible = false;



        }
        int NotaFinalDoJogador = 0;

        private void Exc0601A1_Click(object sender, EventArgs e)
        {
            Exc0601A1.Visible = false;
            Exc0601B1.Visible = false;
            Exc0601C1.Visible = false;
            Exc0601D1.Visible = false;
            Exc0601A2.Visible = true;

            Exc0601A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0601B1_Click(object sender, EventArgs e)
        {
            Exc0601A1.Visible = false;
            Exc0601B1.Visible = false;
            Exc0601C1.Visible = false;
            Exc0601D1.Visible = false;
            Exc0601B2.Visible = true;

            Exc0601B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void Exc0601C1_Click(object sender, EventArgs e)
        {
            Exc0601A1.Visible = false;
            Exc0601B1.Visible = false;
            Exc0601C1.Visible = false;
            Exc0601D1.Visible = false;
            Exc0601C2.Visible = true;

            Exc0601C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Exc0601D1_Click(object sender, EventArgs e)
        {
            Exc0601A1.Visible = false;
            Exc0601B1.Visible = false;
            Exc0601C1.Visible = false;
            Exc0601D1.Visible = false;
            Exc0601D2.Visible = true;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0601D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0602A1_Click(object sender, EventArgs e)
        {
            Exc0602A1.Visible = false;
            Exc0602B1.Visible = false;
            Exc0602C1.Visible = false;
            Exc0602A2.Visible = true;

            Exc0602A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0602B1_Click(object sender, EventArgs e)
        {
            Exc0602A1.Visible = false;
            Exc0602B1.Visible = false;
            Exc0602C1.Visible = false;
            Exc0602B2.Visible = true;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0602B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0602C1_Click(object sender, EventArgs e)
        {
            Exc0602A1.Visible = false;
            Exc0602B1.Visible = false;
            Exc0602C1.Visible = false;
            Exc0602C2.Visible = true;

            Exc0602C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0603A1_Click(object sender, EventArgs e)
        {
            Exc0603A1.Visible = false;
            Exc0603B1.Visible = false;
            Exc0603C1.Visible = false;
            Exc0603D1.Visible = false;

            Exc0603A2.Visible = true;
            Exc0603A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0603B1_Click(object sender, EventArgs e)
        {
            Exc0603A1.Visible = false;
            Exc0603B1.Visible = false;
            Exc0603C1.Visible = false;
            Exc0603D1.Visible = false;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0603B2.Visible = true;
            Exc0603B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0603C1_Click(object sender, EventArgs e)
        {
            Exc0603A1.Visible = false;
            Exc0603B1.Visible = false;
            Exc0603C1.Visible = false;
            Exc0603D1.Visible = false;

            Exc0603C2.Visible = true;
            Exc0603C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0603D1_Click(object sender, EventArgs e)
        {
            Exc0603A1.Visible = false;
            Exc0603B1.Visible = false;
            Exc0603C1.Visible = false;
            Exc0603D1.Visible = false;

            Exc0603D2.Visible = true;
            Exc0603D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnEntrarNaConta_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";
            c.saldo = 100;
            MessageBox.Show("Bem vindo(a) Senhor(a)! " + c.titular + ".", "BANCO SENAI",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            // inicializa os atributos
            if (c.Saca(100.0))
            {
                MessageBox.Show("Saque realizado com sucesso! \n" + "Saldo: " + ($"{c.saldo} Reais"));
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente! \n" + "Saldo: " + ($"{c.saldo} Reais"));
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta();
            contaVictor.titular = "Victor";
            contaVictor.numero = 1;
            contaVictor.Deposita(100);

            MessageBox.Show("Saldo: " + contaVictor.saldo);
            contaVictor.Saca(50.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Conta Mauricio = new Conta();
            Mauricio.saldo = 2000.0;

            Conta Guilherme = new Conta();
            Guilherme.saldo = 5000.0;

            Mauricio.saldo -= 200.0;
            Guilherme.saldo += 200.0;
            MessageBox.Show("Mauricio = "+ Mauricio.saldo);
            MessageBox.Show("Guilherme = " + Guilherme.saldo);

        }

        private void Exc0608A1_Click(object sender, EventArgs e)
        {
            Exc0608A1.Visible = false;
            Exc0608B1.Visible = false;
            Exc0608C1.Visible = false;
            Exc0608D1.Visible = false;
            Exc0608A2.Visible = true;

            Exc0608A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnTransferir.Visible = true;
        }

        private void Exc0608B1_Click(object sender, EventArgs e)
        {
            Exc0608A1.Visible = false;
            Exc0608B1.Visible = false;
            Exc0608C1.Visible = false;
            Exc0608D1.Visible = false;
            Exc0608B2.Visible = true;

            Exc0608B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnTransferir.Visible = true;
        }

        private void Exc0608C1_Click(object sender, EventArgs e)
        {
            Exc0608A1.Visible = false;
            Exc0608B1.Visible = false;
            Exc0608C1.Visible = false;
            Exc0608D1.Visible = false;
            Exc0608C2.Visible = true;

            Exc0608C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnTransferir.Visible = true;
        }

        private void Exc0608D1_Click(object sender, EventArgs e)
        {
            Exc0608A1.Visible = false;
            Exc0608B1.Visible = false;
            Exc0608C1.Visible = false;
            Exc0608D1.Visible = false;
            Exc0608D2.Visible = true;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0608D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnTransferir.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio06Pagina01 NovaJanela = new Exercicio06Pagina01();
            NovaJanela.Show();
            {
                this.Close();
            }
        }
    }
}









           

