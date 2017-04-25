using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Sistema_escolar
{
    class Grupos_registrar
    {
        public static int Agregar(Grupo_code_constructores variable)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Grupos (idGrupos,Horario,Nombre_grupo,Aula) values ('{0}','{1}','{2}','{3}')",
                variable.idGrupos, variable.horario,variable.Nombre_grupo,variable.Aula), Bdconexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
