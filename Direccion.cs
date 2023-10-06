using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veronica_Ejercicio3_IngresoDireccion
{
    internal class Direccion
    {
        /*
         * 
•	Direccion - Calle (string, opcional, max. 100)
•	Direccion – Numero (int, requerido si se ingresa Calle, max. 6 dígitos)
•	Direccion – Piso (string, requerido si se ingresa Calle, max. 3)
•	Direccion – Dpto (string, requerido si se ingresa Calle, max. 3)

         */
        //Creo los constructores
        public string direccion_calle { get; set; }
        public int direccion_numero { get; set; }
        public string direccion_piso { get; set; }
        public string direccion_depto { get; set; }



    }
}
