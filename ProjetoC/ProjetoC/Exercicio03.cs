﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
            label6.Visible =true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            txtMediaPessoa.Visible=false;
            label4.Visible=true;
            label13.Visible=true;
            label14.Visible=true;
            label15.Visible=false;
            label16.Visible=false;
            label17.Visible=false;

        }
        int NotaFinalDoJogador = 0;



        private void btnCalcular_Click(object sender, EventArgs e)
        {   string nomepessoa1;
            int idadepessoal1=0;
            string nomepessoa2;
            int idadepessoal2=0;
            string nomepessoa3;
            int idadepessoal3 = 0;   
                       
            double media;

            nomepessoa1 = textPessoa1.Text;
            idadepessoal1=Convert.ToInt32(textIdadePessoa1.Text);
            nomepessoa2= textPessoa2.Text;
            idadepessoal2= Convert.ToInt32(textIdadePessoa2.Text);
            nomepessoa3= textPessoa3.Text;
            idadepessoal3= Convert.ToInt32(textIdadePessoa3.Text);
            media = (idadepessoal1 + idadepessoal2 + idadepessoal3) / 3;
            txtMediaPessoa.Text = Convert.ToString(media);
            txtMediaPessoa.Visible= true;




            MessageBox.Show("Primeiro nome: " + nomepessoa1+ " sua idade é, "+ idadepessoal1+" anos;"+ "\n Segundo nome: " + nomepessoa2+ 
                " sua idade é, " + idadepessoal2+ "anos; "+" \n Terceiro nome: " + nomepessoa3+ " sua idade é, " + idadepessoal3+" anos"+ 
                "\n A média de idade das pessoas é: "+ media);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible= true;
            label9.ForeColor = Color.Red;
            MessageBox.Show("VOCÊ ERROU NÃO GANHOU " + NotaFinalDoJogador + " PONTOS", "MAIS ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void label8_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label11.Visible = true;
            NotaFinalDoJogador = NotaFinalDoJogador + 10;
            label11.ForeColor = Color.Red;
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

        private void btnCalcularD_Click(object sender, EventArgs e)
        {

        }
    }
}