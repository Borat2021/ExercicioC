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
            // O Formulario Exercicio04 começam com os objetos invisiveis da linha 21 a 30
            Exc0401A2.Visible = false;
            Exc0401B2.Visible = false;
            Exc0401C2.Visible = false;
            Exc0401D2.Visible = false;
            Exc0401E2.Visible = false;
            Exc0402A2.Visible = false;
            Exc0402B2.Visible = false;
            Exc0402C2.Visible = false;
            Exc0402D2.Visible = false;
            Exc0402E2.Visible = false;
        }
        //Decrando a variavel int NotaFinalDoJogador para somar e usar no Formaulario PlacarFinal
        int NotaFinalDoJogador = 0;

        //Inicia o metodo Exc0401A1_Click
        private void Exc0401A1_Click(object sender, EventArgs e)
        {   //coloca os objetos da lina 37 ate a 41 invisiveis            
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible = false;
            Exc0401E1.Visible = false;
            //Coloca o objeto Exc0401A2 visivel
            Exc0401A2.Visible = true;
            //Soma + 10 a sua pontuação NotaFinalDoJogador.
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            //Coloca o objeto Exc0401A2 com a cor vermelha
            Exc0401A2.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ACERTOU GANHOU "
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Inicia o metodo Exc0401B1_Click
        private void Exc0401B1_Click(object sender, EventArgs e)
        {   //coloca os objetos da lina 56 ate a 60 invisiveis
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible = false;
            Exc0401E1.Visible = false;
            //Coloca o objeto Exc0401B2 visivel
            Exc0401B2.Visible = true;
            //Coloca o objeto Exc0401B2 com a cor vermelha
            Exc0401B2.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ERROU NÃO GANHOU "
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

        //Inicia o metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        {   //Declara a variavel int e atribui 0 a ela
            int Idade = 0;
            // converte a variavel Idade digitada na caixa textBoxIdade para uma string
            Idade = Convert.ToInt32(textBoxIdade.Text);
            //Se a caixa estiver maracada e a idade for igual ou mais de 16
            if (checkBoxBrasileiro.Checked && Idade >= 16)
            {   //Aparece a caixa de texto com a informação que você pode  votar pela idade e pos ser brasileiro
                MessageBox.Show("pode votar é Brasileiro e tem " + Idade + " anos");
            }
            //Senão se a caixa estiver desmarcada 
            else if (checkBoxBrasileiro.Checked == false)
            {   //Aparece a caixa de texto com a informação "Voce não pode votar porque não é Brasileiro"
                MessageBox.Show("Voce não pode votar porque não é Brasileiro");
            }
            //senão 
            else
            {   //Aparece a caixa de texto com a informação "Voce não pode votar porque é menor de 16 anos"
                MessageBox.Show("Voce não pode votar porque é menor de 16 anos");
            }

        }
        // Inicia um metodo button2_Click
        private void button2_Click(object sender, EventArgs e)
        {//Inicia um novo formulario Exercicio04Pagina01 usando o metodo NovaJanela criado no formulario indice 
            Exercicio04Pagina01 NovaJanela = new Exercicio04Pagina01();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            {
                //Fecha o formulario Exercicio04.cs
                this.Close();
            }

        }

    }
}

