﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Escolar
{
    public partial class Busqueda_Alumnos : Form
    {
        public Busqueda_Alumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccionesAlumnos.Buscar(textBox1.Text, textBox3.Text, textBox4.Text,textBox2.Text);
        }
    }
}