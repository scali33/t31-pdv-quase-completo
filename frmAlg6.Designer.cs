namespace t31_projetoBase
{
    partial class frmAlg6
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
            txtNumeros = new TextBox();
            btnAdd = new Button();
            lboNumeros = new ListBox();
            btnOrdernar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 97);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "informe Os Numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(111, 134);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(229, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lboNumeros
            // 
            lboNumeros.FormattingEnabled = true;
            lboNumeros.ItemHeight = 15;
            lboNumeros.Location = new Point(111, 193);
            lboNumeros.Name = "lboNumeros";
            lboNumeros.Size = new Size(100, 244);
            lboNumeros.TabIndex = 3;
            // 
            // btnOrdernar
            // 
            btnOrdernar.Location = new Point(217, 209);
            btnOrdernar.Name = "btnOrdernar";
            btnOrdernar.Size = new Size(75, 23);
            btnOrdernar.TabIndex = 4;
            btnOrdernar.Text = "Ordem";
            btnOrdernar.UseVisualStyleBackColor = true;
            btnOrdernar.Click += btnOrdernar_Click;
            // 
            // frmAlg6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(btnOrdernar);
            Controls.Add(lboNumeros);
            Controls.Add(btnAdd);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "frmAlg6";
            Text = "frmAlg6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnAdd;
        private ListBox lboNumeros;
        private Button btnOrdernar;
    }
}