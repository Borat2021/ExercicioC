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
    public partial class Exercicio05Pagina01 : Form
    {
        public Exercicio05Pagina01()
        {
            InitializeComponent();
        }
        //Inicia um metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        {   //Declara uma variavel int com o nome calculo 
            int calculo;
            //Declara uma variavel string com o nome tabela inicia vazia 
            string tabela = "";
            //Para a variavel int com o nome i recebendo 1, i menor ou igual a 5 some mais 1 a i
            for (int i = 1; i <= 5; i++)
            {
                //Para a variavel int com o nome j recebendo 1, j menor ou igual a i some mais 1 a j
                for (int j = 1; j <= i; j++)
                {
                    //Variavel calculo recebe a variavel i multiplicado pela variavel j
                    calculo = i * j;
                    //Variavel tabela recebe a variavel tabela mais a varavel calculo mais " "
                    tabela = tabela + calculo + " ";
                }
                //Variavel tabela recebe tabela e pula uma linha
                tabela += "\n";
            }
            //Aparece uma caixa de mensagem como o resultado da variavel tabela
            MessageBox.Show($"{tabela}");
        }
        //Iniciando um metodo button2_Click
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha o formulario Exercicio05Pagina01.cs
            this.Close();
        }
    }
}

