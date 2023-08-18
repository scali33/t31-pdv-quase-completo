namespace t31_projetoBase
{
    partial class frmAlg5
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
            txtNum = new TextBox();
            lboResultado = new ListBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 111);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe a tabuada";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(252, 103);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(58, 23);
            txtNum.TabIndex = 1;
            // 
            // lboResultado
            // 
            lboResultado.FormattingEnabled = true;
            lboResultado.ItemHeight = 15;
            lboResultado.Location = new Point(252, 158);
            lboResultado.Name = "lboResultado";
            lboResultado.Size = new Size(120, 199);
            lboResultado.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(122, 158);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(124, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calcular Tabuada";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // frmAlg5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(btnCalc);
            Controls.Add(lboResultado);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "frmAlg5";
            Text = "Algoritimo 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private ListBox lboResultado;
        private Button btnCalc;
    }
}