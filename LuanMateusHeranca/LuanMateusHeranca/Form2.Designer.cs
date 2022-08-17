namespace LuanMateusHeranca
{
    partial class Form2
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
            this.txtnomeprof = new System.Windows.Forms.TextBox();
            this.txtidadeprof = new System.Windows.Forms.TextBox();
            this.txttitulaprof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncadprof = new System.Windows.Forms.Button();
            this.btnexibirprof = new System.Windows.Forms.Button();
            this.btnvoltarprof = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnomeprof
            // 
            this.txtnomeprof.Location = new System.Drawing.Point(361, 114);
            this.txtnomeprof.Name = "txtnomeprof";
            this.txtnomeprof.Size = new System.Drawing.Size(223, 20);
            this.txtnomeprof.TabIndex = 0;
            // 
            // txtidadeprof
            // 
            this.txtidadeprof.Location = new System.Drawing.Point(361, 151);
            this.txtidadeprof.Name = "txtidadeprof";
            this.txtidadeprof.Size = new System.Drawing.Size(223, 20);
            this.txtidadeprof.TabIndex = 1;
            // 
            // txttitulaprof
            // 
            this.txttitulaprof.Location = new System.Drawing.Point(361, 187);
            this.txttitulaprof.Name = "txttitulaprof";
            this.txttitulaprof.Size = new System.Drawing.Size(223, 20);
            this.txttitulaprof.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titulação";
            // 
            // btncadprof
            // 
            this.btncadprof.Location = new System.Drawing.Point(107, 292);
            this.btncadprof.Name = "btncadprof";
            this.btncadprof.Size = new System.Drawing.Size(195, 51);
            this.btncadprof.TabIndex = 6;
            this.btncadprof.Text = "Cadastrar";
            this.btncadprof.UseVisualStyleBackColor = true;
            this.btncadprof.Click += new System.EventHandler(this.btncadprof_Click);
            // 
            // btnexibirprof
            // 
            this.btnexibirprof.Location = new System.Drawing.Point(308, 292);
            this.btnexibirprof.Name = "btnexibirprof";
            this.btnexibirprof.Size = new System.Drawing.Size(195, 51);
            this.btnexibirprof.TabIndex = 7;
            this.btnexibirprof.Text = "Exibir";
            this.btnexibirprof.UseVisualStyleBackColor = true;
            this.btnexibirprof.Click += new System.EventHandler(this.btnexibirprof_Click);
            // 
            // btnvoltarprof
            // 
            this.btnvoltarprof.Location = new System.Drawing.Point(509, 292);
            this.btnvoltarprof.Name = "btnvoltarprof";
            this.btnvoltarprof.Size = new System.Drawing.Size(195, 51);
            this.btnvoltarprof.TabIndex = 8;
            this.btnvoltarprof.Text = "Voltar";
            this.btnvoltarprof.UseVisualStyleBackColor = true;
            this.btnvoltarprof.Click += new System.EventHandler(this.btnvoltarprof_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltarprof);
            this.Controls.Add(this.btnexibirprof);
            this.Controls.Add(this.btncadprof);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttitulaprof);
            this.Controls.Add(this.txtidadeprof);
            this.Controls.Add(this.txtnomeprof);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomeprof;
        private System.Windows.Forms.TextBox txtidadeprof;
        private System.Windows.Forms.TextBox txttitulaprof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncadprof;
        private System.Windows.Forms.Button btnexibirprof;
        private System.Windows.Forms.Button btnvoltarprof;
    }
}