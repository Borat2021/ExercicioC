using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoC
{
    public partial class Exercicio03 : Form
    {

        public Exercicio03()
        {
            InitializeComponent();
            // O Formulario Exercicio03 começam com os objetos visiveis da linha 22 a 27
            label4.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            // O Formulario Exercicio03 começam com os objetos invisiveis da linha 29 a 40
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            txtMediaPessoa.Visible = false;


        }
        //Decrando a variavel int NotaFinalDoJogador para somar e usar no Formaulario PlacarFinal
        int NotaFinalDoJogador = 0;

        //iniciando o metodo btnCalcular_Click
        private void btnCalcular_Click(object sender, EventArgs e)
        {  //Declarando as variaveis string com nomes nomepessoa1, nomepessoa2, nomepessoa3 vazias
            string nomepessoa1, nomepessoa2, nomepessoa3;
            //Declarando as variaveis int com nomes idadepessoal1 com valor 0, idadepessoal2 com valor 0, idadepessoal3 com valor 0
            int idadepessoal1 = 0, idadepessoal2 = 0, idadepessoal3 = 0;
            //Declarando a variavel double com nome media sem valor
            double media;

            //O texto digitado na caixa textPessoa1 é recebida pela variavel nomepessoa1
            nomepessoa1 = textPessoa1.Text;

            // converte a variavel idadepessoal1 digitada na caixa textIdadePessoa1 para uma string
            idadepessoal1 = Convert.ToInt32(textIdadePessoa1.Text);
            //O texto digitado na caixa textPessoa1 é recebida pela variavel nomepessoa2
            nomepessoa2 = textPessoa2.Text;
            // converte a variavel idadepessoal1 digitada na caixa idadepessoal2 para uma string
            idadepessoal2 = Convert.ToInt32(textIdadePessoa2.Text);
            //O texto digitado na caixa textPessoa1 é recebida pela variavel nomepessoa3
            nomepessoa3 = textPessoa3.Text;
            // converte a variavel idadepessoal1 digitada na caixa idadepessoal3 para uma string
            idadepessoal3 = Convert.ToInt32(textIdadePessoa3.Text);
            // calcula a media da pessoas somando a idade das 3 e dividindo pela quantidade de pessoas neste caso são 3 pessoas
            media = (idadepessoal1 + idadepessoal2 + idadepessoal3) / 3;
            // converte a objeto txtMediaPessoa em um texto string
            txtMediaPessoa.Text = Convert.ToString(media);
            // O objeto txtMediaPessoa se torna visivel
            txtMediaPessoa.Visible = true;
            // Uma caixa de mensagem com os nomes de cada pessoa digitada com suas idades e a media de todas
            MessageBox.Show("Primeiro nome: " + nomepessoa1 + " sua idade é, " + idadepessoal1 + " anos;" + "\n Segundo nome: " + nomepessoa2 +
                " sua idade é, " + idadepessoal2 + "anos; " + " \n Terceiro nome: " + nomepessoa3 + " sua idade é, " + idadepessoal3 + " anos" +
                "\n A média de idade das pessoas é: " + media);
        }
        //Inicia o metodo label6_Click
        private void label6_Click(object sender, EventArgs e)
        {   //coloca os objetos da lina 68 ate a 70 invisiveis
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            //Coloca o objeto label9 visivel
            label9.Visible = true;
            //Coloca o objeto label9 com a cor vermelha
            label9.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ERROU NÃO GANHOU "
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        //Inicia o metodo label8_Click
        private void label8_Click(object sender, EventArgs e)
        {   //coloca os objetos da lina 82 ate a 84 invisiveis
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            //Coloca o objeto label11 visivel
            label11.Visible = true;
            //Soma + 10 a sua pontuação NotaFinalDoJogador.
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            //Coloca o objeto label11 com a cor vermelha
            label11.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ACERTOU GANHOU "
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = true;
            label10.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = true;
            label15.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label16.Visible = true;
            label16.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void label14_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label17.Visible = true;
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            label17.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Inicia o metodo btnCalcularD_Click
        private void btnCalcularD_Click(object sender, EventArgs e)
        {   //Declara as variaveis int com nomes a, b, c sem valor
            int a, b, c;
            //Declara as variaveis double com nomes delta, a1, a2 sem valores
            double delta, a1, a2;
            //Converte a variavel int para uma string
            a = Convert.ToInt32(textNumero1.Text);
            //Converte a variavel int para uma string
            b = Convert.ToInt32(textBoxNumero2.Text);
            //Converte a variavel int para uma string
            c = Convert.ToInt32(textBoxNumero3.Text);
            //formula de bhaskara
            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //Converte o objeto textBoxDelta para uma string
            textBoxDelta.Text = Convert.ToString(delta);
            //Converte o objeto textBoxNumeroA1 para uma string
            textBoxNumeroA1.Text = Convert.ToString(a1);
            //Converte o objeto textBoxNumeroA2 para uma string
            textBoxNumeroA2.Text = Convert.ToString(a2);
            // Os objetos textBoxNumeroA1 e textBoxNumeroA2 ficam invisiveis
            textBoxNumeroA1.Visible = false;
            textBoxNumeroA2.Visible = false;
            // Os objetos label23 e label24 ficam invisiveis
            label23.Visible = false;
            label24.Visible = false;
            //Converte o objeto label25 para uma string
            label25.Text = Convert.ToString(a1);
            //Converte o objeto label26 para uma string
            label26.Text = Convert.ToString(a2);
            //Os objetos da linha 173 a 177 ficam visiveis
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
        }

        //Declara um metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        { //Fecha o formulario Exercicio03.cs
            this.Close();
        }
    }
}
