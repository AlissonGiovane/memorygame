namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Variável necessária para suporte ao designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera os recursos utilizados pela aplicação.
        /// </summary>
        /// <param name="disposing">True se os recursos gerenciados devem ser descartados; False caso contrário.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado automaticamente pelo Designer de Formulário do Windows

        /// <summary>
        /// Inicializa os componentes visuais do formulário.
        /// Este método é gerado automaticamente e não deve ser editado manualmente.
        /// </summary>
        private void InitializeComponent()
        {
            // Instanciando os componentes e containers necessários
            this.components = new System.ComponentModel.Container();

            // Configurando a tabela principal para os itens do jogo
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

            // Criando os rótulos (labels) para o jogo da memória
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            // Timer para controlar o tempo entre os cliques do jogador
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            // Configurando o layout da tabela
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray; // Alterado para uma cor mais escura
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4; // Dividido em 4 colunas
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            // Adicionando os rótulos no layout em suas respectivas posições
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);

            // Configurando o estilo geral da tabela
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill; // Preencher todo o formulário
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4; // Dividido em 4 linhas
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.TabIndex = 0;

            // Personalizando os rótulos
            foreach (var label in new System.Windows.Forms.Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16 })
            {
                label.Dock = System.Windows.Forms.DockStyle.Fill;
                label.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
                label.ForeColor = System.Drawing.Color.LightGray; // Texto em uma cor clara para contraste
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Text = "?"; // Ícone inicial oculto
                label.Click += new System.EventHandler(this.label_click);
            }

            // Configuração inicial do formulário
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Jogo da Memória";

            // Finalizando a configuração
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16, label15, label14, label13, label12, label11, label10, label9, label8, label7, label6, label5, label4, label3, label2, label1;
        private System.Windows.Forms.Timer timer1;
    }
}
