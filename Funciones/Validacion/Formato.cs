using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion
{
    public static class Formato
    {
        /// <summary>
        /// Método para rellenar espacios izquierda o derecha
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="longitud"></param>
        /// <param name="relleno"></param>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public static string rellenarEspacios(string cadena, int longitud, char relleno, char direccion)
        {
            string salida = "";

            if (direccion == 'D')
            {
                salida = cadena.PadRight(longitud, relleno);
            }
            else if (direccion == 'I')
            {
                salida = cadena.PadLeft(longitud, relleno);
            }            

            return salida;
        }

        /// <summary>
        /// Método para retornar un formato personalizado
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="tcase"></param>
        /// <param name="excepciones"></param>
        /// <returns></returns>
        public static string formatoPerzonalizado(string cadena, string tcase, char[] excepciones)
        {
            string salida = "";
            char letra;
            string cadenaNueva = "";
            bool valida = true;

            if ((tcase == "MINUSCULAS" || tcase == "MAYUSCULAS" || tcase == "AMBOS"))
            {
                valida = true;
            }
            else
            {
                valida = false;
            }

            if (valida)
            {
                salida = cadena.TrimStart(excepciones);
                salida = salida.TrimEnd(excepciones);
                if (tcase == "MINUSCULAS")
                {
                    for (int i = 0; i < salida.Length; i++)
                    {
                        letra = Convert.ToChar(salida.Substring(i, 1));
                        if (char.IsLower(letra))
                        {
                            cadenaNueva = cadenaNueva + letra;
                        }
                    }
                }
                else if (tcase == "MAYUSCULAS")
                {
                    for (int i = 0; i < salida.Length; i++)
                    {
                        letra = Convert.ToChar(salida.Substring(i, 1));
                        if (char.IsUpper(letra))
                        {
                            cadenaNueva = cadenaNueva + letra;
                        }
                    }
                }

                salida = cadenaNueva;
            }
            
            return salida;
        }
    }
}
