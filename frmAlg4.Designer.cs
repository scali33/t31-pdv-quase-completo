namespace t31_projetoBase
{
    partial class frmAlg4
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
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            btnCalc = new Button();
            label4 = new Label();
            txtImc = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 42);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Calcule seu IMC :)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 124);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 172);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "peso";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(159, 121);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 3;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(159, 164);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(159, 237);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(100, 35);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calcular imc";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 320);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "IMC";
            // 
            // txtImc
            // 
            txtImc.Location = new Point(159, 312);
            txtImc.Name = "txtImc";
            txtImc.ReadOnly = true;
            txtImc.Size = new Size(100, 23);
            txtImc.TabIndex = 7;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(159, 369);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(82, 15);
            lblResult.TabIndex = 8;
            lblResult.Text = "---------------";
            // 
            // frmAlg4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(lblResult);
            Controls.Add(txtImc);
            Controls.Add(label4);
            Controls.Add(btnCalc);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg4";
            Text = "Algoritimo 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btnCalc;
        private Label label4;
        private TextBox txtImc;
        private Label lblResult;
    }
}