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
    public partial class Indice : Form
    {
        public Indice()
        {
            InitializeComponent();
            // O Formulario Indice começam com os objetos invisiveis da linha 19 a 43 invisiveis
            exercicio02.Visible = true;  
            exercicio03.Visible = true;  
            exercicio04.Visible = true; 
            exercicio05.Visible = true; 
            exercicio06.Visible = true;
            exercicio07.Visible = true;  
            exercicio08.Visible = true;  
            exercicio09.Visible = true; 
            exercicio10.Visible = true;  
            exercicio11.Visible = true;
            exercicio12.Visible = true;  
            exercicio13.Visible = true;  
            exercicio14.Visible = true; 
            exercicio15.Visible = true;  
            exercicio16.Visible = true;
            exercicio17.Visible = true;  
            exercicio18.Visible = true;  
            exercicio19.Visible = true; 
            exercicio20.Visible = true;  
            exercicio21.Visible = true;
            exercicio22.Visible = true;  
            exercicio23.Visible = true;  
            exercicio24.Visible = true; 
            exercicio25.Visible = true;  
            exercicio26.Visible = true;

        }
        private void exercicio02_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio... usando o metodo NovaJanela criado no formulario indice
            Exercicio02 NovaJanela = new Exercicio02();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
           //O objeto fica visivel
            exercicio02.Visible = false;
        }
        private void exercicio03_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio... usando o metodo NovaJanela criado no formulario indice
            Exercicio03 NovaJanela = new Exercicio03();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            //O objeto fica visivel;
            exercicio03.Visible = false;
        }
        private void exercicio04_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio... usando o metodo NovaJanela criado no formulario indice
            Exercicio04 NovaJanela = new Exercicio04();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            //O objeto fica visivel
            exercicio04.Visible = false;

        }

        private void exercicio05_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio... usando o metodo NovaJanela criado no formulario indice
            Exercicio05 NovaJanela = new Exercicio05();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            //O objeto fica visivel
            exercicio05.Visible = false;

        }
        private void exercicio06_Click(object sender, EventArgs e)
        {   //Inicia um novo formulario Exercicio... usando o metodo NovaJanela criado no formulario indice 
            Exercicio06 NovaJanela = new Exercicio06();
            //Chama o metodo NovaJanela criado no Form1.cs 
            NovaJanela.Show();
            //O objeto fica visivel
            //exercicio06.Visible = false;
        }
        private void exercicio07_Click(object sender, EventArgs e)
        {

        }


    }
}
