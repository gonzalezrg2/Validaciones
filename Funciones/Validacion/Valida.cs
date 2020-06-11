using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validacion
{
    public static class Valida
    {
        /// <summary>
        /// Método para validar el formato de un correo
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public static string formatoCorreo(string correo)
        {
            string salida = "";
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(correo, expresion))
            {
                salida = correo;
            }
            return salida;
        }

        /// <summary>
        /// Método para validar el formato de un número de teléfono
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string formatoTelefono(string numero)
        {
            string salida = "";
            string expresion = "^([0-9]{10})$";

            if (Regex.IsMatch(numero, expresion))
            {
                salida = numero;
            }
            return salida;
        }

        /// <summary>
        /// Método para validar el formato de un RFC
        /// </summary>
        /// <param name="RFC"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static string formatoRFC(string RFC, char tipo)
        {
            string salida = "", expresion = "";
            bool valida = true;

            
            if (tipo == 'M') { expresion = "^([A-Z\\s]{3})\\d{6}([A-Z\\w]{3})$"; }
            else if (tipo == 'F') { expresion = "^([A-Z\\s]{4})\\d{6}([A-Z\\w]{3})$"; }
            else { valida = false; }

            if (valida)
            {
                if (Regex.IsMatch(RFC, expresion))
                {
                    salida = RFC;
                }
            }  
            
            return salida;
        }

        /// <summary>
        /// Método para validar CLABE
        /// </summary>
        /// <param name="clabe"></param>
        /// <returns></returns>
        public static string formatoCLABE(string clabe)
        {
            string salida = "", expresion = "^([0-9]{1,4})$";

            if ((Regex.IsMatch(clabe, expresion)))
            {
                if (clabe.Length < 4)
                {
                    clabe = clabe.PadLeft(4, '0');
                }
                salida = clabe;
            }

            return salida;
        }

        /// <summary>
        /// Método para validar clave ABA
        /// </summary>
        /// <param name="aba"></param>
        /// <returns></returns>
        public static string formatoABA(string aba)
        {
            string salida = "", expresion = "^([0-9]{1,9})$";

            if ((Regex.IsMatch(aba, expresion)))
            {
                if (aba.Length < 9)
                {
                    aba = aba.PadLeft(9, '0');
                }
                salida = aba;
            }

            return salida;
        }
    }
}
