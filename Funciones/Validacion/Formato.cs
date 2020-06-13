using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        public static string formatoPerzonalizado(string cadena, string tcase, string[] excepciones)
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
                //salida = cadena.TrimStart(excepciones);
                //salida = salida.TrimEnd(excepciones);
                foreach (string e in excepciones)
                {
                    Regex pattern = new Regex(e);
                    pattern.Replace(cadena, "");
                }
                Console.WriteLine(cadena);
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

        /// <summary>
        /// Funciones en pila
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public static string pilaFunciones(string entrada)
        {
            string salida = "", funcion = "";
            char[] suprimir = { '#' };

            try
            {
                if (entrada.Substring(0, 1) == "#")
                {
                    var datos = entrada.TrimStart(suprimir);
                    var datos2 = datos.Split(new string[] { "||" }, StringSplitOptions.None);
                    var parametros = datos2[1].Split('|');
                    funcion = datos2[0];

                    // Invocamos al método formatoCorreo
                    if (funcion == "formatoCorreo")
                    {
                        if (parametros.Length == 1)
                        {
                            salida = Valida.formatoCorreo(parametros[0]);
                        }
                    }

                    // Invocamos al método formatoTelefono
                    if (funcion == "formatoTelefono")
                    {
                        if (parametros.Length == 1)
                        {
                            salida = Valida.formatoTelefono(parametros[0]);
                        }
                    }

                    // Invocamos al método formatoRFC
                    if (funcion == "formatoRFC")
                    {
                        if (parametros.Length == 2)
                        {
                            salida = Valida.formatoRFC(parametros[0], Convert.ToChar(parametros[1]));
                        }
                    }

                    // Invocamos al método formatoCLABE
                    if (funcion == "formatoCLABE")
                    {
                        if (parametros.Length == 1)
                        {
                            salida = Valida.formatoCLABE(parametros[0]);
                        }
                    }

                    // Invocamos al método formatoABA
                    if (funcion == "formatoABA")
                    {
                        if (parametros.Length == 1)
                        {
                            salida = Valida.formatoABA(parametros[0]);
                        }
                    }

                    // Invocamos al método formatoBIC
                    if (funcion == "formatoBIC")
                    {
                        if (parametros.Length == 1)
                        {
                            salida = Valida.formatoBIC(parametros[0]);
                        }
                    }

                    // Invocamos al método tipoCuentaOtrosBancos
                    if (funcion == "tipoCuentaOtrosBancos")
                    {
                        if (parametros.Length == 1)
                        {
                            salida = Valida.tipoCuentaOtrosBancos(parametros[0]);
                        }
                    }

                    // Invocamos al método numeroCuentaOtrosBancos
                    if (funcion == "numeroCuentaOtrosBancos")
                    {
                        if (parametros.Length == 2)
                        {
                            salida = Valida.numeroCuentaOtrosBancos(parametros[0], Convert.ToChar(parametros[1]));
                        }
                    }

                    // Invocamos al método rellenarEspacios
                    if (funcion == "rellenarEspacios")
                    {
                        if (parametros.Length == 4)
                        {
                            salida = Formato.rellenarEspacios(parametros[0], 
                                Convert.ToInt32(parametros[1]), 
                                Convert.ToChar(parametros[2]), 
                                Convert.ToChar(parametros[3]) );
                        }
                    }

                    // Invocamos al método rellenarEspacios
                    //if (funcion == "formatoPerzonalizado")
                    //{
                    //    if (parametros.Length == 3)
                    //    {
                    //        char[] arreglo = { };
                    //        arreglo = parametros[2].Split(',');
                    //        salida = "test";
                    //    }
                    //}

                    Console.WriteLine("Funcion: " + funcion);                    
                }
                else
                {
                    salida = entrada;
                }

                return salida;
            }
            catch (Exception)
            {

                salida = "";
                return salida;
            } 
        }
    }
}
