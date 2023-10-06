using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Veronica_Ejercicio3_IngresoDireccion
{
    internal class DireccionModel
    {
        /*
         * Ejercicio 03
Se requiere el ingreso de una dirección. 
•	País (selección de una lista de países)
•	Provincia/Region (selección de una lista, de acuerdo al pais seleccionado)
•	Localidad (selección de una lista, de acuerdo a la provincia/región seleccionada)
•	Direccion - Calle (string, opcional, max. 100)
•	Direccion – Numero (int, requerido si se ingresa Calle, max. 6 dígitos)
•	Direccion – Piso (string, requerido si se ingresa Calle, max. 3)
•	Direccion – Dpto (string, requerido si se ingresa Calle, max. 3)

         * */

        /*
         * 
•	Direccion - Calle (string, opcional, max. 100)
•	Direccion – Numero (int, requerido si se ingresa Calle, max. 6 dígitos)
•	Direccion – Piso (string, requerido si se ingresa Calle, max. 3)
•	Direccion – Dpto (string, requerido si se ingresa Calle, max. 3)

         */
        //Creo los constructores
        public string direccion_calle { get; set; }
        public string direccion_numero { get; set; }
        public string direccion_piso { get; set; }
        public string direccion_depto { get; set; }

        internal string ValidarDatosdeDireccion()
        {
            return null;
        }

        //Voy a validar todo los valores de DIRECCION


    }
}
