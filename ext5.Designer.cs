namespace t31_projetoBase
{
    partial class ext5
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
            lblPalavra = new Label();
            btnComfirmar = new Button();
            txtLetra = new TextBox();
            btnRodar = new Button();
            label1 = new Label();
            lblVidas = new Label();
            lbl = new Label();
            SuspendLayout();
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Location = new Point(181, 129);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(38, 15);
            lblPalavra.TabIndex = 0;
            lblPalavra.Text = "label1";
            // 
            // btnComfirmar
            // 
            btnComfirmar.Location = new Point(170, 86);
            btnComfirmar.Name = "btnComfirmar";
            btnComfirmar.Size = new Size(75, 23);
            btnComfirmar.TabIndex = 1;
            btnComfirmar.Text = "Comfirmar";
            btnComfirmar.UseVisualStyleBackColor = true;
            btnComfirmar.Click += btnComfirmar_Click;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(150, 41);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(110, 23);
            txtLetra.TabIndex = 2;
            // 
            // btnRodar
            // 
            btnRodar.Location = new Point(12, 12);
            btnRodar.Name = "btnRodar";
            btnRodar.Size = new Size(75, 23);
            btnRodar.TabIndex = 3;
            btnRodar.Text = "Outra";
            btnRodar.UseVisualStyleBackColor = true;
            btnRodar.Click += btnRodar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "você tem ";
            // 
            // lblVidas
            // 
            lblVidas.AutoSize = true;
            lblVidas.Location = new Point(362, 15);
            lblVidas.Name = "lblVidas";
            lblVidas.Size = new Size(13, 15);
            lblVidas.TabIndex = 5;
            lblVidas.Text = "6";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(380, 16);
            lbl.Name = "lbl";
            lbl.Size = new Size(35, 15);
            lbl.TabIndex = 6;
            lbl.Text = "Vidas";
            // 
            // ext5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 206);
            Controls.Add(lbl);
            Controls.Add(lblVidas);
            Controls.Add(label1);
            Controls.Add(btnRodar);
            Controls.Add(txtLetra);
            Controls.Add(btnComfirmar);
            Controls.Add(lblPalavra);
            Name = "ext5";
            Text = "ext5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalavra;
        private Button btnComfirmar;
        private TextBox txtLetra;
        private Button btnRodar;
        private Label label1;
        private Label lblVidas;
        private Label lbl;
    }
}