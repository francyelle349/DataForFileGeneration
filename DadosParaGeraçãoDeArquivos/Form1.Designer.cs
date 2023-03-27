namespace DadosParaGeraçãoDeArquivos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.txtNFuncionarios = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCriarLinhas);
            this.panel1.Controls.Add(this.txtNFuncionarios);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N de Funcionários";
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.BackColor = System.Drawing.Color.Linen;
            this.btnCriarLinhas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarLinhas.Location = new System.Drawing.Point(198, 19);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(235, 22);
            this.btnCriarLinhas.TabIndex = 1;
            this.btnCriarLinhas.Text = "Criar Linhas para arquivo";
            this.btnCriarLinhas.UseVisualStyleBackColor = false;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // txtNFuncionarios
            // 
            this.txtNFuncionarios.Location = new System.Drawing.Point(110, 21);
            this.txtNFuncionarios.Name = "txtNFuncionarios";
            this.txtNFuncionarios.Size = new System.Drawing.Size(70, 20);
            this.txtNFuncionarios.TabIndex = 0;
            this.txtNFuncionarios.TextChanged += new System.EventHandler(this.txtNFuncionarios_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.btnCriarArquivo);
            this.panel2.Controls.Add(this.BtnReiniciar);
            this.panel2.Location = new System.Drawing.Point(1, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 58);
            this.panel2.TabIndex = 2;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.BackColor = System.Drawing.Color.Linen;
            this.btnCriarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarArquivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCriarArquivo.Location = new System.Drawing.Point(11, 19);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(243, 22);
            this.btnCriarArquivo.TabIndex = 2;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = false;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.BackColor = System.Drawing.Color.Linen;
            this.BtnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReiniciar.Location = new System.Drawing.Point(270, 19);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(163, 22);
            this.BtnReiniciar.TabIndex = 1;
            this.BtnReiniciar.Text = "Reiniciar";
            this.BtnReiniciar.UseVisualStyleBackColor = false;
            this.BtnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dados Para Geração De Arquivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.TextBox txtNFuncionarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.Label label1;
    }
}

