namespace LuanMateusHeranca
{
    partial class Form3
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
            this.btnvoltaraluno = new System.Windows.Forms.Button();
            this.btnexibiraluno = new System.Windows.Forms.Button();
            this.btncadaluno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcursoaluno = new System.Windows.Forms.TextBox();
            this.txtidadealuno = new System.Windows.Forms.TextBox();
            this.txtnomealuno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvoltaraluno
            // 
            this.btnvoltaraluno.Location = new System.Drawing.Point(504, 289);
            this.btnvoltaraluno.Name = "btnvoltaraluno";
            this.btnvoltaraluno.Size = new System.Drawing.Size(195, 51);
            this.btnvoltaraluno.TabIndex = 17;
            this.btnvoltaraluno.Text = "Voltar";
            this.btnvoltaraluno.UseVisualStyleBackColor = true;
            this.btnvoltaraluno.Click += new System.EventHandler(this.btnvoltaraluno_Click);
            // 
            // btnexibiraluno
            // 
            this.btnexibiraluno.Location = new System.Drawing.Point(303, 289);
            this.btnexibiraluno.Name = "btnexibiraluno";
            this.btnexibiraluno.Size = new System.Drawing.Size(195, 51);
            this.btnexibiraluno.TabIndex = 16;
            this.btnexibiraluno.Text = "Exibir";
            this.btnexibiraluno.UseVisualStyleBackColor = true;
            this.btnexibiraluno.Click += new System.EventHandler(this.btnexibiraluno_Click);
            // 
            // btncadaluno
            // 
            this.btncadaluno.Location = new System.Drawing.Point(102, 289);
            this.btncadaluno.Name = "btncadaluno";
            this.btncadaluno.Size = new System.Drawing.Size(195, 51);
            this.btncadaluno.TabIndex = 15;
            this.btncadaluno.Text = "Cadastrar";
            this.btncadaluno.UseVisualStyleBackColor = true;
            this.btncadaluno.Click += new System.EventHandler(this.btncadaluno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Curso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // txtcursoaluno
            // 
            this.txtcursoaluno.Location = new System.Drawing.Point(356, 184);
            this.txtcursoaluno.Name = "txtcursoaluno";
            this.txtcursoaluno.Size = new System.Drawing.Size(223, 20);
            this.txtcursoaluno.TabIndex = 11;
            // 
            // txtidadealuno
            // 
            this.txtidadealuno.Location = new System.Drawing.Point(356, 148);
            this.txtidadealuno.Name = "txtidadealuno";
            this.txtidadealuno.Size = new System.Drawing.Size(223, 20);
            this.txtidadealuno.TabIndex = 10;
            // 
            // txtnomealuno
            // 
            this.txtnomealuno.Location = new System.Drawing.Point(356, 111);
            this.txtnomealuno.Name = "txtnomealuno";
            this.txtnomealuno.Size = new System.Drawing.Size(223, 20);
            this.txtnomealuno.TabIndex = 9;
            this.txtnomealuno.TextChanged += new System.EventHandler(this.txtnomeprof_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltaraluno);
            this.Controls.Add(this.btnexibiraluno);
            this.Controls.Add(this.btncadaluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcursoaluno);
            this.Controls.Add(this.txtidadealuno);
            this.Controls.Add(this.txtnomealuno);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltaraluno;
        private System.Windows.Forms.Button btnexibiraluno;
        private System.Windows.Forms.Button btncadaluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcursoaluno;
        private System.Windows.Forms.TextBox txtidadealuno;
        private System.Windows.Forms.TextBox txtnomealuno;
    }
}