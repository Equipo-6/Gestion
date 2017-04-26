using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Control_Escolar
{
    class AlumnoAcciones 
    {
        
        public static int Agregar(Alumnos pAlumno)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into alumno (CURP,Nombre,AMaterno,APaterno) values ('{0}','{1}','{2}','{3}')",
                pAlumno.CURP, pAlumno.Nombre, pAlumno.AMaterno, pAlumno.APaterno));
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


    }
}
