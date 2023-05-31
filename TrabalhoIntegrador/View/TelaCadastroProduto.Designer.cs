namespace TrabalhoIntegrador.View
{
    partial class TelaCadastroProduto
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
            label1 = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnGravar = new Button();
            dgvCadastroProduto = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCadastroProduto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(213, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(61, 49);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(146, 265);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(61, 49);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(79, 265);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(61, 49);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(12, 265);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(61, 49);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // dgvCadastroProduto
            // 
            dgvCadastroProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadastroProduto.Location = new Point(363, 58);
            dgvCadastroProduto.Name = "dgvCadastroProduto";
            dgvCadastroProduto.RowTemplate.Height = 25;
            dgvCadastroProduto.Size = new Size(329, 250);
            dgvCadastroProduto.TabIndex = 7;
            dgvCadastroProduto.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(363, 17);
            label2.Name = "label2";
            label2.Size = new Size(228, 30);
            label2.TabIndex = 8;
            label2.Text = "Relatorio de Produtos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 9;
            label3.Text = "Categoria do Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 58);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 10;
            label4.Text = "Nome do Produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 11;
            label5.Text = "Valor do Produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 23);
            comboBox1.TabIndex = 14;
            // 
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(704, 320);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCadastroProduto);
            Controls.Add(btnGravar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Name = "TelaCadastroProduto";
            Text = "TelaCadastroProduto";
            Load += TelaCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCadastroProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnGravar;
        private DataGridView dgvCadastroProduto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}