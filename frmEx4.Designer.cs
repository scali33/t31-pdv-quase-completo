namespace t31_projetoBase
{
    partial class frmEx4
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
            btnAdivi = new Button();
            txtNum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdivi
            // 
            btnAdivi.Location = new Point(136, 92);
            btnAdivi.Name = "btnAdivi";
            btnAdivi.Size = new Size(96, 38);
            btnAdivi.TabIndex = 0;
            btnAdivi.Text = "Comfirmar";
            btnAdivi.UseVisualStyleBackColor = true;
            btnAdivi.Click += btnAdivi_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(110, 63);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 23);
            txtNum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 45);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 2;
            label1.Text = "Adivinhe os numeros 1 a 100";
            // 
            // frmEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(label1);
            Controls.Add(txtNum);
            Controls.Add(btnAdivi);
            Name = "frmEx4";
            Text = "frmEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdivi;
        private TextBox txtNum;
        private Label label1;
    }
}