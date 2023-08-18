namespace t31_projetoBase
{
    partial class frmAlg3
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
            label2 = new Label();
            txtval1 = new TextBox();
            txtval2 = new TextBox();
            btnsoma = new Button();
            btnsub = new Button();
            btnmulti = new Button();
            btndiv = new Button();
            lblResul = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 75);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 117);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "valor 2";
            // 
            // txtval1
            // 
            txtval1.Location = new Point(123, 67);
            txtval1.Name = "txtval1";
            txtval1.Size = new Size(100, 23);
            txtval1.TabIndex = 2;
            // 
            // txtval2
            // 
            txtval2.Location = new Point(123, 114);
            txtval2.Name = "txtval2";
            txtval2.Size = new Size(100, 23);
            txtval2.TabIndex = 3;
            // 
            // btnsoma
            // 
            btnsoma.Location = new Point(264, 66);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(75, 23);
            btnsoma.TabIndex = 4;
            btnsoma.Text = "somar";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // btnsub
            // 
            btnsub.Location = new Point(264, 95);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(75, 23);
            btnsub.TabIndex = 5;
            btnsub.Text = "subtrair";
            btnsub.UseVisualStyleBackColor = true;
            btnsub.Click += btnsub_Click;
            // 
            // btnmulti
            // 
            btnmulti.Location = new Point(264, 124);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(75, 23);
            btnmulti.TabIndex = 6;
            btnmulti.Text = "multiplicar";
            btnmulti.UseVisualStyleBackColor = true;
            btnmulti.Click += btnmulti_Click;
            // 
            // btndiv
            // 
            btndiv.Location = new Point(264, 153);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(75, 23);
            btndiv.TabIndex = 7;
            btndiv.Text = "dividir";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.BackColor = Color.FromArgb(192, 255, 255);
            lblResul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResul.ForeColor = Color.Red;
            lblResul.Location = new Point(123, 219);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(74, 15);
            lblResul.TabIndex = 8;
            lblResul.Text = "RESULTADO";
            // 
            // frmAlg3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 332);
            Controls.Add(lblResul);
            Controls.Add(btndiv);
            Controls.Add(btnmulti);
            Controls.Add(btnsub);
            Controls.Add(btnsoma);
            Controls.Add(txtval2);
            Controls.Add(txtval1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg3";
            Text = "frmAlg3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtval1;
        private TextBox txtval2;
        private Button btnsoma;
        private Button btnsub;
        private Button btnmulti;
        private Button btndiv;
        private Label lblResul;
    }
}