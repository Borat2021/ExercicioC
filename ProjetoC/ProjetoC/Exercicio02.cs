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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
            // O Formulario Exercicio02 começam com os objetos invisiveis da linha 18 a 23 invisiveis
            exer02Iten01Res01E.Visible = false;
            exer02Iten01Res02RespC.Visible = false;
            exer02Iten01Res03E.Visible = false;
            exer02Iten01Res04E.Visible = false;
            exer02Iten01Res05E.Visible = false;
        }
        //Decrando a variavel int NotaFinalDoJogador para somar e usar no Formaulario PlacarFinal
        int NotaFinalDoJogador = 0;
        //Declarando as variaveis string para usar nos metodos das linhas 34,52,71,89 e 107
        string mensagem1 = "Hello World";
        string mensagem2 = "Curso de C# da Caelum";
        string mensagem3 = "Olá Mundo";
        string mensagem4 = "Caelum";
        string mensagem5 = "Nenhuma das opções";

        //Metodo exer02Iten01Res01_Clik Quando clicar no nome (  ) Hello World.
        private void exer02Iten01Res01_Click(object sender, EventArgs e)
        {
            //se a mensagem1 for igual a "Hello World"
            if (mensagem1 == "Hello World")
            {   //Coloca os objetos da linha 40 a 44 invisiveis
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;
                //Coloca o objeto exer02Iten01Res01E visivel, (X)"Hello World".
                exer02Iten01Res01E.Visible = true;
                //Coloca o objeto exer02Iten01Res01E com a cor vermela, (X)"Hello World".
                exer02Iten01Res01E.ForeColor = Color.Red;
                //Aparece uma caixa de mensagem como o texto "VOCÊ ERROU NÃO GANHOU "
                MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exer02Iten01Res02_Click(object sender, EventArgs e)
        {
            if (mensagem2 == "Curso de C# da Caelum")
            {    //Coloca os objetos da linha 60 a 64 invisivel
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;
                //Coloca o objeto exer02Iten01Res02RespC visivel, (X)"Curso de C# da Caelum"
                exer02Iten01Res02RespC.Visible = true;
                //Soma + 10 a sua pontuação NotaFinalDoJogador.
                NotaFinalDoJogador = NotaFinalDoJogador + 10;
                //Coloca o objeto exer02Iten01Res02RespC com a cor vermelha, (X)"Curso de C# da Caelum"
                exer02Iten01Res02RespC.ForeColor = Color.Red;
                //Aparece uma caixa de mensagem como o texto "VOCÊ ACERTOU GANHOU "
                MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void exer02Iten01Res03_Click(object sender, EventArgs e)
        {
            if (mensagem3 == "Olá Mundo")
            {
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;

                exer02Iten01Res03E.Visible = true;
                exer02Iten01Res03E.ForeColor = Color.Red;
                MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exer02Iten01Res04_Click(object sender, EventArgs e)
        {
            if (mensagem4 == "Caelum")
            {
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;

                exer02Iten01Res04E.Visible = true;
                exer02Iten01Res04E.ForeColor = Color.Red;
                MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exer02Iten01Res05_Click(object sender, EventArgs e)
        {
            if (mensagem5 == "Nenhuma das opções")
            {
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;
                exer02Iten01Res05E.Visible = true;
                exer02Iten01Res05E.ForeColor = Color.Red;
                MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Declara o metodo btnProximo_Click
        private void btnProximo_Click(object sender, EventArgs e)
        {
            //Fecha o formulario Exercicio02.cs
            this.Close();
        }
    }
}
