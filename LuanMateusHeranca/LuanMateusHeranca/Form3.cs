﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuanMateusHeranca
{
    public partial class Form3 : Form
    {
        Aluno aluno;
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnomeprof_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadaluno_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txtnomealuno.Text, (Convert.ToInt32(txtidadealuno.Text)), txtcursoaluno.Text);
            txtnomealuno.Clear();
            txtidadealuno.Clear();
            txtcursoaluno.Clear();
        }

        private void btnexibiraluno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImprimeDados());
        }

        private void btnvoltaraluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}
