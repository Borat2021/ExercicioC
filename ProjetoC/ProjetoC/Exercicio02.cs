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

            exer02Iten01Res01E.Visible = false;
            exer02Iten01Res02RespC.Visible = false;
            exer02Iten01Res03E.Visible = false;
            exer02Iten01Res04E.Visible = false;
            exer02Iten01Res05E.Visible = false;
        }
        int NotaFinalDoJogador = 0;
        string mensagem1 = "Hello World";
        string mensagem2 = "Curso de C# da Caelum";        
        string mensagem3 = "Olá Mundo";
        string mensagem4 = "Caelum";
        string mensagem5 = "Nenhuma das opções";

        private void exer02Iten01Res01_Click(object sender, EventArgs e)
        {
            if (mensagem1 == "Hello World")
            {
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;

                exer02Iten01Res01E.Visible = true;
                exer02Iten01Res01E.ForeColor = Color.Red;
                MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador +" PONTOS", "MAIS ATENÇÃO!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exer02Iten01Res02_Click(object sender, EventArgs e)
        {
            if (mensagem2 == "Curso de C# da Caelum")
            {
                exer02Iten01Res01.Visible = false;
                exer02Iten01Res02.Visible = false;
                exer02Iten01Res03.Visible = false;
                exer02Iten01Res04.Visible = false;
                exer02Iten01Res05.Visible = false;

                exer02Iten01Res02RespC.Visible = true;
                NotaFinalDoJogador = NotaFinalDoJogador + 10;
                exer02Iten01Res02RespC.ForeColor= Color.Red;
                MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador +" PONTOS", "EXCELENTE!",
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

        private void btnProximo_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
