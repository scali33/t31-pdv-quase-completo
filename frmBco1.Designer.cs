namespace t31_projetoBase
{
    partial class frmBco1
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
            dgvCategories = new DataGridView();
            btnCarregar = new Button();
            cboSuppliers = new ComboBox();
            btnCarregarcombo = new Button();
            btnSelectFromBco = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(12, 53);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(766, 293);
            dgvCategories.TabIndex = 0;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 352);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(126, 41);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar Grid";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // cboSuppliers
            // 
            cboSuppliers.FormattingEnabled = true;
            cboSuppliers.Location = new Point(567, 352);
            cboSuppliers.Name = "cboSuppliers";
            cboSuppliers.Size = new Size(192, 23);
            cboSuppliers.TabIndex = 2;
            // 
            // btnCarregarcombo
            // 
            btnCarregarcombo.Location = new Point(435, 352);
            btnCarregarcombo.Name = "btnCarregarcombo";
            btnCarregarcombo.Size = new Size(126, 41);
            btnCarregarcombo.TabIndex = 1;
            btnCarregarcombo.Text = "Carregar Combo Box";
            btnCarregarcombo.UseVisualStyleBackColor = true;
            btnCarregarcombo.Click += btnCarregarcombo_Click;
            // 
            // btnSelectFromBco
            // 
            btnSelectFromBco.Enabled = false;
            btnSelectFromBco.Location = new Point(435, 397);
            btnSelectFromBco.Name = "btnSelectFromBco";
            btnSelectFromBco.Size = new Size(126, 41);
            btnSelectFromBco.TabIndex = 1;
            btnSelectFromBco.Text = "select item from Cbo";
            btnSelectFromBco.UseVisualStyleBackColor = true;
            btnSelectFromBco.Click += btnSelectFromBco_Click;
            // 
            // frmBco1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSuppliers);
            Controls.Add(btnSelectFromBco);
            Controls.Add(btnCarregarcombo);
            Controls.Add(btnCarregar);
            Controls.Add(dgvCategories);
            Name = "frmBco1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategories;
        private Button btnCarregar;
        private ComboBox cboSuppliers;
        private Button btnCarregarcombo;
        private Button btnSelectFromBco;
    }
}