namespace score
{
    partial class Form1
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
            this.menos = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.less2 = new System.Windows.Forms.Button();
            this.plus2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menos
            // 
            this.menos.Location = new System.Drawing.Point(30, 158);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(17, 23);
            this.menos.TabIndex = 0;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // mais
            // 
            this.mais.Location = new System.Drawing.Point(112, 158);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(20, 23);
            this.mais.TabIndex = 1;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = true;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(36, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 120);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(368, 22);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(110, 120);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "0";
            // 
            // less2
            // 
            this.less2.Location = new System.Drawing.Point(367, 158);
            this.less2.Name = "less2";
            this.less2.Size = new System.Drawing.Size(17, 23);
            this.less2.TabIndex = 4;
            this.less2.Text = "-";
            this.less2.UseVisualStyleBackColor = true;
            this.less2.Click += new System.EventHandler(this.less2_Click);
            // 
            // plus2
            // 
            this.plus2.Location = new System.Drawing.Point(458, 158);
            this.plus2.Name = "plus2";
            this.plus2.Size = new System.Drawing.Size(20, 23);
            this.plus2.TabIndex = 5;
            this.plus2.Text = "+";
            this.plus2.UseVisualStyleBackColor = true;
            this.plus2.Click += new System.EventHandler(this.plus2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 206);
            this.Controls.Add(this.plus2);
            this.Controls.Add(this.less2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.menos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button less2;
        private System.Windows.Forms.Button plus2;
    }
}

