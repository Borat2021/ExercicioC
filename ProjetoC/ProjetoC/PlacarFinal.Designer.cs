namespace ProjetoC
{
    partial class PlacarFinal
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
            this.Nome = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.Label();
            this.NomeDoJogador = new System.Windows.Forms.Label();
            this.NotaFinalDoJogador = new System.Windows.Forms.Label();
            this.SairDoJogo = new System.Windows.Forms.Button();
            this.RetornarIndice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(12, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(56, 21);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // Nota
            // 
            this.Nota.AutoSize = true;
            this.Nota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nota.Location = new System.Drawing.Point(12, 42);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(84, 21);
            this.Nota.TabIndex = 1;
            this.Nota.Text = "Nota Final:";
            // 
            // NomeDoJogador
            // 
            this.NomeDoJogador.AutoSize = true;
            this.NomeDoJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomeDoJogador.Location = new System.Drawing.Point(64, 6);
            this.NomeDoJogador.Name = "NomeDoJogador";
            this.NomeDoJogador.Size = new System.Drawing.Size(166, 25);
            this.NomeDoJogador.TabIndex = 2;
            this.NomeDoJogador.Text = "Nome do Jogador";
            // 
            // NotaFinalDoJogador
            // 
            this.NotaFinalDoJogador.AutoSize = true;
            this.NotaFinalDoJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NotaFinalDoJogador.Location = new System.Drawing.Point(92, 42);
            this.NotaFinalDoJogador.Name = "NotaFinalDoJogador";
            this.NotaFinalDoJogador.Size = new System.Drawing.Size(101, 25);
            this.NotaFinalDoJogador.TabIndex = 3;
            this.NotaFinalDoJogador.Text = "Nota Final";
            // 
            // SairDoJogo
            // 
            this.SairDoJogo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SairDoJogo.Location = new System.Drawing.Point(192, 94);
            this.SairDoJogo.Name = "SairDoJogo";
            this.SairDoJogo.Size = new System.Drawing.Size(90, 41);
            this.SairDoJogo.TabIndex = 4;
            this.SairDoJogo.Text = "Sair";
            this.SairDoJogo.UseVisualStyleBackColor = true;
            // 
            // RetornarIndice
            // 
            this.RetornarIndice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RetornarIndice.Location = new System.Drawing.Point(12, 94);
            this.RetornarIndice.Name = "RetornarIndice";
            this.RetornarIndice.Size = new System.Drawing.Size(93, 39);
            this.RetornarIndice.TabIndex = 5;
            this.RetornarIndice.Text = "Índice";
            this.RetornarIndice.UseVisualStyleBackColor = true;
            // 
            // PlacarFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 151);
            this.Controls.Add(this.RetornarIndice);
            this.Controls.Add(this.SairDoJogo);
            this.Controls.Add(this.NotaFinalDoJogador);
            this.Controls.Add(this.NomeDoJogador);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.Nome);
            this.Name = "PlacarFinal";
            this.Text = "PlacarFinal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label Nota;
        private Label NomeDoJogador;
        private Label NotaFinalDoJogador;
        private Button SairDoJogo;
        private Button RetornarIndice;
    }
}