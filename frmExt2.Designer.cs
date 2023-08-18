namespace t31_projetoBase
{
    partial class frmExt2
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
            cboCidades = new ComboBox();
            btnMostarci = new Button();
            SuspendLayout();
            // 
            // cboCidades
            // 
            cboCidades.FormattingEnabled = true;
            cboCidades.Items.AddRange(new object[] { "São paulo", "Rio de janeiro", "Recife", "Curitiba", "Salvador", "Porto alegre", "catiguá" });
            cboCidades.Location = new Point(148, 68);
            cboCidades.Name = "cboCidades";
            cboCidades.Size = new Size(121, 23);
            cboCidades.TabIndex = 0;
            // 
            // btnMostarci
            // 
            btnMostarci.Location = new Point(148, 136);
            btnMostarci.Name = "btnMostarci";
            btnMostarci.Size = new Size(121, 23);
            btnMostarci.TabIndex = 1;
            btnMostarci.Text = "Qual cidade";
            btnMostarci.UseVisualStyleBackColor = true;
            btnMostarci.Click += btnMostarci_Click;
            // 
            // frmExt2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 282);
            Controls.Add(btnMostarci);
            Controls.Add(cboCidades);
            Name = "frmExt2";
            Text = "frmExt2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboCidades;
        private Button btnMostarci;
    }
}