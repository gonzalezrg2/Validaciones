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
            string[] excepciones = { "X" };

            // salida = Valida.formatoCorreo("ej@gmail.com");
            // salida = Valida.formatoTelefono("0000000001");
            // salida = Valida.formatoRFC("GOG800303149", 'M');
            // salida = Formato.rellenarEspacios("123", 10, '/', 'D');
            // salida = Formato.formatoPerzonalizado("AAbbccDeX", "MINUSCULAS", excepciones);
            // salida = Valida.formatoCLABE("1");
            // salida = Valida.formatoABA("0");
            // salida = Valida.formatoBIC("12345 * 90M");
            // salida = Valida.tipoCuentaOtrosBancos("97");
            // salida = Valida.numeroCuentaOtrosBancos("ABCDE1234560123", 'I');

            // salida = Formato.pilaFunciones("#formatoCorreo||rafael.gonzalez@arpatecnologia.com.mx");
            // salida = Formato.pilaFunciones("#formatoTelefono||1234567890");
            // salida = Formato.pilaFunciones("#formatoRFC||GOG800303149|M");
            // salida = Formato.pilaFunciones("#formatoCLABE||1");
            // salida = Formato.pilaFunciones("#formatoABA||1");
            // salida = Formato.pilaFunciones("#formatoBIC||1234567890M");

            salida = Formato.pilaFunciones("#tipoCuentaOtrosBancos||97");
            Console.WriteLine("Salida: " + salida);

            salida = Formato.pilaFunciones("#numeroCuentaOtrosBancos||123456789012345ABC|N");
            Console.WriteLine("Salida: " + salida);

            salida = Formato.pilaFunciones("#rellenarEspacios||123|10|/|I");
            Console.WriteLine("Salida: " + salida);

            //salida = Formato.pilaFunciones("#formatoPerzonalizado||AAbbccDeX|MINUSCULAS|x,ñ");
            //Console.WriteLine("Salida: " + salida);

            Console.ReadKey();
        }
    }
}
