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
    public partial class Form2 : Form
    {
        Professor professor;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadprof_Click(object sender, EventArgs e)
        {
            professor = new Professor(txtnomeprof.Text, (Convert.ToInt32(txtidadeprof.Text)), txttitulaprof.Text);
            txtnomeprof.Clear();
            txtidadeprof.Clear();
            txttitulaprof.Clear();
        }

        private void btnexibirprof_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImprimeDados());
        }

        private void btnvoltarprof_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}
