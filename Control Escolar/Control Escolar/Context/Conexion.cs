using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Control_Escolar.Context
{
    public class Conexion
    {
        private static MySqlConnection cnnM;

        public Conexion()
        {
            
        }

        public static MySqlConnection ConectarMysql()
        {
            try
            {
                cnnM = new MySqlConnection("server=127.0.0.1; database=sistema_escolar; User Id=root; pwd=12345;");
                cnnM.Open();
                MessageBox.Show("Ya se conecto a la base de datos");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + e.ToString());
            }

            return cnnM;
        }
        public static void DesconectarMysql()
        {
            cnnM.Close();
        }
    }
}
