using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_escolar
{
    public partial class frm_Datos_grupo : Form
    {
        public frm_Datos_grupo()
        {
            InitializeComponent();
        }

        private void txt_AlumnoColonia_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion;
            seleccion = cmb_nivelestd.Text;
            switch (seleccion)
            {
                case "Preescolar":
                    {
                        cmb_presco_prim.Visible = true;
                        cmb_prees_horario.Visible = true;
                        cmb_prees_aula.Visible = true;
                     
                        cmb_horario_prim.Visible = false;
                        cmb_aula_prim.Visible = false;
                        cmb_grupo_secu.Visible = false;
                        cmb_horario_secu.Visible = false;
                        cmb_Aula_secu.Visible = false;
                        break;
                    }
                case "Primaria":
                    {
                        cmb_presco_prim.Visible = true;
                        cmb_horario_prim.Visible = true;
                        cmb_aula_prim.Visible = true;
                      
                        cmb_prees_horario.Visible = false;
                        cmb_prees_aula.Visible = false;
                        break;
                    }

                case "Secundaria":
                    {
                        cmb_grupo_secu.Visible = true;
                        cmb_horario_secu.Visible = true;
                        cmb_Aula_secu.Visible = true;
                        cmb_presco_prim.Visible = false;
                        cmb_horario_prim.Visible = false;
                        cmb_aula_prim.Visible = false;
                        cmb_presco_prim.Visible = false;
                        cmb_prees_horario.Visible = false;
                        cmb_prees_aula.Visible = false;
                        break;
                    }
            }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Inscribir_Click(object sender, EventArgs e)
        {
            Grupo_code_constructores variables = new Grupo_code_constructores();

            variables.Nombre_nivel = Cmbnivel.Text.Trim();


            int resultado = Nivel_registrar.Agregar(variables);
            if (resultado > 0)
            {
                MessageBox.Show("Alumno Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Alumno", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
            }
        }
    }
}
