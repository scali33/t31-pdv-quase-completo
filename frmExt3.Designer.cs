namespace t31_projetoBase
{
    partial class frmExt3
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
            txtFrase = new TextBox();
            lbxInfos = new ListBox();
            btnexibir = new Button();
            SuspendLayout();
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(59, 82);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(667, 23);
            txtFrase.TabIndex = 0;
            // 
            // lbxInfos
            // 
            lbxInfos.FormattingEnabled = true;
            lbxInfos.ItemHeight = 15;
            lbxInfos.Location = new Point(59, 234);
            lbxInfos.Name = "lbxInfos";
            lbxInfos.Size = new Size(667, 154);
            lbxInfos.TabIndex = 1;
            // 
            // btnexibir
            // 
            btnexibir.Location = new Point(330, 159);
            btnexibir.Name = "btnexibir";
            btnexibir.Size = new Size(111, 48);
            btnexibir.TabIndex = 2;
            btnexibir.Text = "EXIBIR";
            btnexibir.UseVisualStyleBackColor = true;
            btnexibir.Click += btnexibir_Click;
            // 
            // frmExt3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexibir);
            Controls.Add(lbxInfos);
            Controls.Add(txtFrase);
            Name = "frmExt3";
            Text = "frmExt3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrase;
        private ListBox lbxInfos;
        private Button btnexibir;
    }
}