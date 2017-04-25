using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_escolar
{
    class Grupo_code_constructores
    {

        public int idGrupos { get; set; }
        public string horario { get; set; }
        public string Nombre_grupo { get; set; }
        public string Aula { get; set; }
        public Grupo_code_constructores() { }

        public Grupo_code_constructores(int piidgrupos, string pihorario,string pi_nombre_grupo,string piAula)

        {
            this.idGrupos = piidgrupos;
            this.horario = pihorario;
            this.Nombre_grupo = pi_nombre_grupo;
            this.Aula = piAula;

        }
    }
}
