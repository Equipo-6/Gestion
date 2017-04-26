using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Escolar
{
    class Validacion
    {
        public void Letras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                { e.Handled = false; }
                
                else if (char.IsControl(e.KeyChar))
                { e.Handled=false; }

                else if(char.IsSeparator(e.KeyChar))
                { e.Handled=false; }

                else
                { e.Handled=true; }

            }
            catch(Exception ex)
            {}

        }
        public void Numeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                { e.Handled = false; }

                else if (char.IsControl(e.KeyChar))
                { e.Handled = false; }

                else if (char.IsSeparator(e.KeyChar))
                { e.Handled = false; }

                else
                { e.Handled = true; }

            }
            catch (Exception ex)
            { }
        }
    }
}
