namespace t31_projetoBase
{
    partial class frmAlg2
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
            lbl1 = new Label();
            lbl2 = new Label();
            txtTemp = new TextBox();
            txtKm = new TextBox();
            btnMedia = new Button();
            lblMedia = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(107, 91);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(87, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "km percorridos";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(87, 148);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(128, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Tempo Gasto em horas";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(221, 140);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(100, 23);
            txtTemp.TabIndex = 2;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(221, 88);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(100, 23);
            txtKm.TabIndex = 3;
            // 
            // btnMedia
            // 
            btnMedia.Location = new Point(452, 88);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(203, 34);
            btnMedia.TabIndex = 4;
            btnMedia.Text = "calcular media da velociada";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.ForeColor = Color.Navy;
            lblMedia.Location = new Point(492, 178);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(136, 15);
            lblMedia.TabIndex = 5;
            lblMedia.Text = "to aqui só fazendo graça";
            // 
            // frmAlg2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMedia);
            Controls.Add(btnMedia);
            Controls.Add(txtKm);
            Controls.Add(txtTemp);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmAlg2";
            Text = "frmAlg2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txtTemp;
        private TextBox txtKm;
        private Button btnMedia;
        private Label lblMedia;
    }
}