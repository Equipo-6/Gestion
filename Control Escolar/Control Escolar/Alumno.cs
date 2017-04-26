using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Escolar
{
    class Alumno
    {
        public string CURP { get; set; }
        public string Nombre { get; set; }
        public string AMaterno { get; set; }
        public string APaterno { get; set; }
        public int num_control { get; set; }
        public string Numero_Seguro { get; set; }
        public int dia { get; set; }
        public string mes { get; set; }
        public int año { get; set; }
        public int edad { get; set; }
        public string esc_procedencia { get; set; }

        public Alumno() { }

        public Alumno(string pCURP, string pNombre, string pAMaterno, string pAPaterno, int pnum_control,string pNumero_Seguro, int pdia,string pmes,int paño,int pedad,string pesc_procedencia)

        {
            this.CURP = pCURP;
            this.Nombre = pNombre;
            this.AMaterno = pAMaterno;
            this.APaterno = pAPaterno;
            this.num_control = pnum_control;
            this.Numero_Seguro = pNumero_Seguro;
            this.dia = pdia;
            this.mes = pmes;
            this.año = paño;
            this.edad = pedad;
            this.esc_procedencia = pesc_procedencia;
        }
    }
}
