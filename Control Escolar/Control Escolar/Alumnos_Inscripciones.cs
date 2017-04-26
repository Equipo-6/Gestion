using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Control_Escolar
{
    public partial class Alumnos_Inscripciones : Form
    {
        Validacion validacion = new Validacion();
        public Alumnos_Inscripciones()
        {
            InitializeComponent();
        }
        /* Metodos para generar datos escolares*/
        /*
         * NOMBRE DEL METODO: DatosEscolares
         * PARAMETROS: Ninguno
         * RETORNO: Ninguno
         * FUNCION: En base a la variable edad (txt_AlumnoEdad.Text) compara con los limites que tendra
         *          cada nivel y grado respectivamente.
        */ 
        public void DatosEscolares()
        {
            int edad = Convert.ToInt32(txt_AlumnoEdad.Text);
            if (edad > 2 && edad < 6)
            {

                txt_AlumnoEdad.Text = "01";
                if (edad == 3)
                { txt_AlumnoGrado.Text = "01"; }
                if (edad == 4)
                { txt_AlumnoGrado.Text = "02"; }
                if (edad == 5)
                { txt_AlumnoGrado.Text = "03"; }


            }
            if (edad > 5 && edad < 12)
            {
                textBox3.Text = "02";
                if (edad == 6)
                { txt_AlumnoGrado.Text = "01"; }
                if (edad == 7)
                { txt_AlumnoGrado.Text = "02"; }
                if (edad == 8)
                { txt_AlumnoGrado.Text = "03"; }
                if (edad == 9)
                { txt_AlumnoGrado.Text = "04"; }
                if (edad == 10)
                { txt_AlumnoGrado.Text = "05"; }
                if (edad == 11)
                { txt_AlumnoGrado.Text = "06"; }

            }
            if (edad > 11 && edad < 15)
            {
                textBox3.Text = "03";
                if (edad == 12)
                { txt_AlumnoGrado.Text = "01"; }
                if (edad == 13)
                { txt_AlumnoGrado.Text = "02"; }
                if (edad == 14)
                { txt_AlumnoGrado.Text = "03"; }


            }
        }

        /*
         * NOMBRE DEL METODO: GrupoAlumno
         * PARAMETROS: Ninguno
         * RETORNO: Ninguno
         * FUNCION: Utiliza las variables: nivel & grado, asi mismo le asigna una letra para identificar el tipo
         *          de nivel: nivel1 -> Grado+A
         *                    nivel2 -> Grado+B
         *                    nivel3 -> Grado+C
        */ 
        public void GrupoAlumno()
        {
            if (textBox3.Text == "01")
            { txt_AlumnoGrupo.Text = txt_AlumnoGrado.Text.Substring(1, 1) + 'A'; }
            if (textBox3.Text == "02")
            { txt_AlumnoGrupo.Text = txt_AlumnoGrado.Text.Substring(1, 1) + 'B'; }
            if (textBox3.Text == "03")
            { txt_AlumnoGrupo.Text = txt_AlumnoGrado.Text.Substring(1, 1) + 'C'; }

        }
        /*
         * NOMBRE DEL METODO: Matricula
         * PARAMETROS: Ninguno
         * RETORNO: Ninguno
         * FUNCION: Crea la matricula del alumno a partir de datos personales, como son nivel, grupo, año de inscripcion, etc.
         *          utilizando la instruccion Substring, que jala subcadenas de una cadena original.
         
        */ 
        public void Matricula()
        {
            txt_AlumnoMatricula.Text = textBox3.Text + txt_AlumnoGrupo.Text + textBox4.Text + textBox5.Text + textBox6.Text;

                

        }
        /*
         * NOMBRE DEL METODO: Periodo
         * PARAMETROS: Ninguno
         * RETORNO: Ninguno
         * FUNCION: Crea una variable a partir de un datetimepicker el cual substrae el mes, comparar la variable
         *          para verficar en que periodo se encuentra, esto utilizando las sentencias if.
         
        */ 
        
        public void Periodo()
        {
            string mes= textBox3.Text;
            int NoMes = Convert.ToInt32(mes);

            if (NoMes > 8)
            {
                txt_AlumnoPeriodo.Text = "Agosto/Diciembre " + textBox3.Text;
            }
            else
            {
                txt_AlumnoPeriodo.Text = "Enero/Julio " + textBox3.Text;
            }

            
        }
        /**/

        private void Alumnos_Inscripciones_Load(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Alumnos_Inscripciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Letras(e);
        }

        private void txt_AlumnoAMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Letras(e);
        }

        private void txt_AlumnoEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Numeros(e);
        }

        private void txt_TutorTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Numeros(e);
        }

        private void txt_AlumnoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Numeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosEscolares();
            GrupoAlumno();
            Matricula();
            Periodo();
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno pAlumno = new Alumno();

            pAlumno.CURP = txt_AlumnoCurp.Text.Trim();
            pAlumno.Nombre = txt_AlumnoNombre.Text.Trim();
            pAlumno.AMaterno = txt_AlumnoAMaterno.Text.Trim();
            pAlumno.APaterno = txt_AlumnoAPaterno.Text.Trim();
            pAlumno.num_control = Convert.ToInt32(txt_AlumnoMatricula.Text.Trim());
            pAlumno.Numero_Seguro = txt_AlumnoPoblacion.Text.Trim();
            pAlumno.dia = Convert.ToInt32(textBox8.Text.Trim());
            pAlumno.mes = textBox9.Text.Trim();
            pAlumno.año = Convert.ToInt32(textBox2.Text.Trim());
            pAlumno.edad = Convert.ToInt32(txt_AlumnoEdad.Text.Trim());
            pAlumno.esc_procedencia = textBox1.Text.Trim();


            int resultado = AccionesAlumnos.Agregar(pAlumno);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
