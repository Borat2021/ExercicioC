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
    public partial class Exercicio06Pagina01 : Form
    {
        public Exercicio06Pagina01()
        {
            InitializeComponent();

            btnResposta0609A1.Visible = false;
            Exc0609A2.Visible = false;
            Exc0609B2.Visible = false;
            Exc0609C2.Visible = false;

            btnResposta0610.Visible = false;
            Exc0610A2.Visible = false;
            Exc0610B2.Visible = false;
            Exc0610C2.Visible = false;
            Exc0610D2.Visible = false;

        }
        int NotaFinalDoJogador = 0;

        private void btnResposta0609A1_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;
            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;
            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void Exc0609A1_Click(object sender, EventArgs e)
        {
            Exc0609A1.Visible = false;
            Exc0609B1.Visible = false;
            Exc0609C1.Visible = false;
            Exc0609A2.Visible = true;

            Exc0609A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0609A1.Visible = true;
        }

        private void Exc0609B1_Click(object sender, EventArgs e)
        {
            Exc0609A1.Visible = false;
            Exc0609B1.Visible = false;
            Exc0609C1.Visible = false;
            Exc0609B2.Visible = true;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0609B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0609A1.Visible = true;
        }

        private void Exc0609C1_Click(object sender, EventArgs e)
        {
            Exc0609A1.Visible = false;
            Exc0609B1.Visible = false;
            Exc0609C1.Visible = false;
            Exc0609C2.Visible = true;

            Exc0609C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0609A1.Visible = true;
        }



        private void btnResposta0610_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;
            Conta copia = mauricio;
            copia.saldo = 3000.0;
            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);

        }
        private void Exc0610A1_Click(object sender, EventArgs e)
        {
            Exc0610A1.Visible = false;
            Exc0610B1.Visible = false;
            Exc0610C1.Visible = false;
            Exc0610D1.Visible = false;
            Exc0610A2.Visible = true;

            Exc0610A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0610.Visible = true;
        }

        private void Exc0610B1_Click(object sender, EventArgs e)
        {
            Exc0610A1.Visible = false;
            Exc0610B1.Visible = false;
            Exc0610C1.Visible = false;
            Exc0610D1.Visible = false;
            Exc0610B2.Visible = true;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0610B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0610.Visible = true;
        }

        private void Exc0610C1_Click(object sender, EventArgs e)
        {
            Exc0610A1.Visible = false;
            Exc0610B1.Visible = false;
            Exc0610C1.Visible = false;
            Exc0610D1.Visible = false;
            Exc0610C2.Visible = true;

            Exc0610C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0610.Visible = true;
        }

        private void Exc0610D1_Click(object sender, EventArgs e)
        {
            Exc0610A1.Visible = false;
            Exc0610B1.Visible = false;
            Exc0610C1.Visible = false;
            Exc0610D1.Visible = false;
            Exc0610D2.Visible = true;

            Exc0610D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0610.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta Wender = new Conta();
            Wender.titular = "Wênder";
            Wender.numero = 2;
            Wender.saldo = 2000.0;
MessageBox.Show("Saldo Inicial de " + Wender.saldo + ", conta nº: " + Wender.numero);
            
            Conta Samuel = new Conta();
            Samuel.titular ="Samuel";
            Samuel.numero = 3;
            Samuel.saldo = 5000.0;
MessageBox.Show("Saldo Inicial de " + Samuel.saldo + ", conta nº: " + Samuel.numero);

            {   Wender.saldo -= 200.0;
                Samuel.saldo += 200.0;
            MessageBox.Show(" Foi (RETIRADO) da conta nº: " + Wender.numero + ",\n pertence ao cliente " + Wender.titular+ "\nFicando com saldo final de " + Wender.saldo );
            MessageBox.Show(" Foi (DEPOSITADO) na conta nº: " + Samuel.numero + ",\n pertence ao cliente " + Samuel.titular+ "\nFicando com saldo final de " + Samuel.saldo );
                
            }

        }

        private void btnResposta0612_Click(object sender, EventArgs e)
        { 
            Conta Carlos = new Conta();
            Carlos.titular = "Carlos";
            Carlos.saldo =1000;
            Carlos.idade = 11;

            if (Carlos.Saca(250))
            {
                MessageBox.Show($"O seu saque foi realizado");
            }
            else
            {
                MessageBox.Show($"Seu saque não foi permitido"+ ".", "BANCO SENAI",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Conta Thiago = new Conta();
            Thiago.titular = "Thiago";
            Thiago.numero = 5;
            Thiago.Deposita(10);

            if (Thiago.Saca(0))
            {
                MessageBox.Show($"O seu saque foi realizado");
            }
            else
            {
                MessageBox.Show($"Seu saque não foi permitido" + ".", "BANCO SENAI",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
    }



