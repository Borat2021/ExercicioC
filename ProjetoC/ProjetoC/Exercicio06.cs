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
        private Conta c;
        public Exercicio06()
        {
            InitializeComponent();
            // O Formulario Exercicio06 ira inicias com os objetos invisiveis da linha 19 a 34 invisiveis
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
        //Iniciara a  pontuação Nota Final Do Jogador em 0
        int NotaFinalDoJogador = 0;

        //Inicia metodo Exercicio06_Load
        private void Exercicio06_Load(object sender, EventArgs e)
        {   //Esta c recebe uma nova Conta
            this.c = new Conta();
            //Numero da Classe recebe 1
            c.Numero = 1;
            //cliente da Classe Conta novo Cliente
            Cliente cliente = new Cliente("Victor Augusto Sampaio");
            //Titular da classe Conta recebe cliente 
            c.Titular = cliente;
            // Objeto textoTitular recebe Nome do titular da classe conta
            textoTitular.Text = c.Titular.Nome;
            // converte o Objeto textoNumero em uma string o que foi digitada na caixa c.Numero 
            textoNumero.Text = Convert.ToString(c.Numero);
            // converte o Objeto textoSaldo em uma string o que foi digitada na caixa c.Saldo
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }
        //Inicia o metodo textoValor_KeyPress
        private void textoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A cor do BoxSenha vai estar amarela quando estiver selecionado
            textoValor.BackColor = Color.LightYellow;
            //Declarando uma variavel para a tecla BackSpace com o numero 08
            double tecla = (double)e.KeyChar;

            //A caixa so aceita que seja inserido apenas numeros e a tecla BackSpace  
            if (!char.IsDigit(e.KeyChar) && tecla != 8)
            
            {
                //Caso seja inserido tecla especial ou letra não aceita
                e.Handled = true;
                //Mensagem de aviso que so aceita numeros no campo
                MessageBox.Show("Digite apenas valores ", "Erro na digitação!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);


                /*A o texto da caixa onde contem as palavras digitadas vão ficar selecionas após
                aparecer a mensagem de "Digite apenas letras" quando for digitado coisas que não for letra */
                textoValor.SelectionStart = 0;
                textoValor.SelectionLength = textoValor.Text.Length;

                // O curso ira para o textoValor 
                textoValor.Focus();
            }
        }
        //Inicia o metodo textoValor_MouseEnter
        private void textoValor_MouseEnter(object sender, EventArgs e)
        {
            //A cor do textoValor vai estar branca quando NÃO estiver selecionado
            textoValor.BackColor = Color.White;
        }

        //Inicia o metodo btnEntrarNaConta_Click
        private void btnEntrarNaConta_Click(object sender, EventArgs e)
        {/*

            Cliente victor = new Cliente();
            victor.Nome = "victor";
            Conta umaConta = new Conta();
            umaConta.Titular = victor;
            umaConta.Titular.Rg = "12345678-9";
            umaConta.Numero = 1;
            // Mostra o nome victor
            MessageBox.Show(umaConta.Titular.Nome);
            // Mostra o texto 12345678-9
            MessageBox.Show(victor.Rg);
            */

        }
        //Inicia o metodo btnDepositar_Click
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            //Declara uma variavel do tipo strig com nome valorDigitado recebe o objeto textoValor
            string valorDigitado = textoValor.Text;
            //Declara uma variavel do tipo double com nome valorOperacao converte para double valorDigitado
            double valorOperacao = Convert.ToDouble(valorDigitado);
            //Esta Classe conta do metodo Deposito nome valorOperacao 
            this.c.Deposita(valorOperacao);
            // converte o Objeto textoSaldo em uma string no que foi digitada na caixa c.Saldo
            textoSaldo.Text = Convert.ToString(this.c.Saldo);

            // CONDIÇÃO. (if O valor maior 0 entra na condição "SEU DEPÓSITO FOI REALIZADO COM SUCESSO"
            // caso valor igual a 0 entra na condição else "VOCÊ DIGITOU UM VALOR ERRADO". 
            try
            {
                //SE o valorOperacao fo maior que 0    
                if (valorOperacao > 0)
                {
                    //Aparece uma mensagem SEU DEPÓSITO FOI REALIZADO COM SUCESSO
                    MessageBox.Show("SEU DEPÓSITO FOI REALIZADO COM SUCESSO");
                    // Ira apagar o valor no textoValor   
                    textoValor.Clear();
                    // O curso ira para o textoValor 
                    textoValor.Focus();

                }
                //Senão
                else
                { //Caso o valor estiver errada a valor digitada dento do textoValor ira apagar 
                    textoValor.Text = "";
                    //Aparecer a mensagem VOCÊ DIGITOU UM VALOR ERRADO
                    MessageBox.Show("VOCÊ DIGITOU UM VALOR ERRADO", "DESCULPE!",                    
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DESCULPE!", ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                // O curso ira para o textoValor
                textoValor.Focus();
            }

            /*Conta contavictor = new Conta();
            contavictor.Titular.Nome = "victor";

            contavictor.Deposita(100);
            contavictor.Numero = 1;
            MessageBox.Show("Saldo: " + contavictor.Saldo);
            contavictor.Saca(50.0);
            MessageBox.Show("Saldo: " + contavictor.Saldo);
            */
        }

         private void btnSacar_Click(object sender, EventArgs e)
        {   //Declara uma variavel com o nome valorDigitado recebe o objeto textoValor
            string valorDigitado = textoValor.Text;
            //Declara uma variavel do tipo double e converte o valor digitado na caixa valorDigitado em um double
            double valorOperacao = Convert.ToDouble(valorDigitado);
            //Esta Classe conta do metodo Saca nome valorOperacao
            this.c.Saca(valorOperacao);
            // Converte o Objeto textoSaldo em uma string no que foi digitada na caixa c.Saldo
            textoSaldo.Text = Convert.ToString(this.c.Saldo);

            // CONDIÇÃO. (if O valor maior 0 entra na condição "SEU DEPÓSITO FOI REALIZADO COM SUCESSO"
            // caso valor igual a 0 entra na condição else "VOCÊ DIGITOU UM VALOR ERRADO". 
            try
            {
                if (valorOperacao==0)
                { //Caso o valor estiver errado a palavra digitada dento do textoValor ira apagar 
                    textoValor.Text = "";
                    //Aparece uma mensagem VOCÊ DIGITOU UM VALOR ERRADO
                    MessageBox.Show("VOCÊ DIGITOU UM VALOR ERRADO", "DESCULPE!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // O curso ira para o textoValor 
                    textoValor.Focus();

                }
                //Se valorOperacao for menor que 0 e o Saldo da classe conta for igual a valorOperacao
                if (valorOperacao > 0 && this.c.Saldo==valorOperacao)
                {
                    //Aparece a mensagem SEU SAQUE FOI REALIZADO COM SUCESSO na caixa de texto
                    MessageBox.Show("SEU SAQUE FOI REALIZADO COM SUCESSO");
                    // Ira apagar o valor no textoValor   
                    textoValor.Clear();
                    // O curso ira para o textoValor 
                    textoValor.Focus();
                }
                //Senão se Saldo da classe conta for maior que valorOperacao
                if (this.c.Saldo > valorOperacao)
                {   //Aparece a mensagem SEU SAQUE FOI REALIZADO COM SUCESSO na caixa de texto
                    MessageBox.Show("SEU SAQUE FOI REALIZADO COM SUCESSO");
                    // Ira apagar o valor no textoValor   
                    textoValor.Clear();
                    // O curso ira para o textoValor 
                    textoValor.Focus();
                }
                //Senão se Saldo da classe conta for menor que valorOperacao
                if (this.c.Saldo < valorOperacao)
                {   //Aparece a mensagem SALDO INSUFICIENTE PARA SAQUE na caixa de texto 
                    MessageBox.Show("SALDO INSUFICIENTE PARA SAQUE");
                    // Ira apagar o valor no textoValor   
                    textoValor.Clear();
                    // O curso ira para o textoValor 
                    textoValor.Focus(); 
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DESCULPE!", ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            /* Conta Mauricio = new Conta();
            Mauricio.Saldo = 2000.0;

            Conta Guilherme = new Conta();
            Guilherme.Saldo = 5000.0;

            Mauricio.Saldo -= 200.0;
            Guilherme.Saldo += 200.0;
            MessageBox.Show("Mauricio = "+ Mauricio.Saldo);
            MessageBox.Show("Guilherme = " + Guilherme.Saldo);
*/
        }

        //Inicia o metodo Exc0601A1_Click
        private void Exc0601A1_Click(object sender, EventArgs e)
        {
            // Os objetos da linha 255 até a linha 258 ficam invisiveis
            Exc0601A1.Visible = false;
            Exc0601B1.Visible = false;
            Exc0601C1.Visible = false;
            Exc0601D1.Visible = false;
            // Objeto Exc0601A2 fica visivel
            Exc0601A2.Visible = true;
            // Objeto Exc0601A2 fica com cor vermelha
            Exc0601A2.ForeColor = Color.Red;
            //Aparce a mensagem VOCÊ ERROU NÃO GANHOU na caixa de texto
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
        {//coloca os objetos da lina 296 ate a 299 invisiveis
            Exc0601A1.Visible = false;
            Exc0601B1.Visible = false;
            Exc0601C1.Visible = false;
            Exc0601D1.Visible = false;
            //Coloca o objeto label11 visivel
            Exc0601D2.Visible = true;            
            //Soma + 10 a sua pontuação NotaFinalDoJogador.
            NotaFinalDoJogador = NotaFinalDoJogador + 10;            
            Exc0601D2.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ACERTOU GANHOU "
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
        //Inicia o metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio06Pagina01 usando o metodo NovaJanela criado no formulario indice
            Exercicio06Pagina01 NovaJanela = new Exercicio06Pagina01();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            {   //Fecha o formulario Exercicio05.cs
                this.Close();
            }
        }
    }
}

