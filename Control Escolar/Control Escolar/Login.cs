using Control_Escolar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Control_Escolar
{
    public partial class Login : Form
    {

        MySqlConnection Cn = new MySqlConnection("Server= localhost; Uid=root; Password=root; Database=sistema_escolar; Port=3306; ");
        MySqlCommand Cmd = new MySqlCommand();
       
        public Login()
        {
            InitializeComponent();
            Conexion c = new Conexion();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Boton_LogginIngresar_Click(object sender, EventArgs e)
        {

            Cn.Open();
            Cmd.Connection = Cn;
            try
            {
                Cmd.CommandText = "Select count(*) from session_alumno where Alumno_CURP= '" + textBox1.Text + "'and contra='" + textBox2.Text + "'";
                int valor = int.Parse(Cmd.ExecuteScalar().ToString());
                //CONFIRMA CON UN VALOR 1 , SI EXISTE O NO 
                if (valor == 1)
                {
                    lblmensaje.Text = "Bienvenido";
                }
                else
                {
                    lblmensaje.Text = "no existe";
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = "error siguiente" + ex;
            }
            Cn.Close();
        }
    }
}
