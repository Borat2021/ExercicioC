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
            //Inicia o formulario Exercicio05 com os objetos invisiveis da linha 19 ate a linha 28
            btnResposta0609A1.Visible = false;
            Exc0609A2.Visible = false;
            Exc0609B2.Visible = false;
            Exc0609C2.Visible = false;

            btnResposta0610.Visible = false;
            Exc0610A2.Visible = false;
            Exc0610B2.Visible = false;
            Exc0610C2.Visible = false;
            Exc0610D2.Visible = false;

            textSaldoAtual2.Visible = false;            
            textSaldoAtual3.Visible = false;

        }
        
        //Decrando a variavel int NotaFinalDoJogador para somar e usar no Formaulario PlacarFinal
        int NotaFinalDoJogador = 0;

        internal Conta c { get; private set; }

        //Inicia um metodo btnResposta0609A1_Click
        private void btnResposta0609A1_Click(object sender, EventArgs e)
        {            //Declara uma variavel do tipo strig com nome valorDigitado recebe o objeto textoValor
            string SaldoAtual = "100.0";
            textSaldoAtual2.Visible= true;
            textSaldoAtual2.Text= SaldoAtual;
            textSaldoAtual3.Visible = true;
            textSaldoAtual3.Text = SaldoAtual;
            //Esta c recebe uma nova Conta
            this.c = new Conta();
            //Numero da Classe recebe 2
            c.Numero = 1;
            //cliente da Classe Conta novo Cliente
            Cliente cliente = new Cliente("Mauricio");
            //Titular da classe Conta recebe cliente 
            c.Titular = cliente;
            // Objeto textoTitular recebe Nome do titular da classe conta
            textoTitular2.Text = c.Titular.Nome;
            // converte o Objeto textoNumero em uma string o que foi digitada na caixa c.Numero 
            textoNumero2.Text = Convert.ToString(c.Numero);
            //cliente da Classe Conta novo Cliente
            Cliente cliente1 = new Cliente("Mauricio");            
            //Titular da classe Conta recebe cliente 
            c.Titular = cliente1;           
            // Objeto textoTitular recebe Nome do titular da classe conta
            textoTitular3.Text = c.Titular.Nome;
            // converte o Objeto textoNumero em uma string o que foi digitada na caixa c.Numero 
            textoNumero3.Text = Convert.ToString(c.Numero);
            // converte o Objeto textoSaldo em uma string o que foi digitada na caixa c.Saldo

            if (cliente==cliente1)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            { 
                MessageBox.Show("As contas são diferentes");
            }
        }
        //Inicia um Exc0609A1_Click
        private void Exc0609A1_Click(object sender, EventArgs e)
        {//coloca os objetos da lina 58 ate a 60 invisiveis
            Exc0609A1.Visible = false;
            Exc0609B1.Visible = false;
            Exc0609C1.Visible = false;
            //Coloca o objeto Exc0609A2 visivel
            Exc0609A2.Visible = true;
            //Coloca o objeto Exc0609A2 com a cor vermelha
            Exc0609A2.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ERROU NÃO GANHOU "
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //coloca os objetos btnResposta0609A1 visivel
            btnResposta0609A1.Visible = true;
        }
        //Inicia um metodo Exc0609B1_Click
        private void Exc0609B1_Click(object sender, EventArgs e)
        {//coloca os objetos da lina 74 ate a 76 invisiveis
            Exc0609A1.Visible = false;
            Exc0609B1.Visible = false;
            Exc0609C1.Visible = false;
            //Coloca o objeto Exc0609B2 visivel
            Exc0609B2.Visible = true;
            //Coloca o objeto Exc0609B2 com a cor vermelha
            Exc0609B2.ForeColor = Color.Red;
            //Soma + 10 a sua pontuação NotaFinalDoJogador
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ACERTOU GANHOU "
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //coloca os objetos btnResposta0609A1 visivel
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


        //Inicia um metodo btnResposta0610_Click
        private void btnResposta0610_Click(object sender, EventArgs e)
        {
            {
                string SaldoAtualmauricio = "3000.0";
                string SaldoAtualcopia = "3000.0";
                //Esta c recebe uma nova Conta
                this.c = new Conta();
                //Numero da Classe recebe 3
                c.Numero = 3;
                //cliente da Classe Conta novo Cliente
                Cliente cliente2 = new Cliente("mauricio");
                Cliente cliente3 = new Cliente("copia");
                //Titular da classe Conta recebe cliente2 e cliente3 
                c.Titular = cliente2;
                c.Titular = cliente3;
                //Aparece uma caixa de mensagem como o texto mauricio mais o saldo
                MessageBox.Show("mauricio = " + SaldoAtualmauricio);
                //Aparece uma caixa de mensagem como o texto copia mais o saldo
                MessageBox.Show("copia = " + SaldoAtualcopia);
            }


            
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
  
            Exc0610B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "ATENÇÃO!",
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
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0610D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnResposta0610.Visible = true;
        }
        //Inicia um metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        {
            double WenderSaldo = 2000.0;
            double SamuelSaldo =5000.00;

            this.c = new Conta();
            Conta Wender = new Conta();
            Cliente cliente2 = new Cliente ("Wênder");
            c.Titular = cliente2;
            c.Numero = 2;
            MessageBox.Show("Saldo Inicial de " + Wender.Saldo + ", conta nº: " + Wender.Numero);
            
            Conta Samuel = new Conta();
            Cliente cliente3 = new Cliente("Samuel");
            c.Titular=cliente3;
            c.Numero = 3;
            MessageBox.Show("Saldo Inicial de " + Samuel.Saldo + ", conta nº: " + Samuel.Numero);

            {   WenderSaldo -= 200.0;
                SamuelSaldo += 200.0;
            MessageBox.Show(" Foi (RETIRADO) da conta nº: " + c.Numero + ",\n pertence ao cliente " + cliente2.Nome + "\nFicando com saldo final de " + Wender.Saldo );
            MessageBox.Show(" Foi (DEPOSITADO) na conta nº: " + c.Numero + ",\n pertence ao cliente " + cliente3.Nome + "\nFicando com saldo final de " + Samuel.Saldo );
                
            }

        }
        //Inicia um metodo btnResposta0612_Click
        private void btnResposta0612_Click(object sender, EventArgs e)
        { 
            /*Conta Carlos = new Conta();
            Carlos.Titular.Nome = "Carlos";
            Carlos.Saldo =1000;
            Carlos.Titular.Idade= 11;

            if (Carlos.Saca(250))
            {
                MessageBox.Show($"O seu saque foi realizado");
            }
            else
            {
                MessageBox.Show($"Seu saque não foi permitido"+ ".", "BANCO SENAI",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
       */
        }
        //Inicia um metodo button2_Click
        private void button2_Click(object sender, EventArgs e)
        {         
        }

 
    }
        }
    
    



