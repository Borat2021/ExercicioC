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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
            
            Exc0401A2.Visible= false;  Exc0401B2.Visible= false;  Exc0401C2.Visible= false;  Exc0401D2.Visible = false; Exc0401E2.Visible = false;


        }
        int NotaFinalDoJogador =0;

        private void Exc0401A1_Click(object sender, EventArgs e)
        {           
            Exc0401A2.Visible = true;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible= false;
            Exc0401D1.Visible= false;
            Exc0401E1.Visible= false;

            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            Exc0401A2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ACERTOU GANHOU " + NotaFinalDoJogador + " PONTOS", "EXCELENTE!",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Exc0401B1_Click(object sender, EventArgs e)
        {
            Exc0401A1.Visible= false;
            Exc0401B1.Visible= false;
            Exc0401B2.Visible= true;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible = false;
            Exc0401E1.Visible = false;

            Exc0401B2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0401C1_Click(object sender, EventArgs e)
        {
            Exc0401C1.Visible = false;
            Exc0401C2.Visible= true;
            Exc0401D1.Visible= false;
            Exc0401E1.Visible= false;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;

            Exc0401C2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0401D1_Click(object sender, EventArgs e)
        {
            Exc0401D1.Visible=false;
            Exc0401D2.Visible= true;
            Exc0401E1.Visible=false;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible= false;

            Exc0401D2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Exc0401E1_Click(object sender, EventArgs e)
        {
            Exc0401E1.Visible= false;
            Exc0401E2.Visible= true;
            Exc0401A1.Visible = false;
            Exc0401B1.Visible = false;
            Exc0401C1.Visible = false;
            Exc0401D1.Visible= false;

            Exc0401E2.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    }

