namespace t31_projetoBase
{
    partial class frmPDV
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnRemove = new Button();
            btnConfirm = new Button();
            btnClear = new Button();
            txtPreco = new TextBox();
            txtQuanti = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cboClientes = new ComboBox();
            label5 = new Label();
            btnAdicionar = new Button();
            label6 = new Label();
            lblCpf = new Label();
            lblTotal = new Label();
            btnFinaliza = new Button();
            lblIdvenda = new Label();
            dataGridView2 = new DataGridView();
            txtProdpesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(511, 173);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Produtos";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(9, 271);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(82, 44);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "cancelar venda";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(758, 183);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(121, 24);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Nova venda";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(98, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 44);
            btnClear.TabIndex = 10;
            btnClear.Text = "limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(10, 223);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(73, 23);
            txtPreco.TabIndex = 11;
            // 
            // txtQuanti
            // 
            txtQuanti.Location = new Point(98, 223);
            txtQuanti.Name = "txtQuanti";
            txtQuanti.Size = new Size(69, 23);
            txtQuanti.TabIndex = 12;
            txtQuanti.TextChanged += txtQuanti_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 205);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 13;
            label3.Text = "preço Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 205);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Quantidade";
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(2, 27);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(145, 23);
            cboClientes.TabIndex = 15;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(737, 210);
            label5.Name = "label5";
            label5.Size = new Size(113, 46);
            label5.TabIndex = 16;
            label5.Text = "Total:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(40, 99);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(90, 54);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 53);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 18;
            label6.Text = "Cpf:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(40, 81);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(10, 15);
            lblCpf.TabIndex = 19;
            lblCpf.Text = " ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(856, 223);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 28);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "total";
            // 
            // btnFinaliza
            // 
            btnFinaliza.Location = new Point(758, 269);
            btnFinaliza.Name = "btnFinaliza";
            btnFinaliza.Size = new Size(127, 37);
            btnFinaliza.TabIndex = 21;
            btnFinaliza.Text = "Finalizar venda";
            btnFinaliza.UseVisualStyleBackColor = true;
            btnFinaliza.Click += btnFinaliza_Click;
            // 
            // lblIdvenda
            // 
            lblIdvenda.AutoSize = true;
            lblIdvenda.Location = new Point(729, 18);
            lblIdvenda.Name = "lblIdvenda";
            lblIdvenda.Size = new Size(0, 15);
            lblIdvenda.TabIndex = 23;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(222, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(507, 126);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // txtProdpesquisa
            // 
            txtProdpesquisa.BackColor = SystemColors.HotTrack;
            txtProdpesquisa.Location = new Point(283, 24);
            txtProdpesquisa.Name = "txtProdpesquisa";
            txtProdpesquisa.Size = new Size(158, 23);
            txtProdpesquisa.TabIndex = 25;
            txtProdpesquisa.TextChanged += txtProdpesquisa_TextChanged;
            // 
            // frmPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 375);
            Controls.Add(txtProdpesquisa);
            Controls.Add(dataGridView2);
            Controls.Add(lblIdvenda);
            Controls.Add(btnFinaliza);
            Controls.Add(lblTotal);
            Controls.Add(lblCpf);
            Controls.Add(label6);
            Controls.Add(btnAdicionar);
            Controls.Add(label5);
            Controls.Add(cboClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuanti);
            Controls.Add(txtPreco);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(btnRemove);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmPDV";
            Text = "Mercadinho Ponto de Venda (PDV)";
            Load += frmPDV_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnPesquisar;
        private Label label2;
        private Button btnAdicionar;
        private Button btnRemove;
        private Button btnConfirm;
        private Button btnClear;
        private TextBox textBox2;

        private Label label3;
        private Label label4;
        private ComboBox cboClientes;
        private Label label5;
        private Label label6;
        private Label lblCpf;
        private TextBox txtPreco;
        private TextBox txtQuanti;
        private Label lblTotal;
        private Button btnFinaliza;
        private Label lblIdvenda;
        private DataGridView dataGridView2;
        private TextBox txtProdpesquisa;
    }
}