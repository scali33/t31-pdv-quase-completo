namespace t31_projetoBase
{
    partial class frmAlg7
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
            btnSomarFor = new Button();
            btnGauss = new Button();
            label1 = new Label();
            txtNum = new TextBox();
            lstSoma = new ListBox();
            SuspendLayout();
            // 
            // btnSomarFor
            // 
            btnSomarFor.Location = new Point(56, 145);
            btnSomarFor.Name = "btnSomarFor";
            btnSomarFor.Size = new Size(223, 23);
            btnSomarFor.TabIndex = 0;
            btnSomarFor.Text = "Somar o Intervalo(FOR)";
            btnSomarFor.UseVisualStyleBackColor = true;
            btnSomarFor.Click += btnSomarFor_Click;
            // 
            // btnGauss
            // 
            btnGauss.Location = new Point(56, 188);
            btnGauss.Name = "btnGauss";
            btnGauss.Size = new Size(223, 23);
            btnGauss.TabIndex = 1;
            btnGauss.Text = "Somar o intervalo (GAUSS)";
            btnGauss.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Somatoria De 1 até:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(133, 83);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 3;
            // 
            // lstSoma
            // 
            lstSoma.FormattingEnabled = true;
            lstSoma.ItemHeight = 15;
            lstSoma.Location = new Point(350, 83);
            lstSoma.Name = "lstSoma";
            lstSoma.Size = new Size(369, 304);
            lstSoma.TabIndex = 4;
            // 
            // frmAlg7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSoma);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Controls.Add(btnGauss);
            Controls.Add(btnSomarFor);
            Name = "frmAlg7";
            Text = "frmAlg7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomarFor;
        private Button btnGauss;
        private Label label1;
        private TextBox txtNum;
        private ListBox lstSoma;
    }
}