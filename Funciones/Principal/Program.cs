using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacion;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            string salida = "Prueba";
            char[] excepciones = { 'X' };

            // salida = Valida.formatoCorreo("ej@gmail.com");
            // salida = Valida.formatoTelefono("0000000001");
            // salida = Valida.formatoRFC("GOG800303149", 'M');
            // salida = Formato.rellenarEspacios("123", 10, '/', 'D');
            // salida = Formato.formatoPerzonalizado("AAbbccDeX", "MINUSCULAS", excepciones);
            // salida = Valida.formatoCLABE("1");
            salida = Valida.formatoABA("0");
            Console.WriteLine("Salida: " + salida);
            Console.ReadKey();
        }
    }
}
