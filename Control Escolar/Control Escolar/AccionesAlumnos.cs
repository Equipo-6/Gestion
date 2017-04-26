using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Control_Escolar.Context;

namespace Control_Escolar
{
     class AccionesAlumnos
    {
        
        public AccionesAlumnos()
        {
             
        }
        public static int Agregar(Alumno pAlumno)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into alumno (CURP,Nombre,AMaterno,APaterno,num_control,Numero_Seguro,dia,mes,año,edad,esc_procedencia) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}')",
                pAlumno.CURP, pAlumno.Nombre, pAlumno.AMaterno, pAlumno.APaterno, pAlumno.num_control, pAlumno.Numero_Seguro, pAlumno.dia, pAlumno.mes, pAlumno.año, pAlumno.edad, pAlumno.esc_procedencia), Conexion.ConectarMysql());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Alumno> Buscar(string pNombre, string pAPaterno, string pAMaterno, string pnum_control)
        {
            List<Alumno> _lista = new List<Alumno>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT CURP, Nombre,AMaterno,APaterno,num_control,Numero_Seguro,dia,mes,año,edad,esc_procedencia FROM alumno  where Nombre ='{0}' or APaterno='{1}'or AMaterno='{2}'or num_control='{3}'", pNombre,pAPaterno,pAMaterno,pnum_control), Conexion.ConectarMysql());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Alumno pAlumno = new Alumno();

                pAlumno.CURP = _reader.GetString(0);
                pAlumno.Nombre = _reader.GetString(1);
                pAlumno.AMaterno = _reader.GetString(2);
                pAlumno.APaterno = _reader.GetString(3);
                pAlumno.num_control = _reader.GetInt32(4);
                pAlumno.Numero_Seguro = _reader.GetString(5);
                pAlumno.dia = _reader.GetInt32(6);
                pAlumno.mes = _reader.GetString(7);
                pAlumno.año = _reader.GetInt32(8);
                pAlumno.edad = _reader.GetInt32(9);
                pAlumno.esc_procedencia = _reader.GetString(10);
                
                


                _lista.Add(pAlumno);
            }

            return _lista;
        }



        public static Alumno ObtenerAlumno(string pCURP)
        {
            Alumno pAlumno = new Alumno();
            MySqlConnection conexion = Conexion.ConectarMysql();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT CURP, Nombre,AMaterno,APaterno,num_control,Numero_Seguro,dia,mes,año,edad,esc_procedencia FROM alumno where CURP={0}", pCURP), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pAlumno.CURP = _reader.GetString(0);
                pAlumno.Nombre = _reader.GetString(1);
                pAlumno.AMaterno = _reader.GetString(2);
                pAlumno.APaterno = _reader.GetString(3);
                pAlumno.num_control = _reader.GetInt32(4);
                pAlumno.Numero_Seguro = _reader.GetString(5);
                pAlumno.dia = _reader.GetInt32(6);
                pAlumno.mes = _reader.GetString(7);
                pAlumno.año = _reader.GetInt32(8);
                pAlumno.edad = _reader.GetInt32(9);
                pAlumno.esc_procedencia = _reader.GetString(10);

            }

            conexion.Close();
            return pAlumno;

        }



    }
}
