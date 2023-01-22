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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
            //Inicia o formulario Exercicio05 com os objetos invisiveis da linha 20 ate a linha 24
            Exc0501B1.Visible = false;
            Exc0501B2.Visible = false;
            Exc0501B3.Visible = false;
            Exc0501B4.Visible = false;
            label6.Visible = false;

        }
        //Decrando a variavel int NotaFinalDoJogador para somar e usar no Formaulario PlacarFinal
        int NotaFinalDoJogador = 0;

        //Inicia um metodo Exc0501A2_Click
        private void Exc0501A2_Click(object sender, EventArgs e)
        {//coloca os objetos da lina 32 ate a 35 invisiveis
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;
            //Coloca o objeto Exc0501B2 visivel
            Exc0501B2.Visible = true;
            //Soma + 10 a sua pontuação NotaFinalDoJogador.
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            //Coloca o objeto Exc0501B2 com a cor vermelha
            Exc0501B2.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ACERTOU GANHOU "
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Inicia um metodo Exc0501A1_Click
        private void Exc0501A1_Click(object sender, EventArgs e)
        {//coloca os objetos da lina 50 ate a 53 invisiveis
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;
            //Coloca o objeto Exc0501B1 visivel
            Exc0501B1.Visible = true;
            //Coloca o objeto Exc0501B1 com a cor vermelha
            Exc0501B1.ForeColor = Color.Red;
            //Aparece uma caixa de mensagem como o texto "VOCÊ ERROU NÃO GANHOU "
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0501A3_Click(object sender, EventArgs e)
        {
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;

            Exc0501B3.Visible = true;
            Exc0501B3.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0501A4_Click(object sender, EventArgs e)
        {
            Exc0501A1.Visible = false;
            Exc0501A2.Visible = false;
            Exc0501A3.Visible = false;
            Exc0501A4.Visible = false;

            Exc0501B4.Visible = true;
            Exc0501B4.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Inicia um metodo button1_Click
        private void button1_Click(object sender, EventArgs e)
        {   //Decalra uma variavel int soma e atribui 0 para ela
            int soma = 0;
            //Decalra uma variavel int acrescente e atribui 1 para ela
            int acrescente = 1;
            //Enquanto mais for menor ou igual a 1000
            while (acrescente <= 1000)
            {   //faça soma recebe soma + o valor que estiver na variavel acrescente
                soma = soma + acrescente;
                //Adicione + 1 a variavel acrescente
                acrescente++;
            }
            //Aparece uma caixa de mensagem como o texto "A soma dos números de 1 a 100 é igual a + o resultado da variavel soma
            MessageBox.Show("A soma dos números de 1 a 100 é igual a= " + soma);

        }
        //Inicia um metodo button2_Click
        private void button2_Click(object sender, EventArgs e)
        {   //Declara uma variavel string com o texto vazio
            string linha5 = "";
            //Para a variavel int igual a i, i menor que 100 some 1 a i
            for (int i = 1; i <= 100; i++)
            {   //se o resultado de i for divisivel por 3 e o resto for = a 0
                if (i % 3 == 0)
                {   // A variavel linha5 recebe ", " mais o valor de i
                    linha5 += ", " + i;
                    // converte o objeto label6 e escreva Números divisiveis por 3. Pula uma linha e traga o resulta da variavel linha5
                    label6.Text = Convert.ToString("Números Divisíveis por 3:\n" +
                       "" + linha5);
                    // O objeto label6 fica visivel
                    label6.Visible = true;
                    // O objeto label6 fica vermelho
                    label6.ForeColor = Color.Red;
                    // O objeto button2 fica invisivel
                    button2.Visible = false;
                }
            }
        }
        //Inicia um metodo button3_Click
        private void button3_Click(object sender, EventArgs e)
        {   //Declare uma variavel var a numeroInicial e inicie com o 1
            var numeroInicial = 1;
            //Declare uma variavel var a numeroFinal e inicie com o 100
            var numeroFinal = 100;
            //Declare uma variavel var a soma e inicie com o 0
            var soma = 0;
            //para a variavel int numeroAtual receba o numeroInicial e numeroAtual for menor ou igual ao numeroFinal o numeroAtual recebe +1
            for (int numeroAtual = numeroInicial; numeroAtual <= numeroFinal; numeroAtual++)
            {    //variavel var ehMultiploDeTres recebe numeroAtual se for divisivel por 3 e o resto for = a 0
                var ehMultiploDeTres = numeroAtual % 3 == 0;
                //Se ehMultiploDeTres
                if (ehMultiploDeTres)
                    //continue
                    continue;
                // Variavel soma recebe o valor de numeroAtual
                soma += numeroAtual;
            }
            //Aparece uma caixa de mensagem como o texto "O resultado é " + resultado da variavel soma
            MessageBox.Show(string.Concat("O resultado é ", soma), "Resultado");

        }
        //Inicia um metodo button4_Click
        private void button4_Click(object sender, EventArgs e)
        {   //Declarando uma variavel string a linha3 e inicia vazio
            string linha3 = "";
            //Declarando uma variavel string a linha4 e inicia vazio
            string linha4 = "";
            //Para varivel int i igual a 1, i menor ou igual a 30 some mais 1 a i
            for (int i = 1; i <= 30; i++)
            {   //Se for divisivel por 3 e o resto for = a 0 
                if (i % 3 == 0)
                {  //Faça linha3 receber " - " mais o valor de i
                    linha3 += " - " + i;
                }
                //Senão se for divisivel por 4 e o resto for = a 0
                else if (i % 4 == 0)
                {   //Faça linha4 receber " - " mais o valor de i
                    linha4 += " - " + i;
                }
            }
            //Aparece uma caixa de mensagem como o texto Por 3: mais o resultado de linha3. Pula uma linha e escreve Por 4: mais o resultado de linha4
            MessageBox.Show("Por 3: " + linha3 + "\n Por 4: " + linha4 + ".", "OS NÚMEROS DIVISÍVEIS POR 3 E POR 4 DE 1 A 30 SÃO",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Inicia um metodo button5_Click
        private void button5_Click(object sender, EventArgs e)
        {   //Declara uma variavel int com o nome fatorial recebe o valor de 1
            int fatorial = 1;
            //Para a variavel int com o nome n recebe 1, n for menor ou igual a 10 some 1 a n
            for (int n = 1; n <= 10; n++)
            {   // a variavel fatorial recebe ela multiplicado pelo n
                fatorial = fatorial * n;
                //Aparece uma caixa de mensagem como o texto O fatorial de resultado n é resultado de fatorial
                MessageBox.Show("O fatorial de " + n + " é : " + fatorial + ".", "O NÚMERO FATORIAL DE 1 A 10 NA SEQUÊNCIA É:",
                MessageBoxButtons.OK);
            }
        }
        //Inicia o metodo button6_Click
        private void button6_Click(object sender, EventArgs e)
        {   /*Declarando uma variavel do tipo int como o nome a recebendo o valor de 0,
            e b recebendo o valor de 1*/
            int a = 0, b = 1;
            //Declarando uma variavel do tipo int com o nome i recebendo o valor de 100
            int i = 100;
            //Declarando uma variavel do tipo int com o nome  fibo recebendo o valor 0
            int fibo = 0;
            //Para a variavel int recebendo o nome j iniciando com 1 , b for menor que 100 some + 1 a j
            for (int j = 1; b < 100; j++)
            {   //Variavel fibo recebe a variavel a
                fibo = a;
                //Variavel a recebe a variavel b
                a = b;
                //Variavel b recebe resultado da variavel fibo mais o resultado da variavel b
                b = fibo + b;
                //Aparece uma caixa de mensagem como o texto A série de Fibonacci é a seguinte: mais o resultado da variavel b
                MessageBox.Show("A série de Fibonacci é a seguinte: " + b);
            }

        }
        //Iniciando um metodo button7_Click
        private void button7_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio05Pagina01 usando o metodo NovaJanela criado no formulario indice 
            Exercicio05Pagina01 NovaJanela = new Exercicio05Pagina01();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            {
                //Fecha o formulario Exercicio05.cs
                this.Close();
            }
        }
    }
}

