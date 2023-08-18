namespace t31_projetoBase
{
    partial class frmEx6
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
            txtCentena = new TextBox();
            txtDezena = new TextBox();
            txtUnidade = new TextBox();
            btnRodar = new Button();
            btnRodar_para = new Button();
            txtNaosei = new TextBox();
            SuspendLayout();
            // 
            // txtCentena
            // 
            txtCentena.Location = new Point(74, 37);
            txtCentena.Name = "txtCentena";
            txtCentena.Size = new Size(24, 23);
            txtCentena.TabIndex = 0;
            // 
            // txtDezena
            // 
            txtDezena.Location = new Point(104, 37);
            txtDezena.Name = "txtDezena";
            txtDezena.Size = new Size(23, 23);
            txtDezena.TabIndex = 1;
            // 
            // txtUnidade
            // 
            txtUnidade.Location = new Point(133, 37);
            txtUnidade.Name = "txtUnidade";
            txtUnidade.Size = new Size(23, 23);
            txtUnidade.TabIndex = 2;
            // 
            // btnRodar
            // 
            btnRodar.Location = new Point(74, 66);
            btnRodar.Name = "btnRodar";
            btnRodar.Size = new Size(82, 23);
            btnRodar.TabIndex = 3;
            btnRodar.Text = "Rodar";
            btnRodar.UseVisualStyleBackColor = true;
            btnRodar.Click += btnRodar_Click;
            // 
            // btnRodar_para
            // 
            btnRodar_para.Location = new Point(65, 95);
            btnRodar_para.Name = "btnRodar_para";
            btnRodar_para.Size = new Size(104, 23);
            btnRodar_para.TabIndex = 4;
            btnRodar_para.Text = "Rodar Parar em..";
            btnRodar_para.UseVisualStyleBackColor = true;
            btnRodar_para.Click += btnRodar_para_Click;
            // 
            // txtNaosei
            // 
            txtNaosei.Location = new Point(69, 124);
            txtNaosei.Name = "txtNaosei";
            txtNaosei.Size = new Size(100, 23);
            txtNaosei.TabIndex = 5;
            // 
            // frmEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 291);
            Controls.Add(txtNaosei);
            Controls.Add(btnRodar_para);
            Controls.Add(btnRodar);
            Controls.Add(txtUnidade);
            Controls.Add(txtDezena);
            Controls.Add(txtCentena);
            Name = "frmEx6";
            Text = "frmEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCentena;
        private TextBox txtDezena;
        private TextBox txtUnidade;
        private Button btnRodar;
        private Button btnRodar_para;
        private TextBox txtNaosei;
    }
}