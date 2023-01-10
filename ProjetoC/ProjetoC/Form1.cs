using System.Drawing.Text;

namespace ProjetoC
{
    public partial class TelaInicial : Form
    {
        Thread nova;
        public TelaInicial()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   /* CONDI��O. (IF=SE O Nome e a  senha tem que ser iguais as que estiverem
                 * cadastradas na condi��o ou no banco de dados*/
                if (txtNome.Text.Equals("W") && txtSenha.Text.Equals("1"))
                {
                    /*As informa��es aqui se estiver iguais ir� para a proxima tela
                    Chamando a variavel (nova) onde a variavel (nova) recebe (Indice) declarada no METODO na linha 49 */
                    this.Close();
                    nova = new Thread(start:abrirJanela);
                    nova.SetApartmentState(ApartmentState.STA);
                    nova.Start();
                   }
                else
                {
                    MessageBox.Show("VOC� ERROU O NOME OU A SENHA TENTE NOVAMENTE", "DESCULPE!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Caso o Nome e a Senha estiverm erradas as palavras digitada dento do TextBox irmao apagar 
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    // O curso ira para o TxtBox Nome
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DESCULPE!", ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void abrirJanela(object obj)
        {
            Application.Run(new Indice());
        }

        // Declarando a fun��o trocar as cores do TextBox quando o cursor estiver selecionado ou n�o
        private void txtNome_Enter(object sender, EventArgs e)
        { //A cor do BoxNome vai estar amarela quando estiver selecionado
            txtNome.BackColor = Color.LightYellow;
        }
        private void txtNome_Leave(object sender, EventArgs e)
        {//A cor do BoxNome vai estar branca quando N�O estiver selecionado
            txtNome.BackColor = Color.White;
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {//A cor do BoxSenha vai estar amarela quando estiver selecionado
            txtSenha.BackColor = Color.LightYellow;
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {//A cor do BoxSenha vai estar branca quando N�O estiver selecionado
            txtSenha.BackColor = Color.White;
        }
        //Declarar a fun��o digitar dentro da BoxNome
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Declarando uma variavel para a tecla BackSpace com o numero 08
            int tecla = (int)e.KeyChar;
            //A caixa so aceita que seja inserido apenas letras e a tecla BackSpace  
            if (!char.IsLetter(e.KeyChar) && tecla != 08)
            {
                //Caso seja inserido numero ou letra n�o aceita
                e.Handled = true;
                //Mensagem de aviso que so aceita letras no campo
                MessageBox.Show("Digite apenas letras", "Erro na digita��o!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                /*A o texto da caixa onde contem as palavras digitadas v�o ficar selecionas ap�s
                aparecer a mensagem de "Digite apenas letras" quando for digitado coisas que n�o for letra */
                txtNome.SelectionStart = 0;
                txtNome.SelectionLength = txtNome.Text.Length;

                //O Foco retorna para o BoxNome
                txtNome.Focus();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}