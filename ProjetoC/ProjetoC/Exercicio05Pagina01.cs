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

        private void button1_Click(object sender, EventArgs e)
        {
            int calculo;
            string tabela = "";
            for (int i = 1; i <= 5; i++) {
                for (int j = 1; j <= i; j++){
                    calculo = i * j;
                    tabela = tabela + calculo + " ";
                }
                tabela += "\n";            
            }MessageBox.Show($"{tabela}");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

