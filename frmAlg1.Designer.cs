namespace t31_projetoBase
{
    partial class frmAlg1
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
            label3 = new Label();
            label4 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            txtN4 = new TextBox();
            btnCalc = new Button();
            lblResul = new Label();
            lblstatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "nota1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 71);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "nota2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 103);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "nota3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 138);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "nota4";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(136, 33);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(136, 68);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 5;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(136, 103);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(100, 23);
            txtN3.TabIndex = 6;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(136, 138);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(100, 23);
            txtN4.TabIndex = 7;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(381, 34);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(157, 57);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "Calcular Media";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.ForeColor = Color.FromArgb(0, 0, 192);
            lblResul.Location = new Point(136, 198);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(92, 15);
            lblResul.TabIndex = 9;
            lblResul.Text = "-----------------";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(397, 105);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(47, 15);
            lblstatus.TabIndex = 10;
            lblstatus.Text = ">>>>>";
            // 
            // frmAlg1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 261);
            Controls.Add(lblstatus);
            Controls.Add(lblResul);
            Controls.Add(btnCalc);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg1";
            Text = "Algoritiom01";
            Load += frmAlg1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN4;
        private Button btnCalc;
        private Label lblResul;
        private Label lblstatus;
    }
}