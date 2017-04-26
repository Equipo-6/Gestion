using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Escolar
{
    class Alumnos
    {

        public string CURP { get; set; }
        public string Nombre { get; set; }
        public string AMaterno { get; set; }
        public string APaterno { get; set; }


        public Alumnos() { }

        public Alumnos(string CURP, string pNombre, string pAMaterno, string pAPaterno)

        {
            this.CURP = CURP;
            this.Nombre = pNombre;
            this.AMaterno = pAMaterno;
            this.APaterno = pAPaterno;

        }

    }
}
