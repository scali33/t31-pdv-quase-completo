namespace t31_projetoBase
{
    partial class frmEx1
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
            btnVer = new Button();
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Sera impar ou par?";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(109, 94);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 33);
            btnVer.TabIndex = 1;
            btnVer.Text = "verificar";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // txtNum
            // 
            txtNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNum.Location = new Point(97, 65);
            txtNum.Name = "txtNum";
            txtNum.RightToLeft = RightToLeft.No;
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 2;
            // 
            // frmEx1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 217);
            Controls.Add(txtNum);
            Controls.Add(btnVer);
            Controls.Add(label1);
            Name = "frmEx1";
            Text = "frmEx1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVer;
        private TextBox txtNum;
    }
}