namespace ProjetoC
{
    partial class Exercicio04Pagina01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio04Pagina01));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValorDaNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnImposto = new System.Windows.Forms.Button();
            this.TxtTaxa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor";
            // 
            // textBoxValorDaNotaFiscal
            // 
            this.textBoxValorDaNotaFiscal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxValorDaNotaFiscal.Location = new System.Drawing.Point(351, 48);
            this.textBoxValorDaNotaFiscal.Name = "textBoxValorDaNotaFiscal";
            this.textBoxValorDaNotaFiscal.Size = new System.Drawing.Size(152, 29);
            this.textBoxValorDaNotaFiscal.TabIndex = 2;
            // 
            // btnImposto
            // 
            this.btnImposto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImposto.Location = new System.Drawing.Point(351, 83);
            this.btnImposto.Name = "btnImposto";
            this.btnImposto.Size = new System.Drawing.Size(152, 35);
            this.btnImposto.TabIndex = 3;
            this.btnImposto.Text = "Calcular Imposto";
            this.btnImposto.UseVisualStyleBackColor = true;
            this.btnImposto.Click += new System.EventHandler(this.btnImposto_Click);
            // 
            // TxtTaxa
            // 
            this.TxtTaxa.AutoSize = true;
            this.TxtTaxa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTaxa.Location = new System.Drawing.Point(529, 48);
            this.TxtTaxa.Name = "TxtTaxa";
            this.TxtTaxa.Size = new System.Drawing.Size(50, 25);
            this.TxtTaxa.TabIndex = 4;
            this.TxtTaxa.Text = "Taxa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 210);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(205, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resposta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(655, 63);
            this.label4.TabIndex = 7;
            this.label4.Text = "int valor =15;\r\nstring mensagem\"\";\r\nmensagem +=valor >10 ? mensagem = \"Maior que " +
    "dez\" : mensagem = \"Menor que dez\";";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(455, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Índice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exercicio04Pagina01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTaxa);
            this.Controls.Add(this.btnImposto);
            this.Controls.Add(this.textBoxValorDaNotaFiscal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Exercicio04Pagina01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio04Pagina01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnImposto;
        private TextBox textBoxValorDaNotaFiscal;
        private Label TxtTaxa;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
    }
}